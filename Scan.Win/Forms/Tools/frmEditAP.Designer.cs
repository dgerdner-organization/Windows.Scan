namespace Scan.Win
{
    partial class frmEditAP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditAP));
            Janus.Windows.GridEX.GridEXLayout cmbSunOfficeCd_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbImageSunDatabaseCd_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbImageOfficeCd_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.gbSunData = new System.Windows.Forms.GroupBox();
            this.txtSunCheckNo = new CS2010.CommonWinCtrls.ucTextBox();
            this.txtSunCheckDt = new CS2010.CommonWinCtrls.ucDateTextBox();
            this.txtSunInvoiceDt = new CS2010.CommonWinCtrls.ucDateTextBox();
            this.txtSunEntryUser = new CS2010.CommonWinCtrls.ucTextBox();
            this.txtSunInvoiceAmount = new CS2010.CommonWinCtrls.ucTextBox();
            this.txtSunVendorAccountNm = new CS2010.CommonWinCtrls.ucTextBox();
            this.txtSunVendorAccountCd = new CS2010.CommonWinCtrls.ucTextBox();
            this.txtSunReferenceNo = new CS2010.CommonWinCtrls.ucTextBox();
            this.txtSunJournalEntry = new CS2010.CommonWinCtrls.ucTextBox();
            this.cmbSunDatabaseCd = new Scan.Win.ucSunDatabaseCombo();
            this.cmbSunOfficeCd = new Scan.Win.ucOfficeCombo();
            this.btnSaveSunData = new CS2010.CommonWinCtrls.ucButton();
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.linkImage = new CS2010.CommonWinCtrls.ucLinkLabel();
            this.txtImageInvoiceAmt = new CS2010.CommonWinCtrls.ucTextBox();
            this.txtImageCheckNo = new CS2010.CommonWinCtrls.ucTextBox();
            this.cmbImageSunDatabaseCd = new Scan.Win.ucSunDatabaseCombo();
            this.cmbImageOfficeCd = new Scan.Win.ucOfficeCombo();
            this.btnSaveImage = new CS2010.CommonWinCtrls.ucButton();
            this.btnUnlink = new CS2010.CommonWinCtrls.ucButton();
            this.gbSunData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSunDatabaseCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSunOfficeCd)).BeginInit();
            this.gbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImageSunDatabaseCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImageOfficeCd)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSunData
            // 
            this.gbSunData.Controls.Add(this.txtSunCheckNo);
            this.gbSunData.Controls.Add(this.txtSunCheckDt);
            this.gbSunData.Controls.Add(this.txtSunInvoiceDt);
            this.gbSunData.Controls.Add(this.txtSunEntryUser);
            this.gbSunData.Controls.Add(this.txtSunInvoiceAmount);
            this.gbSunData.Controls.Add(this.txtSunVendorAccountNm);
            this.gbSunData.Controls.Add(this.txtSunVendorAccountCd);
            this.gbSunData.Controls.Add(this.txtSunReferenceNo);
            this.gbSunData.Controls.Add(this.txtSunJournalEntry);
            this.gbSunData.Controls.Add(this.cmbSunDatabaseCd);
            this.gbSunData.Controls.Add(this.cmbSunOfficeCd);
            this.gbSunData.Controls.Add(this.btnSaveSunData);
            this.gbSunData.Location = new System.Drawing.Point(12, 12);
            this.gbSunData.Name = "gbSunData";
            this.gbSunData.Size = new System.Drawing.Size(535, 219);
            this.gbSunData.TabIndex = 0;
            this.gbSunData.TabStop = false;
            this.gbSunData.Text = "SUN Data";
            // 
            // txtSunCheckNo
            // 
            this.txtSunCheckNo.LabelText = "Check #";
            this.txtSunCheckNo.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtSunCheckNo.LinkDisabledMessage = "Link Disabled";
            this.txtSunCheckNo.Location = new System.Drawing.Point(333, 132);
            this.txtSunCheckNo.Name = "txtSunCheckNo";
            this.txtSunCheckNo.Size = new System.Drawing.Size(100, 20);
            this.txtSunCheckNo.TabIndex = 14;
            // 
            // txtSunCheckDt
            // 
            this.txtSunCheckDt.LabelText = "Check Date";
            this.txtSunCheckDt.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtSunCheckDt.LinkDisabledMessage = "Link Disabled";
            this.txtSunCheckDt.Location = new System.Drawing.Point(333, 106);
            this.txtSunCheckDt.MaxLength = 10;
            this.txtSunCheckDt.Name = "txtSunCheckDt";
            this.txtSunCheckDt.Size = new System.Drawing.Size(100, 20);
            this.txtSunCheckDt.TabIndex = 13;
            this.txtSunCheckDt.Value = null;
            // 
            // txtSunInvoiceDt
            // 
            this.txtSunInvoiceDt.LabelText = "Invoice Date";
            this.txtSunInvoiceDt.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtSunInvoiceDt.LinkDisabledMessage = "Link Disabled";
            this.txtSunInvoiceDt.Location = new System.Drawing.Point(333, 80);
            this.txtSunInvoiceDt.MaxLength = 10;
            this.txtSunInvoiceDt.Name = "txtSunInvoiceDt";
            this.txtSunInvoiceDt.Size = new System.Drawing.Size(100, 20);
            this.txtSunInvoiceDt.TabIndex = 12;
            this.txtSunInvoiceDt.Value = null;
            // 
            // txtSunEntryUser
            // 
            this.txtSunEntryUser.LabelText = "Entry User";
            this.txtSunEntryUser.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtSunEntryUser.LinkDisabledMessage = "Link Disabled";
            this.txtSunEntryUser.Location = new System.Drawing.Point(333, 54);
            this.txtSunEntryUser.Name = "txtSunEntryUser";
            this.txtSunEntryUser.Size = new System.Drawing.Size(100, 20);
            this.txtSunEntryUser.TabIndex = 11;
            // 
            // txtSunInvoiceAmount
            // 
            this.txtSunInvoiceAmount.LabelText = "Invoice Amount";
            this.txtSunInvoiceAmount.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtSunInvoiceAmount.LinkDisabledMessage = "Link Disabled";
            this.txtSunInvoiceAmount.Location = new System.Drawing.Point(333, 28);
            this.txtSunInvoiceAmount.Name = "txtSunInvoiceAmount";
            this.txtSunInvoiceAmount.Size = new System.Drawing.Size(100, 20);
            this.txtSunInvoiceAmount.TabIndex = 10;
            // 
            // txtSunVendorAccountNm
            // 
            this.txtSunVendorAccountNm.LabelText = "Vendor Name";
            this.txtSunVendorAccountNm.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtSunVendorAccountNm.LinkDisabledMessage = "Link Disabled";
            this.txtSunVendorAccountNm.Location = new System.Drawing.Point(91, 158);
            this.txtSunVendorAccountNm.Name = "txtSunVendorAccountNm";
            this.txtSunVendorAccountNm.Size = new System.Drawing.Size(100, 20);
            this.txtSunVendorAccountNm.TabIndex = 9;
            // 
            // txtSunVendorAccountCd
            // 
            this.txtSunVendorAccountCd.LabelText = "Vendor Code";
            this.txtSunVendorAccountCd.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtSunVendorAccountCd.LinkDisabledMessage = "Link Disabled";
            this.txtSunVendorAccountCd.Location = new System.Drawing.Point(91, 132);
            this.txtSunVendorAccountCd.Name = "txtSunVendorAccountCd";
            this.txtSunVendorAccountCd.Size = new System.Drawing.Size(100, 20);
            this.txtSunVendorAccountCd.TabIndex = 8;
            // 
            // txtSunReferenceNo
            // 
            this.txtSunReferenceNo.LabelText = "Reference #";
            this.txtSunReferenceNo.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtSunReferenceNo.LinkDisabledMessage = "Link Disabled";
            this.txtSunReferenceNo.Location = new System.Drawing.Point(91, 106);
            this.txtSunReferenceNo.Name = "txtSunReferenceNo";
            this.txtSunReferenceNo.Size = new System.Drawing.Size(100, 20);
            this.txtSunReferenceNo.TabIndex = 7;
            // 
            // txtSunJournalEntry
            // 
            this.txtSunJournalEntry.LabelText = "Journal Entry";
            this.txtSunJournalEntry.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtSunJournalEntry.LinkDisabledMessage = "Link Disabled";
            this.txtSunJournalEntry.Location = new System.Drawing.Point(91, 80);
            this.txtSunJournalEntry.Name = "txtSunJournalEntry";
            this.txtSunJournalEntry.Size = new System.Drawing.Size(100, 20);
            this.txtSunJournalEntry.TabIndex = 6;
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
            this.cmbSunDatabaseCd.TabIndex = 5;
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
            this.cmbSunOfficeCd.TabIndex = 4;
            this.cmbSunOfficeCd.ValueColumn = "OFFICE_CD";
            this.cmbSunOfficeCd.ValueMember = "OFFICE_CD";
            // 
            // btnSaveSunData
            // 
            this.btnSaveSunData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSunData.Location = new System.Drawing.Point(454, 190);
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
            this.gbImage.Controls.Add(this.txtImageInvoiceAmt);
            this.gbImage.Controls.Add(this.txtImageCheckNo);
            this.gbImage.Controls.Add(this.cmbImageSunDatabaseCd);
            this.gbImage.Controls.Add(this.cmbImageOfficeCd);
            this.gbImage.Controls.Add(this.btnSaveImage);
            this.gbImage.Location = new System.Drawing.Point(12, 237);
            this.gbImage.Name = "gbImage";
            this.gbImage.Size = new System.Drawing.Size(535, 134);
            this.gbImage.TabIndex = 1;
            this.gbImage.TabStop = false;
            this.gbImage.Text = "Image";
            // 
            // linkImage
            // 
            this.linkImage.AutoSize = true;
            this.linkImage.Location = new System.Drawing.Point(88, 96);
            this.linkImage.Name = "linkImage";
            this.linkImage.Size = new System.Drawing.Size(62, 13);
            this.linkImage.TabIndex = 6;
            this.linkImage.TabStop = true;
            this.linkImage.Text = "View Image";
            this.linkImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkImage_LinkClicked);
            // 
            // txtImageInvoiceAmt
            // 
            this.txtImageInvoiceAmt.LabelText = "Invoice Amount";
            this.txtImageInvoiceAmt.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtImageInvoiceAmt.LinkDisabledMessage = "Link Disabled";
            this.txtImageInvoiceAmt.Location = new System.Drawing.Point(333, 56);
            this.txtImageInvoiceAmt.Name = "txtImageInvoiceAmt";
            this.txtImageInvoiceAmt.Size = new System.Drawing.Size(100, 20);
            this.txtImageInvoiceAmt.TabIndex = 5;
            // 
            // txtImageCheckNo
            // 
            this.txtImageCheckNo.LabelText = "Check #";
            this.txtImageCheckNo.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtImageCheckNo.LinkDisabledMessage = "Link Disabled";
            this.txtImageCheckNo.Location = new System.Drawing.Point(333, 30);
            this.txtImageCheckNo.Name = "txtImageCheckNo";
            this.txtImageCheckNo.Size = new System.Drawing.Size(100, 20);
            this.txtImageCheckNo.TabIndex = 4;
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
            this.cmbImageSunDatabaseCd.Location = new System.Drawing.Point(91, 56);
            this.cmbImageSunDatabaseCd.Name = "cmbImageSunDatabaseCd";
            this.cmbImageSunDatabaseCd.SelectedIndex = -1;
            this.cmbImageSunDatabaseCd.SelectedItem = null;
            this.cmbImageSunDatabaseCd.Size = new System.Drawing.Size(100, 20);
            this.cmbImageSunDatabaseCd.TabIndex = 3;
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
            this.cmbImageOfficeCd.Location = new System.Drawing.Point(91, 30);
            this.cmbImageOfficeCd.Name = "cmbImageOfficeCd";
            this.cmbImageOfficeCd.SelectedIndex = -1;
            this.cmbImageOfficeCd.SelectedItem = null;
            this.cmbImageOfficeCd.Size = new System.Drawing.Size(100, 20);
            this.cmbImageOfficeCd.TabIndex = 2;
            this.cmbImageOfficeCd.ValueColumn = "OFFICE_CD";
            this.cmbImageOfficeCd.ValueMember = "OFFICE_CD";
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveImage.Location = new System.Drawing.Point(454, 105);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(75, 23);
            this.btnSaveImage.TabIndex = 1;
            this.btnSaveImage.Text = "Save";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnUnlink
            // 
            this.btnUnlink.Location = new System.Drawing.Point(12, 377);
            this.btnUnlink.Name = "btnUnlink";
            this.btnUnlink.Size = new System.Drawing.Size(82, 23);
            this.btnUnlink.TabIndex = 2;
            this.btnUnlink.Text = "Unlink";
            this.btnUnlink.UseVisualStyleBackColor = true;
            this.btnUnlink.Click += new System.EventHandler(this.btnUnlink_Click);
            // 
            // frmEditAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 408);
            this.Controls.Add(this.btnUnlink);
            this.Controls.Add(this.gbImage);
            this.Controls.Add(this.gbSunData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditAP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Edit Accounts Payable";
            this.gbSunData.ResumeLayout(false);
            this.gbSunData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSunDatabaseCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSunOfficeCd)).EndInit();
            this.gbImage.ResumeLayout(false);
            this.gbImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImageSunDatabaseCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbImageOfficeCd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSunData;
        private System.Windows.Forms.GroupBox gbImage;
        private CS2010.CommonWinCtrls.ucButton btnUnlink;
        private CS2010.CommonWinCtrls.ucButton btnSaveSunData;
        private CS2010.CommonWinCtrls.ucButton btnSaveImage;
        private CS2010.CommonWinCtrls.ucTextBox txtSunVendorAccountCd;
        private CS2010.CommonWinCtrls.ucTextBox txtSunReferenceNo;
        private CS2010.CommonWinCtrls.ucTextBox txtSunJournalEntry;
        private ucSunDatabaseCombo cmbSunDatabaseCd;
        private ucOfficeCombo cmbSunOfficeCd;
        private CS2010.CommonWinCtrls.ucLinkLabel linkImage;
        private CS2010.CommonWinCtrls.ucTextBox txtImageInvoiceAmt;
        private CS2010.CommonWinCtrls.ucTextBox txtImageCheckNo;
        private ucSunDatabaseCombo cmbImageSunDatabaseCd;
        private ucOfficeCombo cmbImageOfficeCd;
        private CS2010.CommonWinCtrls.ucTextBox txtSunCheckNo;
        private CS2010.CommonWinCtrls.ucDateTextBox txtSunCheckDt;
        private CS2010.CommonWinCtrls.ucDateTextBox txtSunInvoiceDt;
        private CS2010.CommonWinCtrls.ucTextBox txtSunEntryUser;
        private CS2010.CommonWinCtrls.ucTextBox txtSunInvoiceAmount;
        private CS2010.CommonWinCtrls.ucTextBox txtSunVendorAccountNm;
    }
}