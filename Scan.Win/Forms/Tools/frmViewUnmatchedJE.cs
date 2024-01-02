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
    public partial class frmViewUnmatchedJE : frmBaseViewUnmatched
    {
        private BindingList<clsJEManualMatch> lstCOMMIT;
        private BindingList<ClsImageJe> lstIMAGE;
        private BindingList<ClsSunJe> lstSUN;

        public frmViewUnmatchedJE()
        {
            InitializeComponent();
        }

        #region Overrides

        protected override void Match()
        {
            JEMatch();
            base.Match();
        }

        protected override void CommitToDatabase()
        {
            Commit();
            base.CommitToDatabase();
        }

        protected override void DeleteImages()
        {
            DeleteJEImages();
            base.DeleteImages();
        }

        protected override void DeleteSunRecords()
        {
            DeleteJESunRecords();
            base.DeleteSunRecords();
        }

        #endregion

        #region Private Methods

        private void DeleteJEImages()
        {
            try
            {
                BindingList<ClsImageJe> lstDocs = new BindingList<ClsImageJe>(grdScannedDocument.GetCheckedList<ClsImageJe>());

                if (lstDocs.Count < 1)
                {
                    MessageBox.Show("Nothing to do ...");
                    return;
                }

                mgrMatch mm = new mgrMatch();
                ClsResult r = mm.JEDeleteImages(lstDocs);

                if (r.AreThereErrors)
                    MessageBox.Show(r.ErrMsgText);
                else
                {
                    foreach (ClsImageJe delJe in lstDocs)
                        lstIMAGE.Remove(delJe);

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

        private void DeleteJESunRecords()
        {
            try
            {
                BindingList<ClsSunJe> lstSun = new BindingList<ClsSunJe>(grdSUNData.GetCheckedList<ClsSunJe>());

                if (lstSun.Count < 1)
                {
                    MessageBox.Show("Nothing to do ...");
                    return;
                }

                mgrMatch mm = new mgrMatch();
                ClsResult r = mm.JEDeleteSunRecords(lstSun);

                if (r.AreThereErrors)
                    MessageBox.Show(r.ErrMsgText);
                else
                {
                    foreach (ClsSunJe delJe in lstSun)
                        lstSUN.Remove(delJe);

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

            lstIMAGE = m.GetJEUnmatchedImages();
            grdScannedDocument.DataSource = lstIMAGE;

            lstSUN = m.GetJEUnmatcheSunData();
            grdSUNData.DataSource = lstSUN;
        }

        private void JEMatch()
        {

            mgrMatch m = new mgrMatch();
            
            try
            {
                BindingList<ClsImageJe> lstDocs = new BindingList<ClsImageJe>(grdScannedDocument.GetCheckedList<ClsImageJe>());
                BindingList<ClsSunJe> lstSun = new BindingList<ClsSunJe>(grdSUNData.GetCheckedList<ClsSunJe>());

                clsJEManualMatch mm = m.JEManualMatch(lstDocs, lstSun);

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

        private void AddMatch(clsJEManualMatch mm)
        {
            try
            {
                lstIMAGE.Remove(mm.objIMAGE_JE);
                lstSUN.Remove(mm.objSUN_JE);

                if (lstCOMMIT == null)
                    lstCOMMIT = new BindingList<clsJEManualMatch>();

                lstCOMMIT.Add(mm);

                RefreshGrids();

            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }
        }

        private void Remove(clsJEManualMatch mm)
        {
            try
            {
                lstCOMMIT.Remove(mm);
                lstIMAGE.Add(mm.objIMAGE_JE);
                lstSUN.Add(mm.objSUN_JE);

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

                if (m.CommitJE(lstCOMMIT))
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
                lstCOMMIT = new BindingList<clsJEManualMatch>();
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

        private void frmViewUnmatchedJE_Load(object sender, EventArgs e)
        {
            LoadDataSources();
        }

        private void grdScannedDocument_LinkClicked(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (e.Column.DataMember == "FILE_NM")
            {
                ClsImageJe JE = (ClsImageJe)grdScannedDocument.CurrentRow.DataRow;
                ViewFile(JE.Folder_Nm, JE.File_Nm);
            }
        }

        private void grdCommit_LinkClicked(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (e.Column.DataMember == "objIMAGE_JE.FILE_NM")
            {
                clsJEManualMatch JE = (clsJEManualMatch)grdCommit.CurrentRow.DataRow;
                ViewFile(JE.objIMAGE_JE.Folder_Nm, JE.objIMAGE_JE.File_Nm);
            }
        }

        private void grdCommit_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (e.Column.Key == "UNLINK")
            {
                clsJEManualMatch mm = (clsJEManualMatch)grdCommit.CurrentRow.DataRow;
                Remove(mm);
            }
        }

        #endregion

    }
}
