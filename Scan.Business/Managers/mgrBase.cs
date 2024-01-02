using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CS2010.SCAN.Business;
using CS2010.Common;

namespace Scan.Business
{
    public class mgrBase
    {


        #region Connection Manager

        protected static ClsConnection Connection
        {
            get { return ClsConMgr.Manager["SCAN"]; }
        }

        #endregion		// #region Connection Manager

        /// <summary>
        /// Gets the list of files to from a directory.  
        /// </summary>
        /// <param name="strFolderName">Path of the folder to examine.</param>
        /// <param name="pattern">Patter of file to look for ... example 'AP*.PDF' or ' JE*.pdf'</param>
        /// <returns></returns>
        protected List<string> GetFolderList(string strFolderName, string pattern)
        {
            string[] files = Directory.GetFiles(strFolderName, pattern);
            return files.ToList<string>();
        }

        protected bool CopyFile(string source, string dest)
        {
            try
            {
                System.IO.File.Copy(source, dest);
                return true;
            }
            catch (Exception ex)
            {
                ClsScanEnvironment.Audit(ex.Message);
                return false;
            }
        }

        protected bool DeleteFile(string file)
        {
            try
            {
                System.IO.File.Delete(file);
                return true;
            }
            catch (Exception ex)
            {
                ClsScanEnvironment.Audit(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// This is the same as a 'Cut/Paste' file operation
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dest"></param>
        /// <returns></returns>
        protected bool MoveFile(string source, string dest)
        {
            try
            {
                System.IO.File.Move(source, dest);
                return true;
            }
            catch (Exception ex)
            {
                ClsScanEnvironment.Audit(ex.Message);
                return false;
            }
        }


        protected bool VerifyFile(string FolderNm, string FileNm)
        {
            try
            {
                string FullFileNm = string.Format("{0}\\{1}", FolderNm, FileNm);
                return VerifyFile(FullFileNm);
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                return false;
            }
        }

        protected bool VerifyFile(string FullFileNm)
        {
            try
            {
                return System.IO.File.Exists(FullFileNm);
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                return false;
            }
        }

        protected string ParseFileNameFromPath(string FullName)
        {
            try
            {
                return Path.GetFileName(FullName);
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                return string.Empty;
            }
        }


    }
}
