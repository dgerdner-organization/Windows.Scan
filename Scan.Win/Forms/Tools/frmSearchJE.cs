using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CS2010.CommonWinCtrls;
using CS2010.Common;
using Scan.Business;
using CS2010.SCAN.Business;

namespace Scan.Win
{
    public partial class frmSearchJE : frmSearch
    {
        private sql_JE JE = new sql_JE();

        public frmSearchJE()
        {
            InitializeComponent();

            SQL_BASE = JE;

            this.WindowState = FormWindowState.Maximized;
        }

        #region Overrides

        protected override bool SearchData()
        {

            try
            {
                // NOTE: this is where I would assemble any search parameters and I would create an over-loaded 'Run' method in the derived SQL_BASE class

                JESearchArguments je = new JESearchArguments();

                je.SunDatabaseCd = cmbSunDatabase.Text;
                je.JournalNo = txtJournalNumber.Text;
                je.JournalSource = txtJournalSource.Text;
                je.JournalType = txtJournalType.Text;
                je.AccountingPeriod = txtAccountingPeriod.Text;

                if (gbEntryDate.CheckBoxChecked)
                {
                    gbEntryDate.Validate();
                    je.EntryDateFrom = gbEntryDate.FromDate;
                    je.EntryDateTo = gbEntryDate.ToDate;
                }

                je.ExcludeSun4 = chxExcludeSun4.Checked;

                JE.RunIt(je);

                return base.SearchData();
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
                return false;
            }


        }

        protected override bool ClearData()
        {            
            try
            {
                cmbSunDatabase.Clear();
                txtJournalNumber.Text = 
                    txtJournalSource.Text = 
                    txtJournalType.Text = 
                    txtAccountingPeriod.Text = string.Empty;

                gbEntryDate.Clear();

                chxExcludeSun4.Checked = true;

                return base.ClearData();
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
                return false;
            }

        }

        protected override void LinkClicked(DataRow dr, string Key)
        {
            try
            {
                if (dr.IsNotNull())
                {
                    ViewFile(dr["FOLDER_NM"].ToString(), dr["FILE_NM"].ToString());
                }

                base.LinkClicked(dr, Key);
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }

        }

        protected override void ButtonClicked(DataRow dr, string Key)
        {
            try
            {

                ClsSunJe sje;
                ClsImageJe ije;
                frmEditJE EditJE = new frmEditJE(); ;

                if (Key == "EDIT")
                {
                    sje = new ClsSunJe(dr);
                    ije = ClsImageJe.GetUsingKey(dr["IMAGE_JE_ID"].ToLong());

                    EditJE.ShowForm(sje, ije);
                }

                ReRunSearch();

                base.ButtonClicked(dr, Key);

            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Program.ShowError(ex);
            }

            base.ButtonClicked(dr, Key);
        }

        #endregion

    }
}
