namespace Scan.Win
{
    partial class frmSearchJE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Janus.Windows.GridEX.GridEXLayout grdResults_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbSunDatabase_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchJE));
            this.gbEntryDate = new CS2010.CommonWinCtrls.ucDateGroupBox();
            this.cmbSunDatabase = new Scan.Win.ucSunDatabaseCombo();
            this.txtJournalNumber = new CS2010.CommonWinCtrls.ucTextBox();
            this.txtJournalSource = new CS2010.CommonWinCtrls.ucTextBox();
            this.txtAccountingPeriod = new CS2010.CommonWinCtrls.ucTextBox();
            this.txtJournalType = new CS2010.CommonWinCtrls.ucTextBox();
            this.chxExcludeSun4 = new CS2010.CommonWinCtrls.ucCheckBox();
            this.gbSearch.SuspendLayout();
            this.gbResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSunDatabase)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.chxExcludeSun4);
            this.gbSearch.Controls.Add(this.txtJournalType);
            this.gbSearch.Controls.Add(this.txtAccountingPeriod);
            this.gbSearch.Controls.Add(this.txtJournalSource);
            this.gbSearch.Controls.Add(this.txtJournalNumber);
            this.gbSearch.Controls.Add(this.gbEntryDate);
            this.gbSearch.Controls.Add(this.cmbSunDatabase);
            this.gbSearch.Size = new System.Drawing.Size(773, 135);
            // 
            // gbResults
            // 
            this.gbResults.Size = new System.Drawing.Size(773, 306);
            // 
            // grdResults
            // 
            grdResults_DesignTimeLayout.LayoutString = resources.GetString("grdResults_DesignTimeLayout.LayoutString");
            this.grdResults.DesignTimeLayout = grdResults_DesignTimeLayout;
            this.grdResults.Size = new System.Drawing.Size(767, 287);
            // 
            // gbEntryDate
            // 
            this.gbEntryDate.CheckBoxText = "Entry Date";
            this.gbEntryDate.Location = new System.Drawing.Point(269, 46);
            this.gbEntryDate.Name = "gbEntryDate";
            this.gbEntryDate.Size = new System.Drawing.Size(129, 76);
            this.gbEntryDate.TabIndex = 9;
            // 
            // cmbSunDatabase
            // 
            this.cmbSunDatabase.CodeColumn = "sun_database_cd";
            this.cmbSunDatabase.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbSunDatabase.DescriptionColumn = "sun_database_dsc";
            cmbSunDatabase_DesignTimeLayout.LayoutString = resources.GetString("cmbSunDatabase_DesignTimeLayout.LayoutString");
            this.cmbSunDatabase.DesignTimeLayout = cmbSunDatabase_DesignTimeLayout;
            this.cmbSunDatabase.DisplayMember = "sun_database_cd";
            this.cmbSunDatabase.LabelText = "Database Code";
            this.cmbSunDatabase.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.cmbSunDatabase.Location = new System.Drawing.Point(298, 20);
            this.cmbSunDatabase.Name = "cmbSunDatabase";
            this.cmbSunDatabase.SelectedIndex = -1;
            this.cmbSunDatabase.SelectedItem = null;
            this.cmbSunDatabase.Size = new System.Drawing.Size(100, 21);
            this.cmbSunDatabase.TabIndex = 8;
            this.cmbSunDatabase.ValueColumn = "sun_database_cd";
            this.cmbSunDatabase.ValueMember = "sun_database_cd";
            // 
            // txtJournalNumber
            // 
            this.txtJournalNumber.LabelText = "Journal #";
            this.txtJournalNumber.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtJournalNumber.LinkDisabledMessage = "Link Disabled";
            this.txtJournalNumber.Location = new System.Drawing.Point(103, 20);
            this.txtJournalNumber.Name = "txtJournalNumber";
            this.txtJournalNumber.Size = new System.Drawing.Size(100, 21);
            this.txtJournalNumber.TabIndex = 10;
            // 
            // txtJournalSource
            // 
            this.txtJournalSource.LabelText = "Journal Source";
            this.txtJournalSource.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtJournalSource.LinkDisabledMessage = "Link Disabled";
            this.txtJournalSource.Location = new System.Drawing.Point(103, 47);
            this.txtJournalSource.Name = "txtJournalSource";
            this.txtJournalSource.Size = new System.Drawing.Size(100, 21);
            this.txtJournalSource.TabIndex = 11;
            // 
            // txtAccountingPeriod
            // 
            this.txtAccountingPeriod.LabelText = "Accounting Period";
            this.txtAccountingPeriod.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtAccountingPeriod.LinkDisabledMessage = "Link Disabled";
            this.txtAccountingPeriod.Location = new System.Drawing.Point(103, 101);
            this.txtAccountingPeriod.Name = "txtAccountingPeriod";
            this.txtAccountingPeriod.Size = new System.Drawing.Size(100, 21);
            this.txtAccountingPeriod.TabIndex = 12;
            // 
            // txtJournalType
            // 
            this.txtJournalType.LabelText = "Journal Type";
            this.txtJournalType.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtJournalType.LinkDisabledMessage = "Link Disabled";
            this.txtJournalType.Location = new System.Drawing.Point(103, 74);
            this.txtJournalType.Name = "txtJournalType";
            this.txtJournalType.Size = new System.Drawing.Size(100, 21);
            this.txtJournalType.TabIndex = 13;
            // 
            // chxExcludeSun4
            // 
            this.chxExcludeSun4.Checked = true;
            this.chxExcludeSun4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxExcludeSun4.Location = new System.Drawing.Point(439, 15);
            this.chxExcludeSun4.Name = "chxExcludeSun4";
            this.chxExcludeSun4.Size = new System.Drawing.Size(111, 30);
            this.chxExcludeSun4.TabIndex = 14;
            this.chxExcludeSun4.Text = "Exclude Sun 4";
            this.chxExcludeSun4.UseVisualStyleBackColor = true;
            this.chxExcludeSun4.YN = "Y";
            // 
            // frmSearchJE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BUTTON_CLEAR_VISIBLE = true;
            this.BUTTON_SEARCH_VISIBLE = true;
            this.ClientSize = new System.Drawing.Size(773, 478);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearchJE";
            this.Text = " Search Journal Entries";
            this.WINDOW_TITLE = " Search Journal Entries";
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSunDatabase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CS2010.CommonWinCtrls.ucDateGroupBox gbEntryDate;
        private ucSunDatabaseCombo cmbSunDatabase;
        private CS2010.CommonWinCtrls.ucTextBox txtJournalType;
        private CS2010.CommonWinCtrls.ucTextBox txtAccountingPeriod;
        private CS2010.CommonWinCtrls.ucTextBox txtJournalSource;
        private CS2010.CommonWinCtrls.ucTextBox txtJournalNumber;
        private CS2010.CommonWinCtrls.ucCheckBox chxExcludeSun4;
    }
}