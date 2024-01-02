using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS2010.SCAN.Business;

namespace Scan.Business
{
    public class mgrImportScannedImages : mgrBase
    {
        public delegate void ImportScannedImagesHandler(object o, ImportScannedImagesEventArgs e);
        public event ImportScannedImagesHandler ImportScannedImageEvent;


        #region Public Properties

        public int NumberOfImages { get; set; }
        public int NumberOfGood { get; set; }
        public int NumberOfBad { get; set; }

        #endregion

        public List<string> ImportAPImages(string sourcePath, string destPath)
        {
            List<string> lstResults = new List<string>();
            List<string> lstS = GetFolderList(sourcePath, "AP*.pdf");
            ClsImageAp ap;
            int counter = 0;

            NumberOfImages = lstS.Count;

            foreach (string s in lstS)
            {
                ap = new ClsImageAp(s);
                if (!CopyFile(s, ClsScanEnvironment.AssembleAPImageDestination(s)))
                {
                    NumberOfBad++;
                    ClsScanEnvironment.Audit(string.Format("Imported AP file {0} ... COPY FAILED.", s));
                    lstResults.Add(string.Format("Imported AP file {0} ... COPY FAILED.", s));

                    try
                    {
                        if (ap.Insert() != 1)
                        {
                            NumberOfBad++;
                            ClsScanEnvironment.Audit(string.Format("Imported AP file {0} ... INSERT FAILED.", s));
                            lstResults.Add(string.Format("Imported AP file {0} ... INSERT FAILED.", s));
                        }
                        else
                        {
                            DeleteFile(s);
                            NumberOfGood++;
                            ClsScanEnvironment.Audit(string.Format("Imported AP file {0}.", s));
                        }
                    }
                    catch (Exception ex)
                    {
                        ClsScanEnvironment.Audit(string.Format("Imported AP file {0} ... INSERT FAILED. Err={1}", s, ex.Message));
                        lstResults.Add(string.Format("Imported AP file {0} ... INSERT FAILED.  Err={1}", s, ex.Message));
                    }

                }
                counter++;
                ImportScannedImageEvent(null, new ImportScannedImagesEventArgs() { FileName = ap.File_Nm, Number = counter, Complete = false } );
            }
            ImportScannedImageEvent(null, new ImportScannedImagesEventArgs() { Number = counter, NumberGood = NumberOfGood, NumberBad = NumberOfBad, Complete = true });

            return lstResults;
        }

        public List<string> ImportJEImages(string sourcePath, string destPath)
        {
            List<string> lstResults = new List<string>();
            List<string> lstS = GetFolderList(sourcePath, "JE*.pdf");
            ClsImageJe JE;
            int counter = 0;

            NumberOfImages = lstS.Count;

            foreach (string s in lstS)
            {
                JE = new ClsImageJe(s);
                if (!CopyFile(s, ClsScanEnvironment.AssembleJEImageDestination(s)))
                {
                    NumberOfBad++;
                    ClsScanEnvironment.Audit(string.Format("Imported JE file {0} ... COPY FAILED.", s));
                    lstResults.Add(string.Format("Imported JE file {0} ... COPY FAILED.", s));

                    try
                    {
                        if (JE.Insert() != 1)
                        {
                            NumberOfBad++;
                            ClsScanEnvironment.Audit(string.Format("Imported JE file {0} ... INSERT FAILED.", s));
                            lstResults.Add(string.Format("Imported JE file {0} ... INSERT FAILED.", s));
                        }
                        else
                        {
                            DeleteFile(s);
                            NumberOfGood++;
                            ClsScanEnvironment.Audit(string.Format("Imported JE file {0}.", s));
                        }
                    }
                    catch (Exception ex)
                    {
                        ClsScanEnvironment.Audit(string.Format("Imported JE file {0} ... INSERT FAILED. Err={1}", s, ex.Message));
                        lstResults.Add(string.Format("Imported JE file {0} ... INSERT FAILED. Err={1}", s, ex.Message));
                    }
                }
                counter++;
                ImportScannedImageEvent(null, new ImportScannedImagesEventArgs() { FileName = JE.File_Nm, Number = counter, Complete = false });
            }
            ImportScannedImageEvent(null, new ImportScannedImagesEventArgs() { Number = counter, NumberGood = NumberOfGood, NumberBad = NumberOfBad, Complete = true });

            return lstResults;

        }

    }

    public class ImportScannedImagesEventArgs
    {
        public string FileName;
        public int Number;
        public int NumberGood;
        public int NumberBad;
        public bool Complete;
    }

}
