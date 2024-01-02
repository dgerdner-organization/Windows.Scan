namespace Scan.Win
{
    partial class frmSecurityConfiguration
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
            Janus.Windows.GridEX.GridEXLayout grdSecurity_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSecurityConfiguration));
            Janus.Windows.GridEX.GridEXLayout cmbSecurityFeature_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout cmbSecurityGroup_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.grdSecurity = new CS2010.CommonWinCtrls.ucGridEx();
            this.bntAdd = new CS2010.CommonWinCtrls.ucButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSecurityFeature = new Scan.Win.ucSecurityFeatureCombo();
            this.cmbSecurityGroup = new Scan.Win.ucSecurityGroupCombo();
            ((System.ComponentModel.ISupportInitialize)(this.grdSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSecurityFeature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSecurityGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSecurity
            // 
            this.grdSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            grdSecurity_DesignTimeLayout.LayoutString = resources.GetString("grdSecurity_DesignTimeLayout.LayoutString");
            this.grdSecurity.DesignTimeLayout = grdSecurity_DesignTimeLayout;
            this.grdSecurity.ExportFileID = null;
            this.grdSecurity.Location = new System.Drawing.Point(12, 66);
            this.grdSecurity.Name = "grdSecurity";
            this.grdSecurity.OriginalNewPosition = Janus.Windows.GridEX.NewRowPosition.Default;
            this.grdSecurity.Size = new System.Drawing.Size(473, 320);
            this.grdSecurity.TabIndex = 2;
            this.grdSecurity.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.ucGridEx1_ColumnButtonClick);
            // 
            // bntAdd
            // 
            this.bntAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bntAdd.Location = new System.Drawing.Point(323, 400);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 3;
            this.bntAdd.Text = "Add";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOTE:  We take the optimistic approach to security.  Items listed in the grid are" +
                " DENIED features.";
            // 
            // cmbSecurityFeature
            // 
            this.cmbSecurityFeature.CodeColumn = "security_feature_cd";
            this.cmbSecurityFeature.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbSecurityFeature.DescriptionColumn = "security_dsc";
            cmbSecurityFeature_DesignTimeLayout.LayoutString = resources.GetString("cmbSecurityFeature_DesignTimeLayout.LayoutString");
            this.cmbSecurityFeature.DesignTimeLayout = cmbSecurityFeature_DesignTimeLayout;
            this.cmbSecurityFeature.DisplayMember = "security_dsc";
            this.cmbSecurityFeature.DisplayType = CS2010.CommonWinCtrls.ComboDisplay.DescriptionOnly;
            this.cmbSecurityFeature.LabelText = "Security Feature";
            this.cmbSecurityFeature.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.cmbSecurityFeature.Location = new System.Drawing.Point(112, 12);
            this.cmbSecurityFeature.Name = "cmbSecurityFeature";
            this.cmbSecurityFeature.SelectedIndex = -1;
            this.cmbSecurityFeature.SelectedItem = null;
            this.cmbSecurityFeature.Size = new System.Drawing.Size(200, 20);
            this.cmbSecurityFeature.TabIndex = 5;
            this.cmbSecurityFeature.UseCompatibleTextRendering = true;
            this.cmbSecurityFeature.ValueColumn = "security_feature_cd";
            this.cmbSecurityFeature.ValueMember = "security_feature_cd";
            this.cmbSecurityFeature.ValueChanged += new System.EventHandler(this.cmbSecurityFeature_ValueChanged);
            // 
            // cmbSecurityGroup
            // 
            this.cmbSecurityGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbSecurityGroup.CodeColumn = "SECURITY_GROUP_ID";
            this.cmbSecurityGroup.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList;
            this.cmbSecurityGroup.DescriptionColumn = "SECURITY_GROUP_DSC";
            cmbSecurityGroup_DesignTimeLayout.LayoutString = resources.GetString("cmbSecurityGroup_DesignTimeLayout.LayoutString");
            this.cmbSecurityGroup.DesignTimeLayout = cmbSecurityGroup_DesignTimeLayout;
            this.cmbSecurityGroup.DisplayMember = "SECURITY_GROUP_DSC";
            this.cmbSecurityGroup.DisplayType = CS2010.CommonWinCtrls.ComboDisplay.DescriptionOnly;
            this.cmbSecurityGroup.LabelText = "Security Group";
            this.cmbSecurityGroup.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.cmbSecurityGroup.Location = new System.Drawing.Point(112, 402);
            this.cmbSecurityGroup.Name = "cmbSecurityGroup";
            this.cmbSecurityGroup.SelectedIndex = -1;
            this.cmbSecurityGroup.SelectedItem = null;
            this.cmbSecurityGroup.Size = new System.Drawing.Size(200, 20);
            this.cmbSecurityGroup.TabIndex = 1;
            this.cmbSecurityGroup.ValueColumn = "SECURITY_GROUP_ID";
            this.cmbSecurityGroup.ValueMember = "SECURITY_GROUP_ID";
            // 
            // frmSecurityConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 438);
            this.Controls.Add(this.cmbSecurityFeature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.grdSecurity);
            this.Controls.Add(this.cmbSecurityGroup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSecurityConfiguration";
            this.Text = " Security Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.grdSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSecurityFeature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSecurityGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucSecurityGroupCombo cmbSecurityGroup;
        private CS2010.CommonWinCtrls.ucGridEx grdSecurity;
        private CS2010.CommonWinCtrls.ucButton bntAdd;
        private System.Windows.Forms.Label label1;
        private ucSecurityFeatureCombo cmbSecurityFeature;

    }
}