namespace Scan.Win
{
    partial class frmViewUnmatchedJE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewUnmatchedJE));
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
            this.grdScannedDocument.Size = new System.Drawing.Size(749, 175);
            this.grdScannedDocument.LinkClicked += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdScannedDocument_LinkClicked);
            // 
            // grdSUNData
            // 
            grdSUNData_DesignTimeLayout.LayoutString = resources.GetString("grdSUNData_DesignTimeLayout.LayoutString");
            this.grdSUNData.DesignTimeLayout = grdSUNData_DesignTimeLayout;
            this.grdSUNData.Size = new System.Drawing.Size(819, 175);
            // 
            // grdCommit
            // 
            grdCommit_DesignTimeLayout.LayoutString = resources.GetString("grdCommit_DesignTimeLayout.LayoutString");
            this.grdCommit.DesignTimeLayout = grdCommit_DesignTimeLayout;
            this.grdCommit.Size = new System.Drawing.Size(819, 88);
            this.grdCommit.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdCommit_ColumnButtonClick);
            this.grdCommit.LinkClicked += new Janus.Windows.GridEX.ColumnActionEventHandler(this.grdCommit_LinkClicked);
            // 
            // frmViewUnmatchedJE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 638);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmViewUnmatchedJE";
            this.Text = "View Unmatched JE";
            this.Load += new System.EventHandler(this.frmViewUnmatchedJE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdScannedDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSUNData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCommit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}