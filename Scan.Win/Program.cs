using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using CS2010.Common;
using System.Data;
using System.Threading;
using CS2010.CommonWinCtrls;
using CS2010.CommonReports;
using System.Text;
using System.Reflection;
using CS2010.SCAN.Business;
using System.IO;
using System.Runtime.InteropServices;


namespace Scan.Win
{
    static class Program
    {

        private static frmMain main_window; 

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Setup(args);

                // Try to Login to the application (Domain Controller and Database) ... if fail exit ...
                if (!Login()) return;

                // Connect to the database as the User Account AND save to Connection Manager
                if (!ConnectToDatabase(ClsEnvironment.Database, ClsEnvironment.UserName, ClsEnvironment.GlobalDictionary["SCAN_USER_PWD"], "SCAN"))
                {
                    ShowError("Could not connect to the database.  Please contact your system administrator.");
                    return;
                }

                // Connect to the database as the SECURITY ADMIN AND save to the Connection Manager
                if (!ConnectToDatabase(ClsEnvironment.Database, "SCAN_SEC_ADMIN", ClsEnvironment.GlobalDictionary["SCAN_SECURITY_PWD"], "SECURITY"))
                {
                    ShowError("Could not connect to the database.  Please contact your system administrator.");
                    return;
                }

                ClsScanEnvironment.CurrentUser = ClsUser.GetByUserName(ClsEnvironment.UserName);

                // This is for Crystal if we have any reports ...
                // Start initializing Crystal Reports
                // StartInitialization();

