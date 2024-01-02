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
using CS2010.CommonWinCtrls;
using Scan.Business;

namespace Scan.Win
{
    public partial class frmEditAP : Form
    {
        public frmEditAP()
        {
            InitializeComponent();
        }

        private ClsImageAp ImageAP;
        private ClsSunAp SunAP;

        #region Public Methods

        public void ShowForm(ClsSunAp sap, ClsImageAp iap)
        {
            SunAP = sap;
            ImageAP = iap;

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
                // SUN AP
                txtSunJournalEntry.MaxLength = ClsSunAp.Journal_EntryMax;
                txtSunReferenceNo.MaxLength = ClsSunAp.Reference_NoMax;
                txtSunVendorAccountCd.MaxLength = ClsSunAp.Vendor_Account_CdMax;
                txtSunVendorAccountNm.MaxLength = ClsSunAp.Vendor_Account_NmMax;
                txtSunEntryUser.MaxLength = ClsSunAp.Entry_UserMax;
                txtSunCheckNo.MaxLength = ClsSunAp.Check_NoMax;
                // Image AP
                txtImageCheckNo.MaxLength = ClsImageAp.Check_NoMax;

                // Bind to objects
                // SUN AP
                BindHelper.Bind( cmbSunOfficeCd, SunAP,"Office_Cd");
                BindHelper.Bind(cmbSunDatabaseCd, SunAP, "Database_Code");
                BindHelper.Bind(txtSunJournalEntry, SunAP, "Journal_Entry");
                BindHelper.Bind(txtSunReferenceNo, SunAP, "Reference_No");
                BindHelper.Bind(txtSunVendorAccountCd, SunAP, "Vendor_Account_Cd");
                BindHelper.Bind(txtSunVendorAccountNm, SunAP, "Vendor_Account_Nm");
                BindHelper.Bind(txtSunInvoiceAmount, SunAP, "Invoice_Amt");
                BindHelper.Bind(txtSunEntryUser, SunAP, "Entry_User");
                BindHelper.Bind(txtSunInvoiceDt, SunAP, "Invoice_Dt");
                BindHelper.Bind(txtSunCheckDt, SunAP, "Check_Dt");
                BindHelper.Bind(txtSunCheckNo, SunAP, "Check_No");
                //Image AP
                BindHelper.Bind(cmbImageOfficeCd, ImageAP, "Office_Cd");
                BindHelper.Bind(cmbImageSunDatabaseCd, ImageAP, "Sun_Database_Cd");
                BindHelper.Bind(txtImageCheckNo, ImageAP, "Check_No");
                BindHelper.Bind(txtImageInvoiceAmt, ImageAP, "Invoice_Amt");

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
                ClsResult r = SunAP.ValidateUpdate();

                if (r.AreThereErrors)
                {
                    MessageBox.Show(r.ErrMsgText);
                    return;
                }

                MessageBox.Show((SunAP.Update() < 1) ? "Update Failed." : "Update Success.");

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
                ClsResult r = ImageAP.ValidateUpdate();

                if (r.AreThereErrors)
                {
                    MessageBox.Show(r.ErrMsgText);
                    return;
                }

                MessageBox.Show((ImageAP.Update() < 1) ? "Update Failed." : "Update Success.");

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
                ClsResult r = e.UnlinkAP(SunAP, ImageAP);
                MessageBox.Show( (r.AreThereErrors) ? r.ErrMsgText : "Unlink Succeeded." ) ;
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
                ViewFile(ImageAP.Folder_Nm, ImageAP.File_Nm);
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

        private void btnUnlink_Click(object sender, EventArgs e)
        {
            Unlink();
        }

        private void linkImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewImage();
        }

        #endregion



    }
}
