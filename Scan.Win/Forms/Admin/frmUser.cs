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
    public partial class frmUser : frmCRUD
    {
        mgrReference m = new mgrReference();
        ClsUser oc = new ClsUser();

        public frmUser()
        {
            InitializeComponent();
        }

        #region Public Methods

        public void ShowForm()
        {
            RefreshGrid();
            Bind();
            this.Show();
        }
        
        #endregion

        #region Private Methods

        private void Bind()
        {
            try
            {
                txtDomainName.MaxLength = ClsUser.Domain_NmMax;

                txtDomainName.DataBindings.Add("Text", oc, "DOMAIN_NM", true, DataSourceUpdateMode.OnPropertyChanged);
                cmbSecurityGroup.DataBindings.Add("Value", oc,"Security_Group_ID", true, DataSourceUpdateMode.OnPropertyChanged);
                cmbOffice.DataBindings.Add("Value", oc, "Office_Cd", true, DataSourceUpdateMode.OnPropertyChanged);
                BindHelper.Bind(cmbActive, oc, "Active_Flg");
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        private void RefreshGrid()
        {
            try
            {
                DT = m.GetListOfUsers();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        #endregion

        #region Overrides

        protected override void InsertCalled()
        {
            txtDomainName.Enabled = true;
            cmbActive.Enabled = false;
            base.InsertCalled();
        }

        protected override void UpdateCalled()
        {
            txtDomainName.Enabled = false;
            cmbActive.Enabled = true;
            base.UpdateCalled();
        }

        protected override void RowChanged(DataRow dr)
        {
            try
            {
                oc.CopyFrom(new ClsUser(dr));
                base.RowChanged(dr);
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        protected override bool SaveChanges()
        {
            ClsResult r = new ClsResult();

            try
            {
                if (IS_INSERT)
                {
                    oc.DefaultInsert();

                    r = oc.ValidateInsert();

                    if (r.AreThereErrors)
                    {
                        MessageBox.Show("Cannot insert: \n\r" + r.ErrMsgText);
                        return false;
                    }
                    // If error in 'AddUser' it will be caught and handled below ...
                    oc.AddUser();
                }
                else
                {
                    r = oc.ValidateUpdate();

                    if (r.AreThereErrors)
                    {
                        MessageBox.Show("Cannot update: \n\r" + r.ErrMsgText);
                        return false;
                    }
                    if (oc.Update() < 1)
                    {
                        MessageBox.Show("Update Failed");
                        return false;
                    }
                }
                RefreshGrid();
                return base.SaveChanges();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
                return false;
            }
        }

        protected override bool NewData()
        {
            try
            {
                oc.CopyFrom(new ClsUser());
                oc.DefaultInsert();
                return base.NewData();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
                return false;
            }
        }

        protected override bool EditData(DataRow dr)
        {
            try
            {
                return base.EditData(dr);
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
                return false;
            }
        }
           
        #endregion
    }
}
