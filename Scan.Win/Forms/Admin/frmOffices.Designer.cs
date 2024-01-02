namespace Scan.Win
{
    partial class frmOffices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOffices));
            Janus.Windows.GridEX.GridEXLayout cmbActive_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.txtOfficeDesc = new CS2010.CommonWinCtrls.ucTextBox();
            this.txtOfficeCode = new CS2010.CommonWinCtrls.ucTextBox();
            this.cmbActive = new CS2010.CommonWinCtrls.ucGenericCombo();
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).BeginInit();
            this.gbData.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbActive)).BeginInit();
            this.SuspendLayout();
            // 
            // grdResults
            // 
            grdResults_DesignTimeLayout.LayoutString = resources.GetString("grdResults_DesignTimeLayout.LayoutString");
            this.grdResults.DesignTimeLayout = grdResults_DesignTimeLayout;
            this.grdResults.Size = new System.Drawing.Size(729, 256);
            // 
            // gbData
            // 
            this.gbData.Location = new System.Drawing.Point(2, 264);
            this.gbData.Size = new System.Drawing.Size(729, 158);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbActive);
            this.panel1.Controls.Add(this.txtOfficeDesc);
            this.panel1.Controls.Add(this.txtOfficeCode);
            this.panel1.Size = new System.Drawing.Size(723, 114);
            // 
            // txtOfficeDesc
            // 
            this.txtOfficeDesc.LabelText = "Description";
            this.txtOfficeDesc.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtOfficeDesc.LinkDisabledMessage = "Link Disabled";
            this.txtOfficeDesc.Location = new System.Drawing.Point(83, 46);
            this.txtOfficeDesc.Name = "txtOfficeDesc";
            this.txtOfficeDesc.Size = new System.Drawing.Size(243, 20);
            this.txtOfficeDesc.TabIndex = 4;
            // 
            // txtOfficeCode
            // 
            this.txtOfficeCode.Enabled = false;
            this.txtOfficeCode.LabelText = "Code";
            this.txtOfficeCode.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtOfficeCode.LinkDisabledMessage = "Link Disabled";
            this.txtOfficeCode.Location = new System.Drawing.Point(83, 20);
            this.txtOfficeCode.Name = "txtOfficeCode";
            this.txtOfficeCode.Size = new System.Drawing.Size(100, 20);
            this.txtOfficeCode.TabIndex = 3;
            // 
            // cmbActive
            // 
            this.cmbActive.CodeColumn = "Code";
            this.cmbActive.ComboType = CS2010.CommonWinCtrls.GenericComboType.YesNo;
            this.cmbActive.DescriptionColumn = "Description";
            cmbActive_DesignTimeLayout.LayoutString = resources.GetString("cmbActive_DesignTimeLayout.LayoutString");
            this.cmbActive.DesignTimeLayout = cmbActive_DesignTimeLayout;
            this.cmbActive.DisplayMember = "Code";
            this.cmbActive.LabelText = "Active (?)";
            this.cmbActive.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.cmbActive.Location = new System.Drawing.Point(83, 72);
            this.cmbActive.Name = "cmbActive";
            this.cmbActive.SelectedIndex = -1;
            this.cmbActive.SelectedItem = null;
            this.cmbActive.Size = new System.Drawing.Size(100, 20);
            this.cmbActive.TabIndex = 6;
            this.cmbActive.ValueColumn = "Code";
            this.cmbActive.ValueMember = "Code";
            // 
            // frmOffices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BUTTON_DELETE_VISIBLE = false;
            this.ClientSize = new System.Drawing.Size(736, 424);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOffices";
            this.Text = "Offices";
            this.WINDOW_TITLE = "Offices";
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).EndInit();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CS2010.CommonWinCtrls.ucTextBox txtOfficeDesc;
        private CS2010.CommonWinCtrls.ucTextBox txtOfficeCode;
        private CS2010.CommonWinCtrls.ucGenericCombo cmbActive;
    }
}