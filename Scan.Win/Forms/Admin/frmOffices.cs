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
    public partial class frmOffices : frmCRUD
    {
        mgrReference m = new mgrReference();
        ClsOffice oc = new ClsOffice();

        public frmOffices()
        {
            InitializeComponent();
        }

        #region Public Methods

        public void ShowForm()
        {
            //BUTTON_DELETE_VISIBLE = false;
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
                txtOfficeCode.MaxLength = ClsOffice.Office_CdMax;
                txtOfficeDesc.MaxLength = ClsOffice.Office_DscMax;

                txtOfficeCode.DataBindings.Add("Text", oc, "Office_Cd", true, DataSourceUpdateMode.OnPropertyChanged);
                txtOfficeDesc.DataBindings.Add("Text", oc, "Office_Dsc", true, DataSourceUpdateMode.OnPropertyChanged);
                BindHelper.Bind(cmbActive, oc, "Active_Flg");
                //chkActive.DataBindings.Add("YN", oc, "Active_Flg", true, DataSourceUpdateMode.OnPropertyChanged);
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
                DT = m.GetListOfOffices();
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
            txtOfficeCode.Enabled = true;
            cmbActive.Enabled = false;
            base.InsertCalled();
        }

        protected override void UpdateCalled()
        {
            txtOfficeCode.Enabled = false;
            cmbActive.Enabled = true;
            base.UpdateCalled();
        }

        protected override void RowChanged(DataRow dr)
        {
            try
            {
                oc.CopyFrom(new ClsOffice(dr));
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
                    if (oc.Insert() < 1)
                    {
                        MessageBox.Show("Insert Failed");
                        return false;
                    }
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
                oc.CopyFrom(new ClsOffice());
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
