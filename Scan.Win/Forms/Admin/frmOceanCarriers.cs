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
    public partial class frmOceanCarriers : frmCRUD
    {

        mgrReference m = new mgrReference();
        ClsOceanCarrier oc = new ClsOceanCarrier();

        public frmOceanCarriers()
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

                txtOceanCarrierCode.MaxLength = ClsOceanCarrier.Ocean_Carrier_CdMax;
                txtOceanCarrierDesc.MaxLength = ClsOceanCarrier.Ocean_Carrier_DscMax;

                txtOceanCarrierCode.DataBindings.Add("Text", oc, "Ocean_Carrier_Cd", true, DataSourceUpdateMode.OnPropertyChanged);
                txtOceanCarrierDesc.DataBindings.Add("Text", oc, "Ocean_Carrier_Dsc", true, DataSourceUpdateMode.OnPropertyChanged);
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
                DT = m.GetListOfOceanCarriers();
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
            txtOceanCarrierCode.Enabled = true;
            cmbActive.Enabled = false;
            base.InsertCalled();
        }

        protected override void UpdateCalled()
        {
            txtOceanCarrierCode.Enabled = false;
            cmbActive.Enabled = true;
            base.UpdateCalled();
        }

        protected override void RowChanged(DataRow dr)
        {
            try
            {
                oc.CopyFrom(new ClsOceanCarrier(dr));
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
                ClsResult r = new ClsResult();

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
                oc.CopyFrom(new ClsOceanCarrier());
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
