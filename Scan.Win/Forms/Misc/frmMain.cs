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

namespace Scan.Win
{
    public partial class frmMain : Form
    {

        private frmConversion _frmConversion;

        private frmMatchAP _frmMatchAP;
        private frmMatchJE _frmMatchJE;

        private frmViewUnmatchedAP _frmViewUnmatchedAP;
        private frmViewUnmatchedJE _frmViewUnmatchedJE;

        private frmSearchAP _frmSearchAP;
        private frmSearchJE _frmSearchJE;

        private frmUser _frmUser;
        private frmOffices _frmOffices;
        private frmOceanCarriers _frmOceanCarriers;
        private frmSunDatabases _frmSunDatabases;

        private frmSecurityConfiguration _frmSecurityConfiguration;
        private frmSecurityFeature _frmSecurityFeature;
        private frmSecurityGroup _frmSecurityGroup;

        public frmMain()
        {
            InitializeComponent();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        public string Status
        {
            get
            {
                return tsslStatus.Text;
            }
            set
            {
                tsslStatus.Text = value;
                this.Refresh();
            }
        }

        #region Private Methods

        private void AccountsPayable()
        {
            
        }


        #endregion

        #region SearchAP

        public void ShowSearchAP()
        {
            try
            {
                if (_frmSearchAP == null) _frmSearchAP = new frmSearchAP();
                _frmSearchAP.FormClosed += new FormClosedEventHandler(this.CloseSearchAP);
                _frmSearchAP.MdiParent = this;
                _frmSearchAP.Show();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }
        private void CloseSearchAP(object sender, FormClosedEventArgs e)
        {
            _frmSearchAP = null;
        }

        private void tsmiSearchAP_Click(object sender, EventArgs e)
        {
            ShowSearchAP();
        }

        #endregion

        #region SearchJE

        private void ShowSearchJE()
        {
            try
            {
                if (_frmSearchJE == null) _frmSearchJE = new frmSearchJE();
                _frmSearchJE.FormClosed += new FormClosedEventHandler(CloseSearchJE);
                _frmSearchJE.MdiParent = this;
                _frmSearchJE.Show();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        private void CloseSearchJE(object sender, FormClosedEventArgs e)
        {
            _frmSearchJE = null;
        }

        private void tsmiSearchJE_Click(object sender, EventArgs e)
        {
            ShowSearchJE();
        }

        #endregion

        #region Users

        private void ShowUsers()
        {
            try
            {
                if (_frmUser == null) _frmUser = new frmUser();
                _frmUser.FormClosed +=new FormClosedEventHandler(CloseUsers);
                _frmUser.MdiParent = this;
                _frmUser.ShowForm();

            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        private void CloseUsers(object sender, FormClosedEventArgs e)
        {
            _frmUser = null;
        }

        private void tsmiUsers_Click(object sender, EventArgs e)
        {
            ShowUsers();
        }


        #endregion

        #region Match AP

        private void ShowMatchAP()
        {
            try
            {
                if (_frmMatchAP == null) _frmMatchAP = new frmMatchAP();
                _frmMatchAP.FormClosed += new FormClosedEventHandler(CloseMatchAP);
                _frmMatchAP.MdiParent = this;
                _frmMatchAP.Show();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        private void CloseMatchAP(object sender, FormClosedEventArgs e)
        {
            _frmMatchAP = null;
        }

        private void tsmiImportAndMatchAP_Click(object sender, EventArgs e)
        {
            ShowMatchAP();
        }

        #endregion

        #region Match JE

        private void ShowMatchJE()
        {
            try
            {
                if (_frmMatchJE == null) _frmMatchJE = new frmMatchJE();
                _frmMatchJE.FormClosed += new FormClosedEventHandler(CloseMatchJE);
                _frmMatchJE.MdiParent = this;
                _frmMatchJE.Show();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        private void CloseMatchJE(object sender, FormClosedEventArgs e)
        {
            _frmMatchJE = null;
        }

        private void tsmiImportAndMatchJE_Click(object sender, EventArgs e)
        {
            ShowMatchJE();
        }

        #endregion

        #region View Unmatched AP

        private void ShowViewUnmatchedAP()
        {
            try
            {
                if (_frmViewUnmatchedAP == null) _frmViewUnmatchedAP = new frmViewUnmatchedAP();
                _frmViewUnmatchedAP.FormClosed += new FormClosedEventHandler(CloseViewUnmatchedAP);
                _frmViewUnmatchedAP.MdiParent = this;
                _frmViewUnmatchedAP.Show();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        private void CloseViewUnmatchedAP(object o, FormClosedEventArgs e)
        {
            _frmViewUnmatchedAP = null;
        }

        private void tsmiViewUnmatchedAP_Click(object sender, EventArgs e)
        {
            ShowViewUnmatchedAP();
        }


        #endregion

        #region View Unmatched JE

        private void ShowViewUnmatchedJE()
        {
            try
            {
                if (_frmViewUnmatchedJE == null) _frmViewUnmatchedJE = new frmViewUnmatchedJE();
                _frmViewUnmatchedJE.FormClosed += new FormClosedEventHandler(CloseViewUnmatchedJE);
                _frmViewUnmatchedJE.MdiParent = this;
                _frmViewUnmatchedJE.Show();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        private void CloseViewUnmatchedJE(object o, FormClosedEventArgs e)
        {
            _frmViewUnmatchedJE = null;
        }

        private void tsmiViewUnmatchedJE_Click(object sender, EventArgs e)
        {
            ShowViewUnmatchedJE();
        }


        #endregion

        #region Offices

        private void ShowOffices()
        {
            try
            {
                if (_frmOffices == null) _frmOffices = new frmOffices();
                _frmOffices.FormClosed+=new FormClosedEventHandler(CloseOffices);
                _frmOffices.MdiParent = this;
                _frmOffices.ShowForm();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        private void CloseOffices(object sender, FormClosedEventArgs e)
        {
            _frmOffices = null;
        }

        private void tsmiOffices_Click(object sender, EventArgs e)
        {
            ShowOffices();
        }

        #endregion

        #region Ocean Carriers

        private void ShowOceanCarriers()
        {
            try
            {
                if (_frmOceanCarriers == null) _frmOceanCarriers = new frmOceanCarriers();
                _frmOceanCarriers.FormClosed+=new FormClosedEventHandler(CloseOceanCarriers);
                _frmOceanCarriers.MdiParent = this;
                _frmOceanCarriers.ShowForm();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        private void CloseOceanCarriers(object o, FormClosedEventArgs e)
        {
            _frmOceanCarriers = null;
        }

        private void tsmiOceanCarriers_Click(object sender, EventArgs e)
        {
            ShowOceanCarriers();
        }

        #endregion

        #region Security Group

        private void ShowSecurityGroup()
        {
            try
            {
                if (_frmSecurityGroup == null) _frmSecurityGroup = new frmSecurityGroup();
                _frmSecurityGroup.FormClosed += new FormClosedEventHandler(CloseSecurityGroup);
                _frmSecurityGroup.MdiParent = this;
                _frmSecurityGroup.ShowForm();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        private void CloseSecurityGroup(object o, FormClosedEventArgs e)
        {
            _frmSecurityGroup = null;
        }

        private void tsmiSecurityGroup_Click(object sender, EventArgs e)
        {
            ShowSecurityGroup();
        }

        #endregion

        #region Security Feature

        private void ShowSecurityFeature()
        {
            try
            {
                if (_frmSecurityFeature == null) _frmSecurityFeature = new frmSecurityFeature();
                _frmSecurityFeature.FormClosed+=new FormClosedEventHandler(CloseSecurityFeature);
                _frmSecurityFeature.MdiParent = this;
                _frmSecurityFeature.ShowForm();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        private void CloseSecurityFeature(object o, FormClosedEventArgs e)
        {
            _frmSecurityFeature = null;
        }
 
        private void tsmiSecurityFeature_Click(object sender, EventArgs e)
        {
            ShowSecurityFeature();
        }

        #endregion

        #region Security Configuration

        private void ShowSecurityConfiguration()
        {
            try
            {
                if (_frmSecurityConfiguration == null) _frmSecurityConfiguration = new frmSecurityConfiguration();
                _frmSecurityConfiguration.FormClosed+=new FormClosedEventHandler(CloseSecurityConfiguration);
                _frmSecurityConfiguration.MdiParent = this;
                _frmSecurityConfiguration.Show();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        private void CloseSecurityConfiguration(object o, FormClosedEventArgs e)
        {
            _frmSecurityConfiguration = null;
        }

        private void tsmiSecurityConfiguration_Click(object sender, EventArgs e)
        {
            ShowSecurityConfiguration();
        }

        #endregion

        #region Database Codes

        private void ShowDatabaseCodes()
        {
            try
            {
                if (_frmSunDatabases == null) _frmSunDatabases = new frmSunDatabases();
                _frmSunDatabases.FormClosed += new FormClosedEventHandler(CloseDatabaseCodes);
                _frmSunDatabases.MdiParent = this;
                _frmSunDatabases.ShowForm();

            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        private void CloseDatabaseCodes(object sender, FormClosedEventArgs e)
        {
            _frmSunDatabases = null;
        }

        private void tsmiDatabaseCodes_Click(object sender, EventArgs e)
        {
            ShowDatabaseCodes();
        }

        #endregion

        #region Conversion

        private void ShowConversion()
        {
            try
            {
                if (_frmConversion == null) _frmConversion = new frmConversion();
                _frmConversion.FormClosed += new FormClosedEventHandler(CloseConversion);
                _frmConversion.MdiParent = this;
                _frmConversion.Show();

            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        private void CloseConversion(object sender, FormClosedEventArgs e)
        {
            _frmSunDatabases = null;
        }

        private void tsmiConversion_Click(object sender, EventArgs e)
        {
            ShowConversion();
        }


        #endregion

        #region Test
        

        private void tsmiTest_Click(object sender, EventArgs e)
        {
            frmTest t = new frmTest();
            t.Show();
        }

        #endregion

        #region Form Load

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetSecurity();
        }        

        #endregion

        #region Set Application Security

        private void SetSecurity()
        {
            try
            {
                mgrReference r = new mgrReference();

                DataTable dt = r.GetDeniedSecurityForUser((long)ClsScanEnvironment.CurrentUser.User_ID);

                if (dt.IsNull()) return;

                foreach (DataRow dr in dt.Rows)
                {
                    switch (dr["SECURITY_FEATURE_CD"].ToString())
                    {
                        case "AP_IMPORT_MATCH":
                            tsmiImportAndMatchAP.Enabled = false;
                            break;
                        case "AP_VIEW_UNMATCHED":
                            tsmiViewUnmatchedAP.Enabled = false;
                            break;
                        case "AP_SEARCH":
                            tsmiSearchAP.Enabled = false;
                            break;
                        case "JE_IMPORT_MATCH":
                            tsmiImportAndMatchJE.Enabled = false;
                            break;
                        case "JE_VIEW_UNMATCHED":
                            tsmiViewUnmatchedJE.Enabled = false;
                            break;
                        case "JE_SEARCH":
                            tsmiSearchJE.Enabled = false;
                            break;
                        case "SECURITY":
                            tsmiSecurity.Enabled = false;
                            break;
                        case "OFFICE_REF":
                            tsmiOffices.Enabled = false;
                            break;
                        case "OCEAN_CARRIER_REF":
                            tsmiOceanCarriers.Enabled = false;
                            break;
                        case "DATABASE_REF":
                            tsmiDatabaseCodes.Enabled = false;
                            break;
                        case "ADMIN_CONVERSION":
                            tsmiConversion.Enabled = false;
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        #endregion

    }
}
