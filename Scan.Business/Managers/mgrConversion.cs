using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS2010.Common;
using System.Data;
using CS2010.SCAN.Business;
using System.IO;


namespace Scan.Business
{
    public class mgrConversion : mgrBase
    {

        public delegate void ConversionHandler(object o, ConversionEventArg e);
        public event ConversionHandler ConversionEvent;

        public void ExportAP(string IND)
        {
            try
            {
                ClsConnection conn = new ClsConnection("Data Source=WLHISCAN;Persist Security Info=True;User ID=scanuser;password=chestnut890;", "Oracle.DataAccess.Client");
                DataTable dt = conn.GetDataTable("Select * from t_conversion c where c.export_type = 'AP'");
                DataRow drImage;
                long counter = 0;

                string sql_ext = (IND == "0") ? "" : " and JD_IND = " + IND;  

                foreach (DataRow dr in dt.Rows)
                {
                    drImage = conn.GetDataRow("Select ap.image from t_images_ap ap where ap.images_ap_id = " + dr["IMAGE_ID"].ToString() + sql_ext); 
                    
                    ClsConvert.BlobToFile( 
                        string.Format("{0}{1}", ClsScanEnvironment.ConversionAPFolder, dr["FILE_NM"].ToString()),
                        drImage["IMAGE"].ToByteArray());

                    counter++;
                    ConversionEvent(null, new ConversionEventArg() { FileName = dr["FILE_NM"].ToString(), FileNumber = counter });
                }
            }
            catch (Exception ex)
            {
                ConversionEvent(null, new ConversionEventArg() { Msg = ex.Message } );
                ClsScanEnvironment.Audit(ex.Message);
            }
        }

        public void ExportJE(string IND)
        {
            try
            {
                ClsConnection conn = new ClsConnection("Data Source=WLHISCAN;Persist Security Info=True;User ID=scanuser;password=chestnut890;", "Oracle.DataAccess.Client");
                DataTable dt = conn.GetDataTable("Select * from t_conversion c where c.export_type = 'JE'");
                DataRow drImage;
                long counter = 0;

                string sql_ext = (IND == "0") ? "" : " and JD_IND = " + IND;  

                foreach (DataRow dr in dt.Rows)
                {
                    drImage = conn.GetDataRow("Select JE.image from t_images_JE JE where JE.images_JE_id = " + dr["IMAGE_ID"].ToString() + sql_ext);

                    ClsConvert.BlobToFile(
                        string.Format("{0}{1}", ClsScanEnvironment.ConversionJEFolder, dr["FILE_NM"].ToString()),
                        drImage["IMAGE"].ToByteArray());

                    counter++;
                    ConversionEvent(null, new ConversionEventArg() { FileName = dr["FILE_NM"].ToString(), FileNumber = counter });
                }
            }
            catch (Exception ex)
            {
                ConversionEvent(null, new ConversionEventArg() { Msg = ex.Message });
                ClsScanEnvironment.Audit(ex.Message);
            }
        }

        public void SubFolderConvertAP()
        {
            try
            {
                long counter = 0;
                string sql = "Select * from t_ap_subfolder_convert order by image_ap_id";
                string sourceFileNm;
                string destFileNm;
                ClsImageAp ap;

                DataTable dt = Connection.GetDataTable(sql);

                foreach (DataRow dr in dt.Rows)
                {
                    ap = ClsImageAp.GetUsingKey((long)dr[0]);

                    sourceFileNm = dr[1].ToString() + "\\" + ap.File_Nm;
                    destFileNm = dr[2].ToString() + "\\" + ap.File_Nm;

                    try
                    {
                        File.Move(sourceFileNm, destFileNm);

                        ap.Folder_Nm = dr[2].ToString();
                        if (ap.Update() < 1)
                            ConversionEvent(null, new ConversionEventArg() 
                                { Msg = string.Format("Could not update {0}", dr[2].ToString()) });                        
                    }
                    catch
                    {
                        ConversionEvent(null, new ConversionEventArg() { FileName = ap.File_Nm, FileNumber = counter, Msg="Move or Update Failed" });
                    }

                    counter++;
                    ConversionEvent(null, new ConversionEventArg() { FileName = ap.File_Nm, FileNumber = counter });

                }
            }
            catch (Exception ex)
            {
                ConversionEvent(null, new ConversionEventArg() { Msg = ex.Message });
                ClsScanEnvironment.Audit(ex.Message);
            }
        }

