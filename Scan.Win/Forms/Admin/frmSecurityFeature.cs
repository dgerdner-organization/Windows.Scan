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

namespace Scan.Win
{
    public partial class frmSecurityFeature : frmCRUD
    {
        mgrReference m = new mgrReference();
        ClsSecurityFeature oc = new ClsSecurityFeature();

        public frmSecurityFeature()
        {
            InitializeComponent();
        }

        #region Public Methods

        public void ShowForm()
        {
            //BUTTON_NEW_VISIBLE = BUTTON_DELETE_VISIBLE = false;
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
                txtSecurityFeatureCD.MaxLength = ClsSecurityFeature.Security_Feature_CdMax;
                txtSecurityFeatureDsc.MaxLength = ClsSecurityFeature.Security_DscMax;

                txtSecurityFeatureCD.DataBindings.Add("Text", oc, "Security_Feature_Cd", true, DataSourceUpdateMode.OnPropertyChanged);
                txtSecurityFeatureDsc.DataBindings.Add("Text", oc, "Security_Dsc", true, DataSourceUpdateMode.OnPropertyChanged);
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
                DT = m.GetListOfSecurityFeatures();
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
            txtSecurityFeatureCD.Enabled = true;
            
            base.InsertCalled();
        }

        protected override void UpdateCalled()
        {
            txtSecurityFeatureCD.Enabled = false;
            
            base.UpdateCalled();
        }

        protected override void RowChanged(DataRow dr)
        {
            try
            {
                oc.CopyFrom(new ClsSecurityFeature(dr));
                base.RowChanged(dr);
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        protected override bool SaveChanges()
        {
            try
            {
                if (IS_INSERT)
                {
                    if (!oc.ValidateInsert())
                    {
                        MessageBox.Show("Cannot insert");
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
                    if (!oc.ValidateUpdate())
                    {
                        MessageBox.Show("Cannot update");
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
                oc.CopyFrom(new ClsSecurityFeature());
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
