using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Scan.Business;
using CS2010.SCAN.Business;
using CS2010.Common;

namespace Scan.Win
{
    public partial class frmViewUnmatchedAP : frmBaseViewUnmatched
    {

        private BindingList<clsAPManualMatch> lstCOMMIT;
        private BindingList<ClsImageAp> lstIMAGE;
        private BindingList<ClsSunAp> lstSUN;

        public frmViewUnmatchedAP()
        {
            InitializeComponent();
        }

        #region Overrides

        protected override void Match()
        {
            APMatch();
            base.Match();
        }

        protected override void CommitToDatabase()
        {
            Commit();
            base.CommitToDatabase();
        }

        protected override void DeleteImages()
        {
            DeleteAPImages();
            base.DeleteImages();
        }

        protected override void DeleteSunRecords()
        {
            DeleteAPSunRecords();
            base.DeleteSunRecords();
        }

        #endregion

        #region Private Methods

        private void DeleteAPImages()
        {
            try
            {
                BindingList<ClsImageAp> lstDocs = new BindingList<ClsImageAp>(grdScannedDocument.GetCheckedList<ClsImageAp>());

                if (lstDocs.Count < 1)
                {
                    MessageBox.Show("Nothing to do ...");
                    return;
                }

                mgrMatch mm = new mgrMatch();
                ClsResult r = mm.APDeleteImages(lstDocs);

                if (r.AreThereErrors)
                    MessageBox.Show(r.ErrMsgText);
                else
                {
                    foreach (ClsImageAp delAp in lstDocs)
                        lstIMAGE.Remove(delAp);

                    RefreshGrids();

                    MessageBox.Show("Delete Complete");
                    //LoadDataSources();
                }
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }
        }

        private void DeleteAPSunRecords()
        {
            try
            {
                BindingList<ClsSunAp> lstSun = new BindingList<ClsSunAp>(grdSUNData.GetCheckedList<ClsSunAp>());

                if (lstSun.Count < 1)
                {
                    MessageBox.Show("Nothing to do ...");
                    return;
                }

                mgrMatch mm = new mgrMatch();
                ClsResult r = mm.APDeleteSunRecords(lstSun);

                if (r.AreThereErrors)
                    MessageBox.Show(r.ErrMsgText);
                else
                {
                    foreach (ClsSunAp delAp in lstSun)
                        lstSUN.Remove(delAp);

                    RefreshGrids();

                    MessageBox.Show("Delete Complete");
                    //LoadDataSources();
                }
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }
        }


        private void LoadDataSources()
        {
            mgrMatch m = new mgrMatch();

            lstIMAGE = m.GetAPUnmatchedImages();
            grdScannedDocument.DataSource = lstIMAGE;

            lstSUN = m.GetAPUnmatcheSunData();
            grdSUNData.DataSource = lstSUN;

            this.WindowState = FormWindowState.Maximized;
        }

        private void APMatch()
        {

            mgrMatch m = new mgrMatch();
            
            try
            {
                BindingList<ClsImageAp> lstDocs = new BindingList<ClsImageAp>(grdScannedDocument.GetCheckedList<ClsImageAp>());
                BindingList<ClsSunAp> lstSun = new BindingList<ClsSunAp>(grdSUNData.GetCheckedList<ClsSunAp>());

                clsAPManualMatch mm = m.APManualMatch(lstDocs, lstSun);

                if (mm.AreThereErrors)
                {
                    Program.Show(mm.ErrMsg);
                    return;
                }

                AddMatch(mm);

            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }
            finally
            {
            }
        }

        private void AddMatch(clsAPManualMatch mm)
        {
            try
            {
                lstIMAGE.Remove(mm.objIMAGE_AP);
                lstSUN.Remove(mm.objSUN_AP);

                if (lstCOMMIT == null)
                    lstCOMMIT = new BindingList<clsAPManualMatch>();

                lstCOMMIT.Add(mm);

                RefreshGrids();

            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }
        }

        private void Remove(clsAPManualMatch mm)
        {
            try
            {
                lstCOMMIT.Remove(mm);
                lstIMAGE.Add(mm.objIMAGE_AP);
                lstSUN.Add(mm.objSUN_AP);

                RefreshGrids();
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }
        }

        private void Commit()
        {
            try
            {
                if (lstCOMMIT == null)
                {
                    Program.Show("Nothing to Commit.");
                    return;
                }

                mgrMatch m = new mgrMatch();

                if (m.CommitAP(lstCOMMIT))
                {
                    Program.Show("Data committed to Database.");
                    ResetManualMatch();
                }
                else
                {
                    Program.Show("Errors were encountered.  NO data was commited to the Database.");
                }

            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }
        }

        private void ResetManualMatch()
        {
            try
            {
                lstCOMMIT = new BindingList<clsAPManualMatch>();
                grdCommit.DataSource = null;
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }
        }

        private void RefreshGrids()
        {
            grdScannedDocument.DataSource = null;
            grdScannedDocument.DataSource = lstIMAGE;
            grdScannedDocument.Refresh();

            grdSUNData.DataSource = null;
            grdSUNData.DataSource = lstSUN;
            grdSUNData.Refresh();

            grdCommit.DataSource = null;
            grdCommit.DataSource = lstCOMMIT;
            grdCommit.Refresh();
        }

        #endregion

        #region Event Handlers

        private void frmViewUnmatchedAP_Load(object sender, EventArgs e)
        {
            LoadDataSources();
        }

        private void grdScannedDocument_LinkClicked(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (e.Column.DataMember == "FILE_NM")
            {
                ClsImageAp ap = (ClsImageAp)grdScannedDocument.CurrentRow.DataRow;
                ViewFile(ap.Folder_Nm, ap.File_Nm);
            }
        }

        private void grdCommit_LinkClicked(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (e.Column.DataMember == "objIMAGE_AP.FILE_NM")
            {
                clsAPManualMatch ap = (clsAPManualMatch)grdCommit.CurrentRow.DataRow;
                ViewFile(ap.objIMAGE_AP.Folder_Nm, ap.objIMAGE_AP.File_Nm);
            }
        }

        private void grdCommit_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (e.Column.Key == "UNLINK")
            {
                clsAPManualMatch mm = (clsAPManualMatch)grdCommit.CurrentRow.DataRow;
                Remove(mm);
            }
        }

        #endregion



    }
}
