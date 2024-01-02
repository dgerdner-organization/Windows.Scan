namespace Scan.Win
{
    partial class frmSunDatabases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSunDatabases));
            Janus.Windows.GridEX.GridEXLayout cmbActive_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.txtSunDatabaseDsc = new CS2010.CommonWinCtrls.ucTextBox();
            this.txtSunDatabaseCode = new CS2010.CommonWinCtrls.ucTextBox();
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
            this.grdResults.Size = new System.Drawing.Size(766, 289);
            // 
            // gbData
            // 
            this.gbData.Location = new System.Drawing.Point(2, 297);
            this.gbData.Size = new System.Drawing.Size(772, 163);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbActive);
            this.panel1.Controls.Add(this.txtSunDatabaseDsc);
            this.panel1.Controls.Add(this.txtSunDatabaseCode);
            this.panel1.Size = new System.Drawing.Size(766, 119);
            // 
            // txtSunDatabaseDsc
            // 
            this.txtSunDatabaseDsc.LabelText = "Description";
            this.txtSunDatabaseDsc.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtSunDatabaseDsc.LinkDisabledMessage = "Link Disabled";
            this.txtSunDatabaseDsc.Location = new System.Drawing.Point(85, 53);
            this.txtSunDatabaseDsc.Name = "txtSunDatabaseDsc";
            this.txtSunDatabaseDsc.Size = new System.Drawing.Size(243, 20);
            this.txtSunDatabaseDsc.TabIndex = 7;
            // 
            // txtSunDatabaseCode
            // 
            this.txtSunDatabaseCode.Enabled = false;
            this.txtSunDatabaseCode.LabelText = "Code";
            this.txtSunDatabaseCode.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtSunDatabaseCode.LinkDisabledMessage = "Link Disabled";
            this.txtSunDatabaseCode.Location = new System.Drawing.Point(85, 27);
            this.txtSunDatabaseCode.Name = "txtSunDatabaseCode";
            this.txtSunDatabaseCode.Size = new System.Drawing.Size(100, 20);
            this.txtSunDatabaseCode.TabIndex = 6;
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
            this.cmbActive.Location = new System.Drawing.Point(85, 79);
            this.cmbActive.Name = "cmbActive";
            this.cmbActive.SelectedIndex = -1;
            this.cmbActive.SelectedItem = null;
            this.cmbActive.Size = new System.Drawing.Size(100, 20);
            this.cmbActive.TabIndex = 8;
            this.cmbActive.ValueColumn = "Code";
            this.cmbActive.ValueMember = "Code";
            // 
            // frmSunDatabases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BUTTON_DELETE_VISIBLE = false;
            this.ClientSize = new System.Drawing.Size(772, 459);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSunDatabases";
            this.Text = "Database Codes";
            this.WINDOW_TITLE = "Database Codes";
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).EndInit();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CS2010.CommonWinCtrls.ucTextBox txtSunDatabaseDsc;
        private CS2010.CommonWinCtrls.ucTextBox txtSunDatabaseCode;
        private CS2010.CommonWinCtrls.ucGenericCombo cmbActive;
    }
}