                main_window = new frmMain();
                SetUpMainForm(main_window);
                Application.Run(main_window);
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }

        }

        [DllImport("Shell32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr ShellExecute(
            IntPtr hwnd,
            string lpVerb,
            string lpFile,
            string lpParameters,
            string lpDirectory,
            int nShowCmd);

        #region Application Initialization

        private static void InitializeEnvironment()
        {
            try
            {
                Assembly asm = Assembly.GetExecutingAssembly();
                AssemblyName asmName = asm.GetName();
                string v = asmName.Version.ToString(2);
                if (!string.IsNullOrEmpty(v))
                {
                    string[] parts = v.Split(new char[] { '.' });
                    if (!(parts == null || parts.Length < 2))
                    {
                        string v2 = (parts[1] != null) ? parts[1].Trim() : null;
                        if (!string.IsNullOrEmpty(v2))
                        {
                            long? num = ClsConvert.ToInt64Nullable(v2);
                            if (num != null)
                            {
                                ClsEnvironment.Version = string.Format("{0}.{1:00}", parts[0], num);
                            }
                        }
                    }
                }
            }
            catch
            {
                ClsEnvironment.Version = "";
            }
        }

        private static bool Login()
        {
            try
            {
                using (frmLogin frm = new frmLogin())
                {
                    frm.Text = ClsConfig.Title;
                    if (frm.AttemptLogin() == false) return false;
                    
                    #if DEBUG
                        if (ClsEnvironment.UserName.IsNull()) ClsEnvironment.UserName = "JDORNEY";
                    #else
                        ClsEnvironment.UserName = frm.UserName;
                    #endif

                    return true;
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
                return false;
            }
        }

        private static bool ConnectToDatabase(string dbConnectSection, string user, string pwd, string connKey)
        {
            try
            {
                string strConn = ConfigurationManager.ConnectionStrings[dbConnectSection].ConnectionString;

                if (strConn.IsNullOrWhiteSpace()) return false;

                strConn = strConn.Replace("<user>", user);
                strConn = strConn.Replace("<pwd>", pwd);

                ClsConnection conScan = new ClsConnection(strConn, "Oracle.DataAccess.Client");
                conScan.DbConnectionKey = connKey;
                ClsConMgr.Manager.AddConnection(conScan);

                 object o = conScan.GetScalar("Select 1 from dual");
                 return (!o.IsNull()); 
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
                return false;
            }
        }

        private static void Setup(string[] args)
        {

            ClsEnvironment.GlobalDictionary["SCAN_USER_PWD"] = "W00DCL1FF317";
            ClsEnvironment.GlobalDictionary["SCAN_SECURITY_PWD"] = "W00DCL1FF998";

            #if DEBUG
                SetupDevOptions();
            #else
                if (!SetupCLA(args)) return ;    
            #endif

            InitializeEnvironment();
        }

        private static void SetUpMainForm(Form f)
        {
            f.Text = CS2010.SCAN.Business.ClsScanEnvironment.GetApplicationTitle;
        }

        private static void SetupDevOptions()
        {
            // Setup Database
            frmDevOptions fdo = new frmDevOptions();
            ClsEnvironment.Database = "SCAN" + fdo.ShowDevOptions();
        }

        private static bool SetupCLA(string[] args)
        {
            try
            {
                string argDB = args[0];

                if (args[0].IsNull()) 
                {
                    ShowError("No Database Key supplied in the Command Line Argument.  Please contact your system Administrator.");
                    return false;
                }

                ClsEnvironment.Database = args[0];

                return true;

            }
            catch (Exception ex)
            {
                ShowError(ex);
                return false;
            }
        }

        //private static DataTable CrystalInitTable;

        //private static void AsyncApplicationInitialization()
        //{
        //    try
        //    {
        //        ThreadStart StartDelegate = new ThreadStart(StartInitialization);
        //        Thread aThread = new Thread(StartDelegate);
        //        aThread.Start();
        //    }
        //    catch (Exception ex)
        //    {
        //        ClsErrorHandler.LogWarning(ex.Message);
        //    }
        //}

        //private static void StartInitialization()
        //{
        //    try
        //    {
        //        ClsReportHandler.CrystalInitialization(CrystalInitTable);
        //    }
        //    catch (Exception ex)
        //    {
        //        ClsErrorHandler.LogWarning(ex.Message);
        //    }
        //}

        #endregion		// #region Asynchronous Application Initialization

        #region Display Error/Info Messages

        /// <summary>
        /// Application-wide way of changing the Status on the Main Form. 
        /// </summary>
        public static string Status
        {
            get
            {
                return main_window.Status;
            }
            set
            {
                main_window.Status = value;
                main_window.Refresh();
            }
        }

        private static frmWorking _working; 
        public static void WorkingShow()
        {
            if (_working.IsNull()) _working = new frmWorking();
            _working.ShowForm();
        }

        public static void WorkingClose()
        {
            if (_working.IsNull()) return;
            _working.Close();
            _working = null;
        }

        public static void WorkingMessage(string msg)
        {
            if (_working.IsNull()) return;
            _working.Message = msg;
            main_window.Refresh();
        }

        /// <summary>
        /// Pauses the app for a number of seconds
        /// </summary>
        /// <param name="seconds">Number of seconds to wait</param>
        public static void wait(double seconds)
        {
            System.Threading.Thread.Sleep((int)(1000 * seconds));
        }

        public static bool ShowErrors<T>(List<T> lst) where T : ClsBaseTable
        {
            return Display.ShowErrors<T>("SCAN", lst);
        }

        public static bool ShowError<T>(Exception ex, List<T> lst) where T : ClsBaseTable
        {
            return Display.ShowError<T>("SCAN", ex, lst);
        }

        public static bool ShowError(Exception ex)
        {
            return Display.ShowError("SCAN", ex);
        }

        public static bool ShowError(Exception ex, ClsBaseTable obj)
        {
            return Display.ShowError("SCAN", ex, obj);
        }

        public static bool ShowError(Exception ex, ClsBaseTable obj, string extraInfo)
        {
            return Display.ShowError("SCAN", ex, obj, extraInfo);
        }

        public static bool ShowError(string msg, params object[] args)
        {
            return Display.ShowError("SCAN", msg, args);
        }

        public static bool Show(string msg, params object[] args)
        {
            return Display.Show("SCAN", msg, args);
        }

        #endregion		// #region Display Error/Info Messages


    }
}
