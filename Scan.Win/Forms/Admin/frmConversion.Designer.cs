namespace Scan.Win
{
    partial class frmConversion
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
            this.btnConvertAP = new System.Windows.Forms.Button();
            this.btnConvertJE = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubFolderConvertJE = new System.Windows.Forms.Button();
            this.btnSubFolderConvertAP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAPCleanup = new System.Windows.Forms.Button();
            this.btnJECleanup = new System.Windows.Forms.Button();
            this.txtJD_IND = new CS2010.CommonWinCtrls.ucTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConvertAP
            // 
            this.btnConvertAP.Location = new System.Drawing.Point(454, 48);
            this.btnConvertAP.Name = "btnConvertAP";
            this.btnConvertAP.Size = new System.Drawing.Size(160, 23);
            this.btnConvertAP.TabIndex = 0;
            this.btnConvertAP.Text = "Convert AP";
            this.btnConvertAP.UseVisualStyleBackColor = true;
            this.btnConvertAP.Click += new System.EventHandler(this.btnConvertAP_Click);
            // 
            // btnConvertJE
            // 
            this.btnConvertJE.Location = new System.Drawing.Point(454, 77);
            this.btnConvertJE.Name = "btnConvertJE";
            this.btnConvertJE.Size = new System.Drawing.Size(160, 23);
            this.btnConvertJE.TabIndex = 1;
            this.btnConvertJE.Text = "Convert JE";
            this.btnConvertJE.UseVisualStyleBackColor = true;
            this.btnConvertJE.Click += new System.EventHandler(this.btnConvertJE_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMsg.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(0, 0);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(631, 30);
            this.lblMsg.TabIndex = 2;
            this.lblMsg.Text = "Status: ...";
            this.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSubFolderConvertJE);
            this.groupBox1.Controls.Add(this.btnSubFolderConvertAP);
            this.groupBox1.Location = new System.Drawing.Point(12, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sub Folder - Conversion";
            // 
            // btnSubFolderConvertJE
            // 
            this.btnSubFolderConvertJE.Location = new System.Drawing.Point(400, 48);
            this.btnSubFolderConvertJE.Name = "btnSubFolderConvertJE";
            this.btnSubFolderConvertJE.Size = new System.Drawing.Size(183, 23);
            this.btnSubFolderConvertJE.TabIndex = 1;
            this.btnSubFolderConvertJE.Text = "Sub Folder Convert JE";
            this.btnSubFolderConvertJE.UseVisualStyleBackColor = true;
            this.btnSubFolderConvertJE.Click += new System.EventHandler(this.btnSubFolderConvertJE_Click);
            // 
            // btnSubFolderConvertAP
            // 
            this.btnSubFolderConvertAP.Location = new System.Drawing.Point(400, 19);
            this.btnSubFolderConvertAP.Name = "btnSubFolderConvertAP";
            this.btnSubFolderConvertAP.Size = new System.Drawing.Size(183, 23);
            this.btnSubFolderConvertAP.TabIndex = 0;
            this.btnSubFolderConvertAP.Text = "Sub Folder Convert AP";
            this.btnSubFolderConvertAP.UseVisualStyleBackColor = true;
            this.btnSubFolderConvertAP.Click += new System.EventHandler(this.btnSubFolderConvertAP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnJECleanup);
            this.groupBox2.Controls.Add(this.btnAPCleanup);
            this.groupBox2.Location = new System.Drawing.Point(12, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sub Folder - Conversion (Clean-up)";
            // 
            // btnAPCleanup
            // 
            this.btnAPCleanup.Location = new System.Drawing.Point(400, 20);
            this.btnAPCleanup.Name = "btnAPCleanup";
            this.btnAPCleanup.Size = new System.Drawing.Size(150, 23);
            this.btnAPCleanup.TabIndex = 0;
            this.btnAPCleanup.Text = "AP Clean up";
            this.btnAPCleanup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAPCleanup.UseVisualStyleBackColor = true;
            this.btnAPCleanup.Click += new System.EventHandler(this.btnAPCleanup_Click);
            // 
            // btnJECleanup
            // 
            this.btnJECleanup.Location = new System.Drawing.Point(400, 49);
            this.btnJECleanup.Name = "btnJECleanup";
            this.btnJECleanup.Size = new System.Drawing.Size(150, 23);
            this.btnJECleanup.TabIndex = 1;
            this.btnJECleanup.Text = "JE Clean Up";
            this.btnJECleanup.UseVisualStyleBackColor = true;
            this.btnJECleanup.Click += new System.EventHandler(this.btnJECleanup_Click);
            // 
            // txtJD_IND
            // 
            this.txtJD_IND.LabelText = "JD IND";
            this.txtJD_IND.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.txtJD_IND.LinkDisabledMessage = "Link Disabled";
            this.txtJD_IND.Location = new System.Drawing.Point(73, 61);
            this.txtJD_IND.Name = "txtJD_IND";
            this.txtJD_IND.Size = new System.Drawing.Size(100, 20);
            this.txtJD_IND.TabIndex = 3;
            // 
            // frmConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 360);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtJD_IND);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnConvertJE);
            this.Controls.Add(this.btnConvertAP);
            this.Name = "frmConversion";
            this.Text = "Conversion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertAP;
        private System.Windows.Forms.Button btnConvertJE;
        private System.Windows.Forms.Label lblMsg;
        private CS2010.CommonWinCtrls.ucTextBox txtJD_IND;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubFolderConvertJE;
        private System.Windows.Forms.Button btnSubFolderConvertAP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnJECleanup;
        private System.Windows.Forms.Button btnAPCleanup;
    }
}