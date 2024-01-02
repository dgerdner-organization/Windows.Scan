namespace Scan.Win
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTools = new System.Windows.Forms.ToolStripMenuItem();
            this.accountsPayableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImportAndMatchAP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewUnmatchedAP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSearchAP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiJE = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImportAndMatchJE = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewUnmatchedJE = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSearchJE = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSecurity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSecurityGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSecurityFeature = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSecurityConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOffices = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOceanCarriers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDatabaseCodes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiConversion = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTest = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.tsmiTools,
            this.tsmiAdmin,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(635, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(35, 20);
            this.fileMenu.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // tsmiTools
            // 
            this.tsmiTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsPayableToolStripMenuItem,
            this.tsmiJE});
            this.tsmiTools.Name = "tsmiTools";
            this.tsmiTools.Size = new System.Drawing.Size(123, 20);
            this.tsmiTools.Text = "&Document Operations";
            // 
            // accountsPayableToolStripMenuItem
            // 
            this.accountsPayableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiImportAndMatchAP,
            this.tsmiViewUnmatchedAP,
            this.toolStripMenuItem2,
            this.tsmiSearchAP});
            this.accountsPayableToolStripMenuItem.Name = "accountsPayableToolStripMenuItem";
            this.accountsPayableToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.accountsPayableToolStripMenuItem.Text = "Accounts Payable";
            // 
            // tsmiImportAndMatchAP
            // 
            this.tsmiImportAndMatchAP.Name = "tsmiImportAndMatchAP";
            this.tsmiImportAndMatchAP.Size = new System.Drawing.Size(170, 22);
            this.tsmiImportAndMatchAP.Text = "Import and Match";
            this.tsmiImportAndMatchAP.Click += new System.EventHandler(this.tsmiImportAndMatchAP_Click);
            // 
            // tsmiViewUnmatchedAP
            // 
            this.tsmiViewUnmatchedAP.Name = "tsmiViewUnmatchedAP";
            this.tsmiViewUnmatchedAP.Size = new System.Drawing.Size(170, 22);
            this.tsmiViewUnmatchedAP.Text = "View Unmatched";
            this.tsmiViewUnmatchedAP.Click += new System.EventHandler(this.tsmiViewUnmatchedAP_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(167, 6);
            // 
            // tsmiSearchAP
            // 
            this.tsmiSearchAP.Name = "tsmiSearchAP";
            this.tsmiSearchAP.Size = new System.Drawing.Size(170, 22);
            this.tsmiSearchAP.Text = "Search";
            this.tsmiSearchAP.Click += new System.EventHandler(this.tsmiSearchAP_Click);
            // 
            // tsmiJE
            // 
            this.tsmiJE.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiImportAndMatchJE,
            this.tsmiViewUnmatchedJE,
            this.toolStripMenuItem3,
            this.tsmiSearchJE});
            this.tsmiJE.Name = "tsmiJE";
            this.tsmiJE.Size = new System.Drawing.Size(170, 22);
            this.tsmiJE.Text = "Journal Entries";
            // 
            // tsmiImportAndMatchJE
            // 
            this.tsmiImportAndMatchJE.Name = "tsmiImportAndMatchJE";
            this.tsmiImportAndMatchJE.Size = new System.Drawing.Size(170, 22);
            this.tsmiImportAndMatchJE.Text = "Import and Match";
            this.tsmiImportAndMatchJE.Click += new System.EventHandler(this.tsmiImportAndMatchJE_Click);
            // 
            // tsmiViewUnmatchedJE
            // 
            this.tsmiViewUnmatchedJE.Name = "tsmiViewUnmatchedJE";
            this.tsmiViewUnmatchedJE.Size = new System.Drawing.Size(170, 22);
            this.tsmiViewUnmatchedJE.Text = "View Unmatched";
            this.tsmiViewUnmatchedJE.Click += new System.EventHandler(this.tsmiViewUnmatchedJE_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(167, 6);
            // 
            // tsmiSearchJE
            // 
            this.tsmiSearchJE.Name = "tsmiSearchJE";
            this.tsmiSearchJE.Size = new System.Drawing.Size(170, 22);
            this.tsmiSearchJE.Text = "Search";
            this.tsmiSearchJE.Click += new System.EventHandler(this.tsmiSearchJE_Click);
            // 
            // tsmiAdmin
            // 
            this.tsmiAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSecurity,
            this.tsmiOffices,
            this.tsmiOceanCarriers,
            this.tsmiDatabaseCodes,
            this.toolStripMenuItem4,
            this.tsmiConversion});
            this.tsmiAdmin.Name = "tsmiAdmin";
            this.tsmiAdmin.Size = new System.Drawing.Size(48, 20);
            this.tsmiAdmin.Text = "&Admin";
            // 
            // tsmiSecurity
            // 
            this.tsmiSecurity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUsers,
            this.tsmiSecurityGroup,
            this.tsmiSecurityFeature,
            this.toolStripMenuItem1,
            this.tsmiSecurityConfiguration});
            this.tsmiSecurity.Name = "tsmiSecurity";
            this.tsmiSecurity.Size = new System.Drawing.Size(162, 22);
            this.tsmiSecurity.Text = "&Security";
            // 
            // tsmiUsers
            // 
            this.tsmiUsers.Name = "tsmiUsers";
            this.tsmiUsers.Size = new System.Drawing.Size(192, 22);
            this.tsmiUsers.Text = "&Users";
            this.tsmiUsers.Click += new System.EventHandler(this.tsmiUsers_Click);
            // 
            // tsmiSecurityGroup
            // 
            this.tsmiSecurityGroup.Name = "tsmiSecurityGroup";
            this.tsmiSecurityGroup.Size = new System.Drawing.Size(192, 22);
            this.tsmiSecurityGroup.Text = "Security &Group";
            this.tsmiSecurityGroup.Click += new System.EventHandler(this.tsmiSecurityGroup_Click);
            // 
            // tsmiSecurityFeature
            // 
            this.tsmiSecurityFeature.Name = "tsmiSecurityFeature";
            this.tsmiSecurityFeature.Size = new System.Drawing.Size(192, 22);
            this.tsmiSecurityFeature.Text = "Security &Feature";
            this.tsmiSecurityFeature.Click += new System.EventHandler(this.tsmiSecurityFeature_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(189, 6);
            // 
            // tsmiSecurityConfiguration
            // 
            this.tsmiSecurityConfiguration.Name = "tsmiSecurityConfiguration";
            this.tsmiSecurityConfiguration.Size = new System.Drawing.Size(192, 22);
            this.tsmiSecurityConfiguration.Text = "Security &Configuration";
            this.tsmiSecurityConfiguration.Click += new System.EventHandler(this.tsmiSecurityConfiguration_Click);
            // 
            // tsmiOffices
            // 
            this.tsmiOffices.Name = "tsmiOffices";
            this.tsmiOffices.Size = new System.Drawing.Size(162, 22);
            this.tsmiOffices.Text = "&Offices";
            this.tsmiOffices.Click += new System.EventHandler(this.tsmiOffices_Click);
            // 
            // tsmiOceanCarriers
            // 
            this.tsmiOceanCarriers.Name = "tsmiOceanCarriers";
            this.tsmiOceanCarriers.Size = new System.Drawing.Size(162, 22);
            this.tsmiOceanCarriers.Text = "Ocean &Carriers";
            this.tsmiOceanCarriers.Click += new System.EventHandler(this.tsmiOceanCarriers_Click);
            // 
            // tsmiDatabaseCodes
            // 
            this.tsmiDatabaseCodes.Name = "tsmiDatabaseCodes";
            this.tsmiDatabaseCodes.Size = new System.Drawing.Size(162, 22);
            this.tsmiDatabaseCodes.Text = "&Datatase Codes";
            this.tsmiDatabaseCodes.Click += new System.EventHandler(this.tsmiDatabaseCodes_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(159, 6);
            // 
            // tsmiConversion
            // 
            this.tsmiConversion.Enabled = false;
            this.tsmiConversion.Name = "tsmiConversion";
            this.tsmiConversion.Size = new System.Drawing.Size(162, 22);
            this.tsmiConversion.Text = "Conversion";
            this.tsmiConversion.Click += new System.EventHandler(this.tsmiConversion_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(62, 20);
            this.windowsMenu.Text = "&Windows";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.tsmiTest});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(40, 20);
            this.helpMenu.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // tsmiTest
            // 
            this.tsmiTest.Name = "tsmiTest";
            this.tsmiTest.Size = new System.Drawing.Size(144, 22);
            this.tsmiTest.Text = "Test";
            this.tsmiTest.Click += new System.EventHandler(this.tsmiTest_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.tsslStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(635, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(582, 17);
            this.tsslStatus.Spring = true;
            this.tsslStatus.Text = "...";
            this.tsslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tsmiTools;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdmin;
        private System.Windows.Forms.ToolStripMenuItem tsmiSecurity;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmiSecurityGroup;
        private System.Windows.Forms.ToolStripMenuItem tsmiSecurityFeature;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSecurityConfiguration;
        private System.Windows.Forms.ToolStripMenuItem tsmiOffices;
        private System.Windows.Forms.ToolStripMenuItem tsmiOceanCarriers;
        private System.Windows.Forms.ToolStripMenuItem tsmiDatabaseCodes;
        private System.Windows.Forms.ToolStripMenuItem accountsPayableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiImportAndMatchAP;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewUnmatchedAP;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchAP;
        private System.Windows.Forms.ToolStripMenuItem tsmiJE;
        private System.Windows.Forms.ToolStripMenuItem tsmiImportAndMatchJE;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewUnmatchedJE;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearchJE;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmiConversion;
        private System.Windows.Forms.ToolStripMenuItem tsmiTest;
    }
}



