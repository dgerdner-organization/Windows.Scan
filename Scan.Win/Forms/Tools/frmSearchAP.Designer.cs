namespace Scan.Win
{
    partial class frmSearchAP
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
            this.components = new System.ComponentModel.Container();
            Janus.Windows.GridEX.GridEXLayout grdResults_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdVendor_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchAP));
            Janus.Windows.GridEX.GridEXLayout cmbSunDatabase_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbVendor_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.txtCheckNo = new CS2010.CommonWinCtrls.ucTextBox();
            this.gbCheckDate = new CS2010.CommonWinCtrls.ucDateGroupBox();
            this.gbInvoiceDate = new CS2010.CommonWinCtrls.ucDateGroupBox();
            this.txtReferenceNo = new CS2010.CommonWinCtrls.ucTextBox();
            this.chxExcludeSun4 = new CS2010.CommonWinCtrls.ucCheckBox();
            this.popupVendor = new Infragistics.Win.Misc.UltraPopupControlContainer(this.components);
            this.grdVendor = new CS2010.CommonWinCtrls.ucGridEx();
            this.txtVendor = new CS2010.CommonWinCtrls.ucTextBox();
            this.cmbSunDatabase = new Scan.Win.ucSunDatabaseCombo();
            this.cmbVendor = new Scan.Win.ucAPVendorCombo();
            this.gbSearch.SuspendLayout();
            this.gbResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSunDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVendor)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.grdVendor);
            this.gbSearch.Controls.Add(this.txtVendor);
            this.gbSearch.Controls.Add(this.chxExcludeSun4);
            this.gbSearch.Controls.Add(this.txtReferenceNo);
            this.gbSearch.Controls.Add(this.gbInvoiceDate);
            this.gbSearch.Controls.Add(this.gbCheckDate);
            this.gbSearch.Controls.Add(this.txtCheckNo);
            this.gbSearch.Controls.Add(this.cmbSunDatabase);
            this.gbSearch.Controls.Add(this.cmbVendor);
            this.gbSearch.Size = new System.Drawing.Size(903, 124);
            // 
            // gbResults
            // 
            this.gbResults.Location = new System.Drawing.Point(0, 158);
            this.gbResults.Size = new System.Drawing.Size(903, 478);
            // 
            // grdResults
            // 
            grdResults_DesignTimeLayout.LayoutString = resources.GetString("grdResults_DesignTimeLayout.LayoutString");
            this.grdResults.DesignTimeLayout = grdResults_DesignTimeLayout;
            this.grdResults.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grdResults.Hierarchical = true;
            this.grdResults.Size = new System.Drawing.Size(897, 459);
            this.grdResults.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            // 
            // txtCheckNo
            // 
            this.txtCheckNo.LabelText = "Check #";
            this.txtCheckNo.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtCheckNo.LinkDisabledMessage = "Link Disabled";
            this.txtCheckNo.Location = new System.Drawing.Point(99, 100);
            this.txtCheckNo.Name = "txtCheckNo";
            this.txtCheckNo.Size = new System.Drawing.Size(100, 21);
            this.txtCheckNo.TabIndex = 5;
            // 
            // gbCheckDate
            // 
            this.gbCheckDate.CheckBoxText = "Check Date";
            this.gbCheckDate.Location = new System.Drawing.Point(366, 18);
            this.gbCheckDate.Name = "gbCheckDate";
            this.gbCheckDate.Size = new System.Drawing.Size(129, 76);
            this.gbCheckDate.TabIndex = 7;
            // 
            // gbInvoiceDate
            // 
            this.gbInvoiceDate.CheckBoxText = "Invoice Date";
            this.gbInvoiceDate.Location = new System.Drawing.Point(231, 18);
            this.gbInvoiceDate.Name = "gbInvoiceDate";
            this.gbInvoiceDate.Size = new System.Drawing.Size(129, 76);
            this.gbInvoiceDate.TabIndex = 6;
            // 
            // txtReferenceNo
            // 
            this.txtReferenceNo.LabelText = "Reference";
            this.txtReferenceNo.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtReferenceNo.LinkDisabledMessage = "Link Disabled";
            this.txtReferenceNo.Location = new System.Drawing.Point(99, 75);
            this.txtReferenceNo.Name = "txtReferenceNo";
            this.txtReferenceNo.Size = new System.Drawing.Size(100, 21);
            this.txtReferenceNo.TabIndex = 4;
            // 
            // chxExcludeSun4
            // 
            this.chxExcludeSun4.Checked = true;
            this.chxExcludeSun4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxExcludeSun4.Location = new System.Drawing.Point(513, 17);
            this.chxExcludeSun4.Name = "chxExcludeSun4";
            this.chxExcludeSun4.Size = new System.Drawing.Size(111, 30);
            this.chxExcludeSun4.TabIndex = 15;
            this.chxExcludeSun4.Text = "Exclude Sun 4";
            this.chxExcludeSun4.UseVisualStyleBackColor = true;
            this.chxExcludeSun4.YN = "Y";
            // 
            // popupVendor
            // 
            this.popupVendor.PopupControl = this.grdVendor;
            this.popupVendor.PreferredDropDownSize = new System.Drawing.Size(420, 320);
            // 
            // grdVendor
            // 
            this.grdVendor.CellToolTipText = "Use the filters to search for a vendor ... Double Click to select ...";
            grdVendor_DesignTimeLayout.LayoutString = resources.GetString("grdVendor_DesignTimeLayout.LayoutString");
            this.grdVendor.DesignTimeLayout = grdVendor_DesignTimeLayout;
            this.grdVendor.ExportFileID = null;
            this.grdVendor.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.grdVendor.GroupByBoxVisible = false;
            this.grdVendor.Location = new System.Drawing.Point(508, 53);
            this.grdVendor.Name = "grdVendor";
            this.grdVendor.OriginalNewPosition = Janus.Windows.GridEX.NewRowPosition.Default;
            this.grdVendor.Size = new System.Drawing.Size(400, 300);
            this.grdVendor.TabIndex = 204;
            this.grdVendor.Visible = false;
            this.grdVendor.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.grdVendor_RowDoubleClick);
            // 
            // txtVendor
            // 
            this.txtVendor.LabelText = "Vendor";
            this.txtVendor.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtVendor.LinkDisabledMessage = "Link Disabled";
            this.txtVendor.Location = new System.Drawing.Point(99, 21);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Size = new System.Drawing.Size(100, 21);
            this.txtVendor.TabIndex = 2;
            this.txtVendor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtVendor_MouseClick);
            this.txtVendor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVendor_KeyDown);
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
            this.cmbSunDatabase.Location = new System.Drawing.Point(99, 48);
            this.cmbSunDatabase.Name = "cmbSunDatabase";
            this.cmbSunDatabase.SelectedIndex = -1;
            this.cmbSunDatabase.SelectedItem = null;
            this.cmbSunDatabase.Size = new System.Drawing.Size(100, 21);
            this.cmbSunDatabase.TabIndex = 3;
            this.cmbSunDatabase.ValueColumn = "sun_database_cd";
            this.cmbSunDatabase.ValueMember = "sun_database_cd";
            // 
            // cmbVendor
            // 
            this.cmbVendor.CodeColumn = "vendor_account_cd";
            this.cmbVendor.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbVendor.DataMember = "vendor_account_cd";
            this.cmbVendor.DescriptionColumn = "vendor_account_nm";
            cmbVendor_DesignTimeLayout.LayoutString = resources.GetString("cmbVendor_DesignTimeLayout.LayoutString");
            this.cmbVendor.DesignTimeLayout = cmbVendor_DesignTimeLayout;
            this.cmbVendor.DisplayMember = "vendor_account_cd";
            this.cmbVendor.LabelText = "Vendor";
            this.cmbVendor.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.cmbVendor.Location = new System.Drawing.Point(260, 97);
            this.cmbVendor.Name = "cmbVendor";
            this.cmbVendor.SelectedIndex = -1;
            this.cmbVendor.SelectedItem = null;
            this.cmbVendor.Size = new System.Drawing.Size(100, 21);
            this.cmbVendor.TabIndex = 200;
            this.cmbVendor.TabStop = false;
            this.cmbVendor.ValueColumn = "vendor_account_cd";
            this.cmbVendor.ValueMember = "vendor_account_cd";
            this.cmbVendor.Visible = false;
            // 
            // frmSearchAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BUTTON_CLEAR_VISIBLE = true;
            this.BUTTON_SEARCH_VISIBLE = true;
            this.ClientSize = new System.Drawing.Size(905, 639);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearchAP";
            this.Text = " Search Accounts Payable";
            this.WINDOW_TITLE = " Search Accounts Payable";
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSunDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVendor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucAPVendorCombo cmbVendor;
        private CS2010.CommonWinCtrls.ucDateGroupBox gbInvoiceDate;
        private CS2010.CommonWinCtrls.ucDateGroupBox gbCheckDate;
        private CS2010.CommonWinCtrls.ucTextBox txtCheckNo;
        private ucSunDatabaseCombo cmbSunDatabase;
        private CS2010.CommonWinCtrls.ucTextBox txtReferenceNo;
        private CS2010.CommonWinCtrls.ucCheckBox chxExcludeSun4;
        private Infragistics.Win.Misc.UltraPopupControlContainer popupVendor;
        private CS2010.CommonWinCtrls.ucTextBox txtVendor;
        private CS2010.CommonWinCtrls.ucGridEx grdVendor;
    }
}