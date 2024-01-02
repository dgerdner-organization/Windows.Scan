using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS2010.Common;
using System.Diagnostics;
using CS2010.SCAN.Business;
using System.Configuration;
using System.IO;

namespace CS2010.SCAN.Business
{

    public static class ClsScanEnvironment 
    {
        #region Public Properties
		 

        public static bool ScanMode
        {
            get;
            set;
        }

        public static ClsUser CurrentUser
        {
            get;
            set;
        }

        public static string GetApplicationTitle
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                // TITLE.[VERSION].[DATABASE].[USER].[APPLICATION_MODE]
                sb.AppendFormat("{0}  [VERSION: {1}]-[DATABASE: {2}]-[USER: {3}]",
                    ClsConfig.Title.ToUpper(),
                    ClsEnvironment.Version.ToUpper(),
                    ClsEnvironment.Database.ToUpper(),
                    ClsEnvironment.UserName.ToUpper());

                return sb.ToString();
            }
        }

        //public static List<string> lstApplicationMode = new List<string>() { "VIEW", "ADMIN", "SCAN", "MATCH", "NA" };
        public static List<string> lstDatabaseMode = new List<string>() { "D", "T", "P" };
        
        public static string CurrentAuditFile
        {
            get
            {
                string dt = string.Format("{0:yyyy-MM-dd}", DateTime.Now);
                return GetAppValue("AuditFile").Replace("[date]", dt);
            }
        }

        public static string AuditStatus
        {
            get
            {
                return GetAppValue("AuditStatus");
            }
        }

        public static string ImageFTPFolder
        {
            get
            {
                return GetAppValue("ImageFTPFolder");
            }
        }

        public static string ImageAPFolder
        {
            get
            {
                return GetAppValue("ImageAPFolder");
            }
        }

        public static string ImageJEFolder
        {
            get
            {
                return GetAppValue("ImageJEFolder");
            }
        }

        public static string Adobe
        {
            get
            {
                return GetAppValue("Adobe");
            }
        }

        public static string ConversionAPFolder
        {
            get
            {
                return GetAppValue("ConversionAPFolder");
            }
        }

        public static string ConversionJEFolder
        {
            get
            {
                return GetAppValue("ConversionJEFolder");
            }
        }

    	#endregion

        #region Public Methods

        public static string AssembleAPImageSource(string fileName)
        {
            return string.Format("{0}\\{1}", ImageFTPFolder, fileName);
        }

        public static string AssembleJEImageSource(string fileName)
        {
            return string.Format("{0}\\{1}", ImageFTPFolder, fileName);
        }

        public static string AssembleAPImageDestination(string fileName)
        {
            return string.Format("{0}\\{1}", ImageAPFolder, System.IO.Path.GetFileName(fileName));
        }

        public static string AssembleJEImageDestination(string fileName)
        {
            return string.Format("{0}\\{1}", ImageJEFolder, System.IO.Path.GetFileName(fileName));
        }

        public static void Audit(string msg)
        {
            Audit(msg, false);
        }

        public static void Audit(string msg, bool banner)
        {
            // If Auditing is NOT turned 'ON' then exit
            if (ClsScanEnvironment.AuditStatus != "ON") return;

            StreamWriter sw = File.AppendText(ClsScanEnvironment.CurrentAuditFile);
            sw.WriteLine(
                (msg.IsNull()) ?
                    string.Empty :
                    (banner) ? msg : string.Format("{0:HH:mm:ss}\t{1}", DateTime.Now, msg) 
                    );
            sw.Close();
        }

        #endregion

        #region Private Properties

        private static string GetAppValue(string key)
        {
            string s;

            try
            {
                s = ConfigurationManager.AppSettings[key].ToString();
            }
            catch
            {
                return string.Empty;
            }
            return s;
        }

        #endregion
    }
     
}
