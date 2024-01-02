using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CS2010.SCAN.Business;
using CS2010.Common;
using Scan.Business;
using CS2010.CommonWinCtrls;

namespace Scan.Win
{
    public partial class frmEditJE : Form
    {
        public frmEditJE()
        {
            InitializeComponent();
        }

        private ClsImageJe ImageJE;
        private ClsSunJe SunJE;


        #region Public Methods

        public void ShowForm(ClsSunJe sje, ClsImageJe ije)
        {
            SunJE = sje;
            ImageJE = ije;

            Bind();

            this.ShowDialog();
        }

        #endregion

        #region Private Methods

        private void Bind()
        {
            try
            {
                // Set Max Lengths on Controls
                // SUN Je
                txtSunJournalNo.MaxLength = ClsSunJe.Journal_NoMax;
                txtSunAccountingPeriod.MaxLength = ClsSunJe.Accounting_PeriodMax;
                txtSunJournalSource.MaxLength = ClsSunJe.Journal_SourceMax;
                txtSunJournalType.MaxLength = ClsSunJe.Journal_TypeMax;
                // Image Je
                txtImageJournalNo.MaxLength = ClsImageJe.Journal_NoMax;

                // Bind to objects
                // SUN Je
                BindHelper.Bind(cmbSunOfficeCd, SunJE, "Office_Cd");
                BindHelper.Bind(cmbSunDatabaseCd, SunJE, "Database_Code");
                BindHelper.Bind(txtSunJournalNo, SunJE, "Journal_No");
                BindHelper.Bind(txtSunAccountingPeriod, SunJE, "Accounting_Period");
                BindHelper.Bind(txtSunJournalSource, SunJE, "Journal_Source");
                BindHelper.Bind(txtSunJournalType, SunJE, "Journal_Type");

                //Image Je
                BindHelper.Bind(cmbImageOfficeCd, ImageJE, "Office_Cd");
                BindHelper.Bind(cmbImageSunDatabaseCd, ImageJE, "Sun_Database_Cd");
                BindHelper.Bind(txtImageJournalNo, ImageJE, "Journal_No");

            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }

        }

        private void SaveSunData()
        {
            try
            {
                ClsResult r = SunJE.ValidateUpdate();

                if (r.AreThereErrors)
                {
                    MessageBox.Show(r.ErrMsgText);
                    return;
                }

                MessageBox.Show((SunJE.Update() < 1) ? "Update Failed." : "Update Success.");

            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }
        }

        private void SaveImageData()
        {
            try
            {
                ClsResult r = ImageJE.ValidateUpdate();

                if (r.AreThereErrors)
                {
                    MessageBox.Show(r.ErrMsgText);
                    return;
                }

                MessageBox.Show((ImageJE.Update() < 1) ? "Update Failed." : "Update Success.");

            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }
        }

        private void Unlink()
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to 'Unlink' the SUN data and the Image?  Doing so will put both in the Unmatched queue.", "Unlink", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.No) return;

                mgrEdit e = new mgrEdit();
                ClsResult r = e.UnlinkJE(SunJE, ImageJE);
                MessageBox.Show((r.AreThereErrors) ? r.ErrMsgText : "Unlink Succeeded.");
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }
        }

        private void ViewImage()
        {
            try
            {
                ViewFile(ImageJE.Folder_Nm, ImageJE.File_Nm);
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }
        }

        private void ViewFile(string Folder, string FileNm)
        {
            try
            {
                string shellFileName = string.Format("{0}\\{1}", Folder, FileNm);
                System.Diagnostics.Process.Start(shellFileName);
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }
        }

        #endregion


        #region Event Handlers
        
        private void btnSaveSunData_Click(object sender, EventArgs e)
        {
            SaveSunData();
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            SaveImageData();
        }

        private void linkImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewImage();
        }

        private void btnUnlink_Click(object sender, EventArgs e)
        {
            Unlink();
        }

        #endregion

    }
}
