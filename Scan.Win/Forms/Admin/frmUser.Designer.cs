namespace Scan.Win
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            Janus.Windows.GridEX.GridEXLayout cmbOffice_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbSecurityGroup_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbActive_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.txtDomainName = new CS2010.CommonWinCtrls.ucTextBox();
            this.cmbOffice = new Scan.Win.ucOfficeCombo();
            this.cmbSecurityGroup = new Scan.Win.ucSecurityGroupCombo();
            this.cmbActive = new CS2010.CommonWinCtrls.ucGenericCombo();
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).BeginInit();
            this.gbData.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOffice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSecurityGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbActive)).BeginInit();
            this.SuspendLayout();
            // 
            // grdResults
            // 
            grdResults_DesignTimeLayout.LayoutString = resources.GetString("grdResults_DesignTimeLayout.LayoutString");
            this.grdResults.DesignTimeLayout = grdResults_DesignTimeLayout;
            this.grdResults.Size = new System.Drawing.Size(615, 309);
            // 
            // gbData
            // 
            this.gbData.Location = new System.Drawing.Point(2, 317);
            this.gbData.Size = new System.Drawing.Size(621, 183);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbActive);
            this.panel1.Controls.Add(this.cmbOffice);
            this.panel1.Controls.Add(this.cmbSecurityGroup);
            this.panel1.Controls.Add(this.txtDomainName);
            this.panel1.Size = new System.Drawing.Size(615, 139);
            // 
            // txtDomainName
            // 
            this.txtDomainName.Enabled = false;
            this.txtDomainName.LabelText = "User Name:";
            this.txtDomainName.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtDomainName.LinkDisabledMessage = "Link Disabled";
            this.txtDomainName.Location = new System.Drawing.Point(104, 21);
            this.txtDomainName.Name = "txtDomainName";
            this.txtDomainName.Size = new System.Drawing.Size(225, 20);
            this.txtDomainName.TabIndex = 6;
            // 
            // cmbOffice
            // 
            this.cmbOffice.CodeColumn = "OFFICE_CD";
            this.cmbOffice.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbOffice.DescriptionColumn = "OFFICE_DSC";
            cmbOffice_DesignTimeLayout.LayoutString = resources.GetString("cmbOffice_DesignTimeLayout.LayoutString");
            this.cmbOffice.DesignTimeLayout = cmbOffice_DesignTimeLayout;
            this.cmbOffice.DisplayMember = "OFFICE_CDOFFICE_DSC";
            this.cmbOffice.DisplayType = CS2010.CommonWinCtrls.ComboDisplay.CodePlusDescription;
            this.cmbOffice.LabelText = "Office";
            this.cmbOffice.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.cmbOffice.Location = new System.Drawing.Point(104, 72);
            this.cmbOffice.Name = "cmbOffice";
            this.cmbOffice.SelectedIndex = -1;
            this.cmbOffice.SelectedItem = null;
            this.cmbOffice.Size = new System.Drawing.Size(225, 20);
            this.cmbOffice.TabIndex = 9;
            this.cmbOffice.ValueColumn = "OFFICE_CD";
            this.cmbOffice.ValueMember = "OFFICE_CD";
            // 
            // cmbSecurityGroup
            // 
            this.cmbSecurityGroup.CodeColumn = "SECURITY_GROUP_ID";
            this.cmbSecurityGroup.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbSecurityGroup.DescriptionColumn = "SECURITY_GROUP_DSC";
            cmbSecurityGroup_DesignTimeLayout.LayoutString = resources.GetString("cmbSecurityGroup_DesignTimeLayout.LayoutString");
            this.cmbSecurityGroup.DesignTimeLayout = cmbSecurityGroup_DesignTimeLayout;
            this.cmbSecurityGroup.DisplayMember = "SECURITY_GROUP_DSC";
            this.cmbSecurityGroup.DisplayType = CS2010.CommonWinCtrls.ComboDisplay.DescriptionOnly;
            this.cmbSecurityGroup.LabelText = "Security Group";
            this.cmbSecurityGroup.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.cmbSecurityGroup.Location = new System.Drawing.Point(104, 46);
            this.cmbSecurityGroup.Name = "cmbSecurityGroup";
            this.cmbSecurityGroup.SelectedIndex = -1;
            this.cmbSecurityGroup.SelectedItem = null;
            this.cmbSecurityGroup.Size = new System.Drawing.Size(225, 20);
            this.cmbSecurityGroup.TabIndex = 7;
            this.cmbSecurityGroup.ValueColumn = "SECURITY_GROUP_ID";
            this.cmbSecurityGroup.ValueMember = "SECURITY_GROUP_ID";
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
            this.cmbActive.Location = new System.Drawing.Point(104, 98);
            this.cmbActive.Name = "cmbActive";
            this.cmbActive.SelectedIndex = -1;
            this.cmbActive.SelectedItem = null;
            this.cmbActive.Size = new System.Drawing.Size(100, 20);
            this.cmbActive.TabIndex = 10;
            this.cmbActive.ValueColumn = "Code";
            this.cmbActive.ValueMember = "Code";
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BUTTON_DELETE_VISIBLE = false;
            this.ClientSize = new System.Drawing.Size(621, 501);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUser";
            this.Text = "User";
            this.WINDOW_TITLE = "User";
            ((System.ComponentModel.ISupportInitialize)(this.grdResults)).EndInit();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOffice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSecurityGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CS2010.CommonWinCtrls.ucTextBox txtDomainName;
        private ucSecurityGroupCombo cmbSecurityGroup;
        private ucOfficeCombo cmbOffice;
        private CS2010.CommonWinCtrls.ucGenericCombo cmbActive;

    }
}