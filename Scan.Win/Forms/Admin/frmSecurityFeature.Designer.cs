namespace Scan.Win
{
    partial class frmSecurityFeature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecurityFeature));
            this.txtSecurityFeatureCD = new CS2010.CommonWinCtrls.ucTextBox();
            this.txtSecurityFeatureDsc = new CS2010.CommonWinCtrls.ucTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).BeginInit();
            this.gbData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdResults
            // 
            grdResults_DesignTimeLayout.LayoutString = resources.GetString("grdResults_DesignTimeLayout.LayoutString");
            this.grdResults.DesignTimeLayout = grdResults_DesignTimeLayout;
            this.grdResults.Size = new System.Drawing.Size(729, 282);
            // 
            // gbData
            // 
            this.gbData.Location = new System.Drawing.Point(2, 290);
            this.gbData.Size = new System.Drawing.Size(732, 133);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSecurityFeatureDsc);
            this.panel1.Controls.Add(this.txtSecurityFeatureCD);
            this.panel1.Size = new System.Drawing.Size(726, 89);
            // 
            // txtSecurityFeatureCD
            // 
            this.txtSecurityFeatureCD.Enabled = false;
            this.txtSecurityFeatureCD.LabelText = "Feature Code";
            this.txtSecurityFeatureCD.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtSecurityFeatureCD.LinkDisabledMessage = "Link Disabled";
            this.txtSecurityFeatureCD.Location = new System.Drawing.Point(97, 24);
            this.txtSecurityFeatureCD.Name = "txtSecurityFeatureCD";
            this.txtSecurityFeatureCD.Size = new System.Drawing.Size(105, 20);
            this.txtSecurityFeatureCD.TabIndex = 7;
            // 
            // txtSecurityFeatureDsc
            // 
            this.txtSecurityFeatureDsc.LabelText = "Description";
            this.txtSecurityFeatureDsc.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtSecurityFeatureDsc.LinkDisabledMessage = "Link Disabled";
            this.txtSecurityFeatureDsc.Location = new System.Drawing.Point(97, 50);
            this.txtSecurityFeatureDsc.Name = "txtSecurityFeatureDsc";
            this.txtSecurityFeatureDsc.Size = new System.Drawing.Size(225, 20);
            this.txtSecurityFeatureDsc.TabIndex = 8;
            // 
            // frmSecurityFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BUTTON_DELETE_VISIBLE = false;
            this.ClientSize = new System.Drawing.Size(736, 424);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSecurityFeature";
            this.Text = "Security Feature";
            this.WINDOW_TITLE = "Security Feature";
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).EndInit();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CS2010.CommonWinCtrls.ucTextBox txtSecurityFeatureCD;
        private CS2010.CommonWinCtrls.ucTextBox txtSecurityFeatureDsc;
    }
}