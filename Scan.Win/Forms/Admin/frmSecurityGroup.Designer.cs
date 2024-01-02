namespace Scan.Win
{
    partial class frmSecurityGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecurityGroup));
            this.txtSecurityGroupDsc = new CS2010.CommonWinCtrls.ucTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).BeginInit();
            this.gbData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdResults
            // 
            grdResults_DesignTimeLayout.LayoutString = resources.GetString("grdResults_DesignTimeLayout.LayoutString");
            this.grdResults.DesignTimeLayout = grdResults_DesignTimeLayout;
            this.grdResults.Size = new System.Drawing.Size(729, 308);
            // 
            // gbData
            // 
            this.gbData.Location = new System.Drawing.Point(2, 316);
            this.gbData.Size = new System.Drawing.Size(732, 105);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSecurityGroupDsc);
            this.panel1.Size = new System.Drawing.Size(726, 61);
            // 
            // txtSecurityGroupDsc
            // 
            this.txtSecurityGroupDsc.LabelText = "Security Group ";
            this.txtSecurityGroupDsc.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtSecurityGroupDsc.LinkDisabledMessage = "Link Disabled";
            this.txtSecurityGroupDsc.Location = new System.Drawing.Point(109, 20);
            this.txtSecurityGroupDsc.Name = "txtSecurityGroupDsc";
            this.txtSecurityGroupDsc.Size = new System.Drawing.Size(246, 20);
            this.txtSecurityGroupDsc.TabIndex = 8;
            // 
            // frmSecurityGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BUTTON_DELETE_VISIBLE = false;
            this.ClientSize = new System.Drawing.Size(736, 424);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSecurityGroup";
            this.Text = "Security Group";
            this.WINDOW_TITLE = "Security Group";
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).EndInit();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CS2010.CommonWinCtrls.ucTextBox txtSecurityGroupDsc;
    }
}