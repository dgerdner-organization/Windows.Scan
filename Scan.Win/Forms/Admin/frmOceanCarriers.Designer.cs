namespace Scan.Win
{
    partial class frmOceanCarriers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOceanCarriers));
            Janus.Windows.GridEX.GridEXLayout cmbActive_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.txtOceanCarrierCode = new CS2010.CommonWinCtrls.ucTextBox();
            this.txtOceanCarrierDesc = new CS2010.CommonWinCtrls.ucTextBox();
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
            this.grdResults.Size = new System.Drawing.Size(730, 270);
            // 
            // gbData
            // 
            this.gbData.Location = new System.Drawing.Point(2, 278);
            this.gbData.Size = new System.Drawing.Size(730, 144);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbActive);
            this.panel1.Controls.Add(this.txtOceanCarrierDesc);
            this.panel1.Controls.Add(this.txtOceanCarrierCode);
            this.panel1.Size = new System.Drawing.Size(724, 100);
            // 
            // txtOceanCarrierCode
            // 
            this.txtOceanCarrierCode.Enabled = false;
            this.txtOceanCarrierCode.LabelText = "Code";
            this.txtOceanCarrierCode.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtOceanCarrierCode.LinkDisabledMessage = "Link Disabled";
            this.txtOceanCarrierCode.Location = new System.Drawing.Point(86, 13);
            this.txtOceanCarrierCode.Name = "txtOceanCarrierCode";
            this.txtOceanCarrierCode.Size = new System.Drawing.Size(100, 20);
            this.txtOceanCarrierCode.TabIndex = 1;
            // 
            // txtOceanCarrierDesc
            // 
            this.txtOceanCarrierDesc.LabelText = "Description";
            this.txtOceanCarrierDesc.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtOceanCarrierDesc.LinkDisabledMessage = "Link Disabled";
            this.txtOceanCarrierDesc.Location = new System.Drawing.Point(86, 39);
            this.txtOceanCarrierDesc.Name = "txtOceanCarrierDesc";
            this.txtOceanCarrierDesc.Size = new System.Drawing.Size(243, 20);
            this.txtOceanCarrierDesc.TabIndex = 2;
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
            this.cmbActive.Location = new System.Drawing.Point(86, 65);
            this.cmbActive.Name = "cmbActive";
            this.cmbActive.SelectedIndex = -1;
            this.cmbActive.SelectedItem = null;
            this.cmbActive.Size = new System.Drawing.Size(100, 20);
            this.cmbActive.TabIndex = 7;
            this.cmbActive.ValueColumn = "Code";
            this.cmbActive.ValueMember = "Code";
            // 
            // frmOceanCarriers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BUTTON_DELETE_VISIBLE = false;
            this.ClientSize = new System.Drawing.Size(736, 424);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOceanCarriers";
            this.Text = "Ocean Carriers";
            this.WINDOW_TITLE = "Ocean Carriers";
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).EndInit();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CS2010.CommonWinCtrls.ucTextBox txtOceanCarrierCode;
        private CS2010.CommonWinCtrls.ucTextBox txtOceanCarrierDesc;
        private CS2010.CommonWinCtrls.ucGenericCombo cmbActive;
    }
}