        public void SubFolderConvertJE()
        {
            try
            {
                long counter = 0;
                string sql = "Select * from t_JE_subfolder_convert order by image_JE_id";
                string sourceFileNm;
                string destFileNm;
                ClsImageJe JE;

                DataTable dt = Connection.GetDataTable(sql);

                foreach (DataRow dr in dt.Rows)
                {
                    JE = ClsImageJe.GetUsingKey((long)dr[0]);

                    sourceFileNm = dr[1].ToString() + "\\" + JE.File_Nm;
                    destFileNm = dr[2].ToString() + "\\" + JE.File_Nm;

                    try
                    {
                        File.Move(sourceFileNm, destFileNm);

                        JE.Folder_Nm = dr[2].ToString();
                        if (JE.Update() < 1)
                        {
                            ConversionEvent(null, new ConversionEventArg() { Msg = string.Format("Could not update {0}", dr[2].ToString()) });
                        }
                    }
                    catch 
                    {
                        ConversionEvent(null, new ConversionEventArg() { FileName = JE.File_Nm, FileNumber = counter, Msg = "Move or Update Failed" });
                    }

                    counter++;
                    ConversionEvent(null, new ConversionEventArg() { FileName = JE.File_Nm, FileNumber = counter });

                }
            }
            catch (Exception ex)
            {
                ConversionEvent(null, new ConversionEventArg() { Msg = ex.Message });
                ClsScanEnvironment.Audit(ex.Message);
            }
        }

        public void SubFolderCleanupAP()
        {
            try
            {
                ClsImageAp ap;
                List<string> apFiles = GetFolderList(ClsScanEnvironment.ImageFTPFolder, "AP*.PDF");

                foreach (string s in apFiles)
                {
                    ap = ClsImageAp.GetByFileName( ParseFileNameFromPath(s));

                    // if null then assume they have not imported the file yet ...
                    if (ap.IsNull())
                    {
                        ConversionEvent(null, new ConversionEventArg() { FileName = s, Msg = string.Format("File '{0}' has been imported yet (assumption).", s) });
                    }

                    // if NOT null then it has been recorded in the database.  If it is NOT in the correct directory then move it there!
                    if (ap.IsNotNull())
                    {
                        if (!VerifyFile(ap.Folder_Nm, ap.File_Nm))
                        {
                            MoveFile(s, ap.FullFileName);
                            ap.Folder_Nm = ClsScanEnvironment.ImageAPFolder;
                            ap.Update();
                            ConversionEvent(null, new ConversionEventArg() { FileName = ap.File_Nm, Msg=string.Format("File '{0}' has been moved.", ap.File_Nm) });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ConversionEvent(null, new ConversionEventArg() { Msg = ex.Message });
                ClsScanEnvironment.Audit(ex.Message);
            }
        }

        public void SubFolderCleanupJE()
        {
            try
            {
                ClsImageJe je;
                List<string> jeFiles = GetFolderList(ClsScanEnvironment.ImageFTPFolder, "je*.PDF");

                foreach (string s in jeFiles)
                {
                    je = ClsImageJe.GetByFileName( ParseFileNameFromPath(s));

                    // if null then assume they have not imported the file yet ...
                    if (je.IsNull())
                    {
                        ConversionEvent(null, new ConversionEventArg() { FileName = s, Msg = string.Format("File '{0}' has been imported yet (assumption).", s) });
                    }

                    // if NOT null then it has been recorded in the database.  If it is NOT in the correct directory then move it there!
                    if (je.IsNotNull())
                    {
                        if (!VerifyFile(je.Folder_Nm, je.File_Nm))
                        {
                            MoveFile(s, ClsScanEnvironment.ImageJEFolder + '\\' + je.File_Nm);
                            je.Folder_Nm = ClsScanEnvironment.ImageJEFolder;
                            je.Update();
                            ConversionEvent(null, new ConversionEventArg() { FileName = je.File_Nm, Msg = string.Format("File '{0}' has been moved.", je.File_Nm) });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ConversionEvent(null, new ConversionEventArg() { Msg = ex.Message });
                ClsScanEnvironment.Audit(ex.Message);
            }
        }


    }

    public class ConversionEventArg
    {
        public long FileNumber;
        public string FileName;
        public string Msg;
    }
}
