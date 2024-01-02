using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CS2010.CommonWinCtrls;
using CS2010.SCAN.Business;
using CS2010.Common;

namespace Scan.Win
{
    public partial class frmSecurityConfiguration : frmChildBase
    {
        public frmSecurityConfiguration()
        {
            InitializeComponent();
        }

        #region Private Methods

        private void AddSecurityGroup()
        {
            try
            {
                mgrReference mgrR = new mgrReference();
                ClsResult r = mgrR.AddSecurty(cmbSecurityFeature.Value.ToString(), cmbSecurityGroup.Value.ToLong());

                if (r.AreThereErrors)
                    Program.Show(r.ErrMsgText);
                else
                    LoadSecurityConfiguration();

            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        private void DeleteSecurity()
        {
            try
            {
                mgrReference mgrR = new mgrReference();
                DataRow dr = grdSecurity.GetDataRow();
                long SecurityID = dr["SECURITY_ID"].ToLong();

                ClsResult r = mgrR.RemoveSecurity(SecurityID);

                if (r.AreThereErrors)
                    Program.Show(r.ErrMsgText);
                else
                    LoadSecurityConfiguration();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        private void LoadSecurityConfiguration()
        {
            try
            {
                string FeatureCd = cmbSecurityFeature.Value.ToString();

                mgrReference r = new mgrReference();
                grdSecurity.DataSource = r.GetDeniedSecurity(FeatureCd);
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        #endregion

        #region Event Handlers


        private void cmbSecurityFeature_ValueChanged(object sender, EventArgs e)
        {
            LoadSecurityConfiguration();
        }

        private void ucGridEx1_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            DeleteSecurity();
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            AddSecurityGroup();
        }

        #endregion



    }
}
