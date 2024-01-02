using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CS2010.SCAN.Business;
using CS2010.CommonWinCtrls;
using CS2010.Common;

namespace Scan.Win
{
    public partial class frmSunDatabases : frmCRUD
    {
        mgrReference m = new mgrReference();
        ClsSunDatabase sd = new ClsSunDatabase();

        public frmSunDatabases()
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
                txtSunDatabaseCode.MaxLength = ClsSunDatabase.Sun_Database_CdMax;
                txtSunDatabaseDsc.MaxLength = ClsSunDatabase.Sun_Database_DscMax;

                txtSunDatabaseCode.DataBindings.Add("Text", sd,"Sun_Database_Cd",true, DataSourceUpdateMode.OnPropertyChanged);
                txtSunDatabaseDsc.DataBindings.Add("Text", sd, "Sun_Database_Dsc", true, DataSourceUpdateMode.OnPropertyChanged);
                BindHelper.Bind(cmbActive, sd, "Active_Flg");
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
                DT = m.GetListOfSunDatabases();
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
            txtSunDatabaseCode.Enabled = true;
            cmbActive.Enabled = false;
            base.InsertCalled();
        }

        protected override void UpdateCalled()
        {
            txtSunDatabaseCode.Enabled = false;
            cmbActive.Enabled = true;
            base.UpdateCalled();
        }

        protected override void RowChanged(DataRow dr)
        {
            try
            {
                sd.CopyFrom(new ClsSunDatabase(dr));
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


                r = sd.ValidateInsert();

                if (IS_INSERT)
                {
                    sd.DefaultInsert();
                    
                    if (r.AreThereErrors)
                    {
                        MessageBox.Show("Cannot insert: \n\r" + r.ErrMsgText);
                        return false;
                    }
                    if (sd.Insert() < 1)
                    {
                        MessageBox.Show("Insert Failed");
                        return false;
                    }
                }
                else
                {
                    r = sd.ValidateUpdate();

                    if (r.AreThereErrors)
                    {
                        MessageBox.Show("Cannot update: \n\r" + r.ErrMsgText);
                        return false;
                    }
                    if (sd.Update() < 1)
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
                sd.CopyFrom(new ClsSunDatabase());
                sd.DefaultInsert();
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
