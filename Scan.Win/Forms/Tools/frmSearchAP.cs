using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CS2010.CommonWinCtrls;
using Scan.Business;
using CS2010.Common;
using CS2010.SCAN.Business;

namespace Scan.Win
{
    public partial class frmSearchAP : frmSearch
    {
        private sql_AP AP = new sql_AP();

        public frmSearchAP()
        {
            InitializeComponent();

            SQL_BASE = AP;

            LoadPopUps();

            this.WindowState = FormWindowState.Maximized;
        }

        #region Overrides

        protected override bool SearchData()
        {
            try
            {
                // NOTE: this is where I would assemble any search parameters and I would create an over-loaded 'Run' method in the derived SQL_BASE class

                APSearchArguments sa = new APSearchArguments();

                sa.VendorCd = txtVendor.Text;
                sa.SunDatabaseCd = cmbSunDatabase.Text;
                sa.ReferenceNo = txtReferenceNo.Text;
                sa.CheckNo = txtCheckNo.Text;

                if (gbCheckDate.CheckBoxChecked)
                {
                    gbCheckDate.Validate();
                    sa.CheckDateFrom = gbCheckDate.FromDate;
                    sa.CheckDateTo = gbCheckDate.ToDate;
                }

                if (gbInvoiceDate.CheckBoxChecked)
                {
                    gbInvoiceDate.Validate();
                    sa.InvoiceDateFrom = gbInvoiceDate.FromDate;
                    sa.InvoiceDateTo = gbInvoiceDate.ToDate;
                }

                sa.ExcludeSun4 = chxExcludeSun4.Checked;

                AP.RunIt(sa);

                return base.SearchData();

            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
                return false;
            }

        }

        protected override bool ClearData()
        {
            try
            {
                txtVendor.Text = string.Empty;
                cmbSunDatabase.Clear();
                txtReferenceNo.Text = string.Empty;
                txtCheckNo.Text = string.Empty;
                gbCheckDate.Clear();
                gbInvoiceDate.Clear();

                chxExcludeSun4.Checked = true;

                return base.ClearData();
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
                return false;
            }
        }

        protected override void LinkClicked(DataRow dr, String Key)
        {
            try
            {
                if (dr.IsNotNull())
                {
                    ViewFile(dr["FOLDER_NM"].ToString(), dr["FILE_NM"].ToString());
                }

                base.LinkClicked(dr, Key);
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }

        }

        protected override void ButtonClicked(DataRow dr, string Key)
        {
            try
            {

                ClsSunAp sap;
                ClsImageAp iap;
                frmEditAP EditAP = new frmEditAP(); ;

                if (Key == "EDIT")
                {
                    sap = new ClsSunAp(dr);
                    iap = ClsImageAp.GetUsingKey(dr["IMAGE_AP_ID"].ToLong());

                    EditAP.ShowForm(sap, iap);
                }

                ReRunSearch();

                base.ButtonClicked(dr, Key);

            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }


        }

        #endregion

        #region Private Methods

        private void LoadPopUps()
        {
            mgrReference mgr = new mgrReference();
            grdVendor.DataSource = mgr.GetListOfAPVendors();

        }

        private void VendorShow()
        {
            Point p = txtVendor.PointToScreen(Point.Empty);
            p.Y = p.Y + txtVendor.Height;
            popupVendor.Show(p);
        }

        private void VendorSelect()
        {
            DataRow dr = grdVendor.GetDataRow();
            if (dr.IsNull()) return;
            txtVendor.Text = dr[0].ToString();
            popupVendor.Close();
        }

        #endregion

        #region Event Handlers

        private void txtVendor_MouseClick(object sender, MouseEventArgs e)
        {
            VendorShow();
        }

        private void txtVendor_KeyDown(object sender, KeyEventArgs e)
        {
            VendorShow();
        }

        private void grdVendor_Click(object sender, EventArgs e)
        {
//            VendorSelect();
        }

        private void grdVendor_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            VendorSelect();
        }

        #endregion

    }
}
