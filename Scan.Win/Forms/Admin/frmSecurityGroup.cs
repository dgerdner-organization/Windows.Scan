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
    public partial class frmSecurityGroup : frmCRUD
    {
        mgrReference m = new mgrReference();
        ClsSecurityGroup oc = new ClsSecurityGroup();

        public frmSecurityGroup()
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
                txtSecurityGroupDsc.MaxLength = ClsSecurityGroup.Security_Group_DscMax;

                txtSecurityGroupDsc.DataBindings.Add("Text", oc, "Security_Group_Dsc", true, DataSourceUpdateMode.OnPropertyChanged);
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
                DT = m.GetListOfSecurityGroups();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        #endregion

        #region Overrides

        protected override void RowChanged(DataRow dr)
        {
            try
            {
                oc.CopyFrom(new ClsSecurityGroup(dr));
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
                oc.CopyFrom(new ClsSecurityGroup());
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
