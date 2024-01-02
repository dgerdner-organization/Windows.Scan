﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Scan.Business;
using CS2010.Common;
using CS2010.SCAN.Business;

namespace Scan.Win
{
    public partial class frmMatchAP : frmBaseMatchImport
    {
        public frmMatchAP()
        {
            InitializeComponent();
        }

        #region Overrides

        protected override void ImportSunFile()
        {
            ImportAPFile();
            base.ImportSunFile();
        }

        protected override void ImportScannedDocuments()
        {
            ImportAPImages();
            base.ImportScannedDocuments();
        }

        protected override void Match()
        {
            MatchAP();
            base.Match();
        }

        #endregion

        #region Private Methods

        private void ImportAPFile()
        {

            mgrImportSunFiles sunFile = new mgrImportSunFiles();
            sunFile.ImportSunEvent += new mgrImportSunFiles.ImportSunHandler(sunFile_ImportSunEvent);

            try
            {
                string s = OpenFileDialog();
                this.Refresh();
                if (s.IsNotNull())
                {
                    Program.WorkingShow();
                    SunErrors = sunFile.ImportSunAPFile(s, ClsScanEnvironment.CurrentUser.Office);
                }
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.Show("Import Failed!  The transaction was NOT posted to the database. Error: " + ex.Message);
            }
            finally
            {
                Program.WorkingClose();
                sunFile.ImportSunEvent -= new mgrImportSunFiles.ImportSunHandler(sunFile_ImportSunEvent);
            }
        }

        private void sunFile_ImportSunEvent(object o, ImportSunFileEventArgs e)
        {
            if (e.Complete)
            {
                frmResults r = new frmResults();
                r.ShowImportSunFile(e.Number, e.NumberGood, e.NumberBad);
            }
            else
                Program.WorkingMessage(string.Format("SUN data lines read: {0}", e.Number));
        }

        private void ImportAPImages()
        {
            mgrImportScannedImages images = new mgrImportScannedImages();
            images.ImportScannedImageEvent +=new mgrImportScannedImages.ImportScannedImagesHandler(images_ImportScannedImageEvent);
            try
            {
                Program.WorkingShow();
                ScannedDocumentErrors = images.ImportAPImages(ClsScanEnvironment.ImageFTPFolder, ClsScanEnvironment.ImageAPFolder);
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }
            finally
            {
                Program.WorkingClose();
                images.ImportScannedImageEvent -= new mgrImportScannedImages.ImportScannedImagesHandler(images_ImportScannedImageEvent);
            }
        }

        private void images_ImportScannedImageEvent(object o, ImportScannedImagesEventArgs e)
        {
            if (e.Complete)
            {
                frmResults r = new frmResults();
                r.ShowImportImages(e.Number, e.NumberGood, e.NumberBad);
            }
            else
                Program.WorkingMessage(string.Format("Reading image # {0}, {1}", e.Number, e.FileName));
        }

        private void MatchAP()
        {
            mgrMatch match = new mgrMatch();
            match.MatchEvent +=new mgrMatch.MatchHandler(match_MatchEvent);

            try
            {
                Program.WorkingShow();
                match.MatchAP();
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }
            finally
            {
                Program.WorkingClose();
                match.MatchEvent -= new mgrMatch.MatchHandler(match_MatchEvent);
            }
        }

        private void match_MatchEvent(object o, MatchEventArgs e)
        {
            if (e.Complete)
            {
                frmResults r = new frmResults();
                r.ShowMatch(e.UnmatchedSunData, e.UnmatchedImages, e.NumberMatched, e.NumberUnMatched);
            }
            else
                Program.WorkingMessage("Working ...");
        }

        #endregion



    }
}
