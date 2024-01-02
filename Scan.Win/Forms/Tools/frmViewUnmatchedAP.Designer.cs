namespace Scan.Win
{
    partial class frmViewUnmatchedAP
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
            Janus.Windows.GridEX.GridEXLayout grdScannedDocument_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewUnmatchedAP));
            Janus.Windows.GridEX.GridEXLayout grdSUNData_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout grdCommit_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdScannedDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSUNData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCommit)).BeginInit();
            this.SuspendLayout();
            // 
            // grdScannedDocument
            // 
            grdScannedDocument_DesignTimeLayout.LayoutString = resources.GetString("grdScannedDocument_DesignTimeLayout.LayoutString");
            this.grdScannedDocument.DesignTimeLayout = grdScannedDocument_DesignTimeLayout;
            this.grdScannedDocument.FrozenColumns = 5;
            this.grdScannedDocument.Size = new System.Drawing.Size(2029, 175);
            this.grdScannedDocument.LinkClicked += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdScannedDocument_LinkClicked);
            // 
            // grdSUNData
            // 
            grdSUNData_DesignTimeLayout.LayoutString = resources.GetString("grdSUNData_DesignTimeLayout.LayoutString");
            this.grdSUNData.DesignTimeLayout = grdSUNData_DesignTimeLayout;
            this.grdSUNData.FrozenColumns = 5;
            this.grdSUNData.Size = new System.Drawing.Size(1009, 175);
            // 
            // grdCommit
            // 
            grdCommit_DesignTimeLayout.LayoutString = resources.GetString("grdCommit_DesignTimeLayout.LayoutString");
            this.grdCommit.DesignTimeLayout = grdCommit_DesignTimeLayout;
            this.grdCommit.Hierarchical = true;
            this.grdCommit.Size = new System.Drawing.Size(1009, 75);
            this.grdCommit.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdCommit_ColumnButtonClick);
            this.grdCommit.LinkClicked += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdCommit_LinkClicked);
            // 
            // frmViewUnmatchedAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 625);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmViewUnmatchedAP";
            this.Text = "View Unmatched AP";
            this.Load += new System.EventHandler(this.frmViewUnmatchedAP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdScannedDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSUNData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCommit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}