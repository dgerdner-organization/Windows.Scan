namespace Scan.Win
{
    partial class frmEditJE
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
            Janus.Windows.GridEX.GridEXLayout cmbSunDatabaseCd_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditJE));
            Janus.Windows.GridEX.GridEXLayout cmbSunOfficeCd_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbImageSunDatabaseCd_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbImageOfficeCd_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.btnUnlink = new CS2010.CommonWinCtrls.ucButton();
            this.btnSaveSunData = new CS2010.CommonWinCtrls.ucButton();
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.btnSaveImage = new CS2010.CommonWinCtrls.ucButton();
            this.gbSunData = new System.Windows.Forms.GroupBox();
            this.cmbSunDatabaseCd = new Scan.Win.ucSunDatabaseCombo();
            this.cmbSunOfficeCd = new Scan.Win.ucOfficeCombo();
            this.txtSunEntryDt = new CS2010.CommonWinCtrls.ucDateTextBox();
            this.txtSunJournalNo = new CS2010.CommonWinCtrls.ucTextBox();
            this.txtSunAccountingPeriod = new CS2010.CommonWinCtrls.ucTextBox();
            this.txtSunJournalSource = new CS2010.CommonWinCtrls.ucTextBox();
            this.txtSunJournalType = new CS2010.CommonWinCtrls.ucTextBox();
            this.cmbImageSunDatabaseCd = new Scan.Win.ucSunDatabaseCombo();
            this.cmbImageOfficeCd = new Scan.Win.ucOfficeCombo();
            this.linkImage = new CS2010.CommonWinCtrls.ucLinkLabel();
            this.txtImageJournalNo = new CS2010.CommonWinCtrls.ucTextBox();
            this.gbImage.SuspendLayout();
            this.gbSunData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSunDatabaseCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSunOfficeCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImageSunDatabaseCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImageOfficeCd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnlink
            // 
            this.btnUnlink.Location = new System.Drawing.Point(11, 288);
            this.btnUnlink.Name = "btnUnlink";
            this.btnUnlink.Size = new System.Drawing.Size(82, 23);
            this.btnUnlink.TabIndex = 5;
            this.btnUnlink.Text = "Unlink";
            this.btnUnlink.UseVisualStyleBackColor = true;
            this.btnUnlink.Click += new System.EventHandler(this.btnUnlink_Click);
            // 
            // btnSaveSunData
            // 
            this.btnSaveSunData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSunData.Location = new System.Drawing.Point(497, 113);
            this.btnSaveSunData.Name = "btnSaveSunData";
            this.btnSaveSunData.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSunData.TabIndex = 0;
            this.btnSaveSunData.Text = "Save";
            this.btnSaveSunData.UseVisualStyleBackColor = true;
            this.btnSaveSunData.Click += new System.EventHandler(this.btnSaveSunData_Click);
            // 
            // gbImage
            // 
            this.gbImage.Controls.Add(this.linkImage);
            this.gbImage.Controls.Add(this.txtImageJournalNo);
            this.gbImage.Controls.Add(this.cmbImageSunDatabaseCd);
            this.gbImage.Controls.Add(this.cmbImageOfficeCd);
            this.gbImage.Controls.Add(this.btnSaveImage);
            this.gbImage.Location = new System.Drawing.Point(11, 160);
            this.gbImage.Name = "gbImage";
            this.gbImage.Size = new System.Drawing.Size(579, 122);
            this.gbImage.TabIndex = 4;
            this.gbImage.TabStop = false;
            this.gbImage.Text = "Image";
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveImage.Location = new System.Drawing.Point(498, 93);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(75, 23);
            this.btnSaveImage.TabIndex = 1;
            this.btnSaveImage.Text = "Save";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // gbSunData
            // 
            this.gbSunData.Controls.Add(this.txtSunJournalType);
            this.gbSunData.Controls.Add(this.txtSunJournalSource);
            this.gbSunData.Controls.Add(this.txtSunAccountingPeriod);
            this.gbSunData.Controls.Add(this.txtSunJournalNo);
            this.gbSunData.Controls.Add(this.txtSunEntryDt);
            this.gbSunData.Controls.Add(this.cmbSunDatabaseCd);
            this.gbSunData.Controls.Add(this.cmbSunOfficeCd);
            this.gbSunData.Controls.Add(this.btnSaveSunData);
            this.gbSunData.Location = new System.Drawing.Point(12, 12);
            this.gbSunData.Name = "gbSunData";
            this.gbSunData.Size = new System.Drawing.Size(578, 142);
            this.gbSunData.TabIndex = 3;
            this.gbSunData.TabStop = false;
            this.gbSunData.Text = "SUN Data";
            // 
            // cmbSunDatabaseCd
            // 
            this.cmbSunDatabaseCd.CodeColumn = "SUN_DATABASE_CD";
            this.cmbSunDatabaseCd.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbSunDatabaseCd.DescriptionColumn = "SUN_DATABASE_DSC";
            cmbSunDatabaseCd_DesignTimeLayout.LayoutString = resources.GetString("cmbSunDatabaseCd_DesignTimeLayout.LayoutString");
            this.cmbSunDatabaseCd.DesignTimeLayout = cmbSunDatabaseCd_DesignTimeLayout;
            this.cmbSunDatabaseCd.DisplayMember = "SUN_DATABASE_CD";
            this.cmbSunDatabaseCd.LabelText = "Database";
            this.cmbSunDatabaseCd.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.cmbSunDatabaseCd.Location = new System.Drawing.Point(91, 54);
            this.cmbSunDatabaseCd.Name = "cmbSunDatabaseCd";
            this.cmbSunDatabaseCd.SelectedIndex = -1;
            this.cmbSunDatabaseCd.SelectedItem = null;
            this.cmbSunDatabaseCd.Size = new System.Drawing.Size(100, 20);
            this.cmbSunDatabaseCd.TabIndex = 7;
            this.cmbSunDatabaseCd.ValueColumn = "SUN_DATABASE_CD";
            this.cmbSunDatabaseCd.ValueMember = "SUN_DATABASE_CD";
            // 
            // cmbSunOfficeCd
            // 
            this.cmbSunOfficeCd.CodeColumn = "OFFICE_CD";
            this.cmbSunOfficeCd.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbSunOfficeCd.DescriptionColumn = "OFFICE_DSC";
            cmbSunOfficeCd_DesignTimeLayout.LayoutString = resources.GetString("cmbSunOfficeCd_DesignTimeLayout.LayoutString");
            this.cmbSunOfficeCd.DesignTimeLayout = cmbSunOfficeCd_DesignTimeLayout;
            this.cmbSunOfficeCd.DisplayMember = "OFFICE_CD";
            this.cmbSunOfficeCd.LabelText = "Office";
            this.cmbSunOfficeCd.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.cmbSunOfficeCd.Location = new System.Drawing.Point(91, 28);
            this.cmbSunOfficeCd.Name = "cmbSunOfficeCd";
            this.cmbSunOfficeCd.SelectedIndex = -1;
            this.cmbSunOfficeCd.SelectedItem = null;
            this.cmbSunOfficeCd.Size = new System.Drawing.Size(100, 20);
            this.cmbSunOfficeCd.TabIndex = 6;
            this.cmbSunOfficeCd.ValueColumn = "OFFICE_CD";
            this.cmbSunOfficeCd.ValueMember = "OFFICE_CD";
            // 
            // txtSunEntryDt
            // 
            this.txtSunEntryDt.LabelText = "Entry Date";
            this.txtSunEntryDt.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtSunEntryDt.LinkDisabledMessage = "Link Disabled";
            this.txtSunEntryDt.Location = new System.Drawing.Point(91, 80);
            this.txtSunEntryDt.MaxLength = 10;
            this.txtSunEntryDt.Name = "txtSunEntryDt";
            this.txtSunEntryDt.Size = new System.Drawing.Size(100, 20);
            this.txtSunEntryDt.TabIndex = 14;
            this.txtSunEntryDt.Value = null;
            // 
            // txtSunJournalNo
            // 
            this.txtSunJournalNo.LabelText = "Journal #";
            this.txtSunJournalNo.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtSunJournalNo.LinkDisabledMessage = "Link Disabled";
            this.txtSunJournalNo.Location = new System.Drawing.Point(341, 28);
            this.txtSunJournalNo.Name = "txtSunJournalNo";
            this.txtSunJournalNo.Size = new System.Drawing.Size(100, 20);
            this.txtSunJournalNo.TabIndex = 15;
            // 
            // txtSunAccountingPeriod
            // 
            this.txtSunAccountingPeriod.LabelText = "Accounting Period";
            this.txtSunAccountingPeriod.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtSunAccountingPeriod.LinkDisabledMessage = "Link Disabled";
            this.txtSunAccountingPeriod.Location = new System.Drawing.Point(341, 54);
            this.txtSunAccountingPeriod.Name = "txtSunAccountingPeriod";
            this.txtSunAccountingPeriod.Size = new System.Drawing.Size(100, 20);
            this.txtSunAccountingPeriod.TabIndex = 16;
            // 
            // txtSunJournalSource
            // 
            this.txtSunJournalSource.LabelText = "Journal Source";
            this.txtSunJournalSource.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtSunJournalSource.LinkDisabledMessage = "Link Disabled";
            this.txtSunJournalSource.Location = new System.Drawing.Point(341, 80);
            this.txtSunJournalSource.Name = "txtSunJournalSource";
            this.txtSunJournalSource.Size = new System.Drawing.Size(100, 20);
            this.txtSunJournalSource.TabIndex = 17;
            // 
            // txtSunJournalType
            // 
            this.txtSunJournalType.LabelText = "Journal Type";
            this.txtSunJournalType.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtSunJournalType.LinkDisabledMessage = "Link Disabled";
            this.txtSunJournalType.Location = new System.Drawing.Point(341, 106);
            this.txtSunJournalType.Name = "txtSunJournalType";
            this.txtSunJournalType.Size = new System.Drawing.Size(100, 20);
            this.txtSunJournalType.TabIndex = 18;
            // 
            // cmbImageSunDatabaseCd
            // 
            this.cmbImageSunDatabaseCd.CodeColumn = "SUN_DATABASE_CD";
            this.cmbImageSunDatabaseCd.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbImageSunDatabaseCd.DescriptionColumn = "SUN_DATABASE_DSC";
            cmbImageSunDatabaseCd_DesignTimeLayout.LayoutString = resources.GetString("cmbImageSunDatabaseCd_DesignTimeLayout.LayoutString");
            this.cmbImageSunDatabaseCd.DesignTimeLayout = cmbImageSunDatabaseCd_DesignTimeLayout;
            this.cmbImageSunDatabaseCd.DisplayMember = "SUN_DATABASE_CD";
            this.cmbImageSunDatabaseCd.LabelText = "Database";
            this.cmbImageSunDatabaseCd.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.cmbImageSunDatabaseCd.Location = new System.Drawing.Point(92, 45);
            this.cmbImageSunDatabaseCd.Name = "cmbImageSunDatabaseCd";
            this.cmbImageSunDatabaseCd.SelectedIndex = -1;
            this.cmbImageSunDatabaseCd.SelectedItem = null;
            this.cmbImageSunDatabaseCd.Size = new System.Drawing.Size(100, 20);
            this.cmbImageSunDatabaseCd.TabIndex = 5;
            this.cmbImageSunDatabaseCd.ValueColumn = "SUN_DATABASE_CD";
            this.cmbImageSunDatabaseCd.ValueMember = "SUN_DATABASE_CD";
            // 
            // cmbImageOfficeCd
            // 
            this.cmbImageOfficeCd.CodeColumn = "OFFICE_CD";
            this.cmbImageOfficeCd.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbImageOfficeCd.DescriptionColumn = "OFFICE_DSC";
            cmbImageOfficeCd_DesignTimeLayout.LayoutString = resources.GetString("cmbImageOfficeCd_DesignTimeLayout.LayoutString");
            this.cmbImageOfficeCd.DesignTimeLayout = cmbImageOfficeCd_DesignTimeLayout;
            this.cmbImageOfficeCd.DisplayMember = "OFFICE_CD";
            this.cmbImageOfficeCd.LabelText = "Office";
            this.cmbImageOfficeCd.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.cmbImageOfficeCd.Location = new System.Drawing.Point(92, 19);
            this.cmbImageOfficeCd.Name = "cmbImageOfficeCd";
            this.cmbImageOfficeCd.SelectedIndex = -1;
            this.cmbImageOfficeCd.SelectedItem = null;
            this.cmbImageOfficeCd.Size = new System.Drawing.Size(100, 20);
            this.cmbImageOfficeCd.TabIndex = 4;
            this.cmbImageOfficeCd.ValueColumn = "OFFICE_CD";
            this.cmbImageOfficeCd.ValueMember = "OFFICE_CD";
            // 
            // linkImage
            // 
            this.linkImage.AutoSize = true;
            this.linkImage.Location = new System.Drawing.Point(97, 85);
            this.linkImage.Name = "linkImage";
            this.linkImage.Size = new System.Drawing.Size(62, 13);
            this.linkImage.TabIndex = 8;
            this.linkImage.TabStop = true;
            this.linkImage.Text = "View Image";
            this.linkImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkImage_LinkClicked);
            // 
            // txtImageJournalNo
            // 
            this.txtImageJournalNo.LabelText = "Journal #";
            this.txtImageJournalNo.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtImageJournalNo.LinkDisabledMessage = "Link Disabled";
            this.txtImageJournalNo.Location = new System.Drawing.Point(342, 19);
            this.txtImageJournalNo.Name = "txtImageJournalNo";
            this.txtImageJournalNo.Size = new System.Drawing.Size(100, 20);
            this.txtImageJournalNo.TabIndex = 7;
            // 
            // frmEditJE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 323);
            this.Controls.Add(this.btnUnlink);
            this.Controls.Add(this.gbImage);
            this.Controls.Add(this.gbSunData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditJE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Edit Journal Entry";
            this.gbImage.ResumeLayout(false);
            this.gbImage.PerformLayout();
            this.gbSunData.ResumeLayout(false);
            this.gbSunData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSunDatabaseCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSunOfficeCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImageSunDatabaseCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImageOfficeCd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CS2010.CommonWinCtrls.ucButton btnUnlink;
        private CS2010.CommonWinCtrls.ucButton btnSaveSunData;
        private System.Windows.Forms.GroupBox gbImage;
        private CS2010.CommonWinCtrls.ucButton btnSaveImage;
        private System.Windows.Forms.GroupBox gbSunData;
        private ucSunDatabaseCombo cmbSunDatabaseCd;
        private ucOfficeCombo cmbSunOfficeCd;
        private CS2010.CommonWinCtrls.ucDateTextBox txtSunEntryDt;
        private CS2010.CommonWinCtrls.ucTextBox txtSunJournalType;
        private CS2010.CommonWinCtrls.ucTextBox txtSunJournalSource;
        private CS2010.CommonWinCtrls.ucTextBox txtSunAccountingPeriod;
        private CS2010.CommonWinCtrls.ucTextBox txtSunJournalNo;
        private ucSunDatabaseCombo cmbImageSunDatabaseCd;
        private ucOfficeCombo cmbImageOfficeCd;
        private CS2010.CommonWinCtrls.ucLinkLabel linkImage;
        private CS2010.CommonWinCtrls.ucTextBox txtImageJournalNo;
    }
}