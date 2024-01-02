namespace Scan.Win
{
    partial class frmResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResults));
            this.grpMatch = new CS2010.CommonWinCtrls.ucGroupBox();
            this.matchUnmatched = new CS2010.CommonWinCtrls.ucTextBox();
            this.matchMatched = new CS2010.CommonWinCtrls.ucTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.matchScannedDocuments = new CS2010.CommonWinCtrls.ucTextBox();
            this.matchSunData = new CS2010.CommonWinCtrls.ucTextBox();
            this.grpImportDocuments = new CS2010.CommonWinCtrls.ucGroupBox();
            this.documentsFailed = new CS2010.CommonWinCtrls.ucTextBox();
            this.documentsSuccess = new CS2010.CommonWinCtrls.ucTextBox();
            this.documentsDocumentsProcessed = new CS2010.CommonWinCtrls.ucTextBox();
            this.grpImportFile = new CS2010.CommonWinCtrls.ucGroupBox();
            this.fileFailed = new CS2010.CommonWinCtrls.ucTextBox();
            this.fileSuccess = new CS2010.CommonWinCtrls.ucTextBox();
            this.fileRecordsProcessed = new CS2010.CommonWinCtrls.ucTextBox();
            this.btnOK = new CS2010.CommonWinCtrls.ucButton();
            this.lblFileErrorMsg = new System.Windows.Forms.Label();
            this.grpMatch.SuspendLayout();
            this.grpImportDocuments.SuspendLayout();
            this.grpImportFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMatch
            // 
            this.grpMatch.Controls.Add(this.matchUnmatched);
            this.grpMatch.Controls.Add(this.matchMatched);
            this.grpMatch.Controls.Add(this.panel2);
            this.grpMatch.Controls.Add(this.matchScannedDocuments);
            this.grpMatch.Controls.Add(this.matchSunData);
            this.grpMatch.Location = new System.Drawing.Point(12, 12);
            this.grpMatch.Name = "grpMatch";
            this.grpMatch.Size = new System.Drawing.Size(270, 136);
            this.grpMatch.TabIndex = 5;
            this.grpMatch.TabStop = false;
            this.grpMatch.Text = "Matching Sun Data and Scanned Images";
            // 
            // matchUnmatched
            // 
            this.matchUnmatched.BackColor = System.Drawing.SystemColors.Control;
            this.matchUnmatched.ForeColor = System.Drawing.Color.Black;
            this.matchUnmatched.LabelText = "Unmatched";
            this.matchUnmatched.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.matchUnmatched.LinkDisabledMessage = "Link Disabled";
            this.matchUnmatched.Location = new System.Drawing.Point(133, 101);
            this.matchUnmatched.Name = "matchUnmatched";
            this.matchUnmatched.ReadOnly = true;
            this.matchUnmatched.Size = new System.Drawing.Size(100, 20);
            this.matchUnmatched.TabIndex = 4;
            this.matchUnmatched.TabStop = false;
            // 
            // matchMatched
            // 
            this.matchMatched.BackColor = System.Drawing.SystemColors.Control;
            this.matchMatched.ForeColor = System.Drawing.Color.Black;
            this.matchMatched.LabelText = "Matched";
            this.matchMatched.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.matchMatched.LinkDisabledMessage = "Link Disabled";
            this.matchMatched.Location = new System.Drawing.Point(133, 75);
            this.matchMatched.Name = "matchMatched";
            this.matchMatched.ReadOnly = true;
            this.matchMatched.Size = new System.Drawing.Size(100, 20);
            this.matchMatched.TabIndex = 3;
            this.matchMatched.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(11, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 1);
            this.panel2.TabIndex = 2;
            // 
            // matchScannedDocuments
            // 
            this.matchScannedDocuments.BackColor = System.Drawing.SystemColors.Control;
            this.matchScannedDocuments.ForeColor = System.Drawing.Color.Black;
            this.matchScannedDocuments.LabelText = "Scanned Documents";
            this.matchScannedDocuments.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.matchScannedDocuments.LinkDisabledMessage = "Link Disabled";
            this.matchScannedDocuments.Location = new System.Drawing.Point(133, 45);
            this.matchScannedDocuments.Name = "matchScannedDocuments";
            this.matchScannedDocuments.ReadOnly = true;
            this.matchScannedDocuments.Size = new System.Drawing.Size(100, 20);
            this.matchScannedDocuments.TabIndex = 1;
            this.matchScannedDocuments.TabStop = false;
            // 
            // matchSunData
            // 
            this.matchSunData.BackColor = System.Drawing.SystemColors.Control;
            this.matchSunData.ForeColor = System.Drawing.Color.Black;
            this.matchSunData.LabelText = "SUN Data";
            this.matchSunData.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.matchSunData.LinkDisabledMessage = "Link Disabled";
            this.matchSunData.Location = new System.Drawing.Point(133, 19);
            this.matchSunData.Name = "matchSunData";
            this.matchSunData.ReadOnly = true;
            this.matchSunData.Size = new System.Drawing.Size(100, 20);
            this.matchSunData.TabIndex = 0;
            this.matchSunData.TabStop = false;
            // 
            // grpImportDocuments
            // 
            this.grpImportDocuments.Controls.Add(this.documentsFailed);
            this.grpImportDocuments.Controls.Add(this.documentsSuccess);
            this.grpImportDocuments.Controls.Add(this.documentsDocumentsProcessed);
            this.grpImportDocuments.Location = new System.Drawing.Point(310, 15);
            this.grpImportDocuments.Name = "grpImportDocuments";
            this.grpImportDocuments.Size = new System.Drawing.Size(270, 136);
            this.grpImportDocuments.TabIndex = 6;
            this.grpImportDocuments.TabStop = false;
            this.grpImportDocuments.Text = "Importing Documents";
            // 
            // documentsFailed
            // 
            this.documentsFailed.BackColor = System.Drawing.SystemColors.Control;
            this.documentsFailed.ForeColor = System.Drawing.Color.Black;
            this.documentsFailed.LabelText = "Failed";
            this.documentsFailed.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.documentsFailed.LinkDisabledMessage = "Link Disabled";
            this.documentsFailed.Location = new System.Drawing.Point(133, 71);
            this.documentsFailed.Name = "documentsFailed";
            this.documentsFailed.ReadOnly = true;
            this.documentsFailed.Size = new System.Drawing.Size(100, 20);
            this.documentsFailed.TabIndex = 3;
            this.documentsFailed.TabStop = false;
            // 
            // documentsSuccess
            // 
            this.documentsSuccess.BackColor = System.Drawing.SystemColors.Control;
            this.documentsSuccess.ForeColor = System.Drawing.Color.Black;
            this.documentsSuccess.LabelText = "Success";
            this.documentsSuccess.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.documentsSuccess.LinkDisabledMessage = "Link Disabled";
            this.documentsSuccess.Location = new System.Drawing.Point(133, 45);
            this.documentsSuccess.Name = "documentsSuccess";
            this.documentsSuccess.ReadOnly = true;
            this.documentsSuccess.Size = new System.Drawing.Size(100, 20);
            this.documentsSuccess.TabIndex = 1;
            this.documentsSuccess.TabStop = false;
            // 
            // documentsDocumentsProcessed
            // 
            this.documentsDocumentsProcessed.BackColor = System.Drawing.SystemColors.Control;
            this.documentsDocumentsProcessed.ForeColor = System.Drawing.Color.Black;
            this.documentsDocumentsProcessed.LabelText = "Documents Processed";
            this.documentsDocumentsProcessed.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.documentsDocumentsProcessed.LinkDisabledMessage = "Link Disabled";
            this.documentsDocumentsProcessed.Location = new System.Drawing.Point(133, 19);
            this.documentsDocumentsProcessed.Name = "documentsDocumentsProcessed";
            this.documentsDocumentsProcessed.ReadOnly = true;
            this.documentsDocumentsProcessed.Size = new System.Drawing.Size(100, 20);
            this.documentsDocumentsProcessed.TabIndex = 0;
            this.documentsDocumentsProcessed.TabStop = false;
            // 
            // grpImportFile
            // 
            this.grpImportFile.Controls.Add(this.lblFileErrorMsg);
            this.grpImportFile.Controls.Add(this.fileFailed);
            this.grpImportFile.Controls.Add(this.fileSuccess);
            this.grpImportFile.Controls.Add(this.fileRecordsProcessed);
            this.grpImportFile.Location = new System.Drawing.Point(310, 172);
            this.grpImportFile.Name = "grpImportFile";
            this.grpImportFile.Size = new System.Drawing.Size(270, 136);
            this.grpImportFile.TabIndex = 7;
            this.grpImportFile.TabStop = false;
            this.grpImportFile.Text = "Importing Sun File";
            // 
            // fileFailed
            // 
            this.fileFailed.BackColor = System.Drawing.SystemColors.Control;
            this.fileFailed.ForeColor = System.Drawing.Color.Black;
            this.fileFailed.LabelText = "Failed";
            this.fileFailed.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.fileFailed.LinkDisabledMessage = "Link Disabled";
            this.fileFailed.Location = new System.Drawing.Point(133, 71);
            this.fileFailed.Name = "fileFailed";
            this.fileFailed.ReadOnly = true;
            this.fileFailed.Size = new System.Drawing.Size(100, 20);
            this.fileFailed.TabIndex = 3;
            this.fileFailed.TabStop = false;
            // 
            // fileSuccess
            // 
            this.fileSuccess.BackColor = System.Drawing.SystemColors.Control;
            this.fileSuccess.ForeColor = System.Drawing.Color.Black;
            this.fileSuccess.LabelText = "Success";
            this.fileSuccess.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.fileSuccess.LinkDisabledMessage = "Link Disabled";
            this.fileSuccess.Location = new System.Drawing.Point(133, 45);
            this.fileSuccess.Name = "fileSuccess";
            this.fileSuccess.ReadOnly = true;
            this.fileSuccess.Size = new System.Drawing.Size(100, 20);
            this.fileSuccess.TabIndex = 1;
            this.fileSuccess.TabStop = false;
            // 
            // fileRecordsProcessed
            // 
            this.fileRecordsProcessed.BackColor = System.Drawing.SystemColors.Control;
            this.fileRecordsProcessed.ForeColor = System.Drawing.Color.Black;
            this.fileRecordsProcessed.LabelText = "Sun Records Processed";
            this.fileRecordsProcessed.LabelType = CS2010.CommonWinCtrls.TextLabelType.Label;
            this.fileRecordsProcessed.LinkDisabledMessage = "Link Disabled";
            this.fileRecordsProcessed.Location = new System.Drawing.Point(133, 19);
            this.fileRecordsProcessed.Name = "fileRecordsProcessed";
            this.fileRecordsProcessed.ReadOnly = true;
            this.fileRecordsProcessed.Size = new System.Drawing.Size(100, 20);
            this.fileRecordsProcessed.TabIndex = 0;
            this.fileRecordsProcessed.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(209, 158);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblFileErrorMsg
            // 
            this.lblFileErrorMsg.AutoSize = true;
            this.lblFileErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.lblFileErrorMsg.Location = new System.Drawing.Point(46, 105);
            this.lblFileErrorMsg.Name = "lblFileErrorMsg";
            this.lblFileErrorMsg.Size = new System.Drawing.Size(172, 13);
            this.lblFileErrorMsg.TabIndex = 4;
            this.lblFileErrorMsg.Text = "NOTE: The file was NOT imported.";
            // 
            // frmResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 193);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grpImportFile);
            this.Controls.Add(this.grpImportDocuments);
            this.Controls.Add(this.grpMatch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Results ...";
            this.grpMatch.ResumeLayout(false);
            this.grpMatch.PerformLayout();
            this.grpImportDocuments.ResumeLayout(false);
            this.grpImportDocuments.PerformLayout();
            this.grpImportFile.ResumeLayout(false);
            this.grpImportFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CS2010.CommonWinCtrls.ucGroupBox grpMatch;
        protected CS2010.CommonWinCtrls.ucTextBox matchUnmatched;
        protected CS2010.CommonWinCtrls.ucTextBox matchMatched;
        private System.Windows.Forms.Panel panel2;
        protected CS2010.CommonWinCtrls.ucTextBox matchScannedDocuments;
        protected CS2010.CommonWinCtrls.ucTextBox matchSunData;
        private CS2010.CommonWinCtrls.ucGroupBox grpImportDocuments;
        protected CS2010.CommonWinCtrls.ucTextBox documentsFailed;
        protected CS2010.CommonWinCtrls.ucTextBox documentsSuccess;
        protected CS2010.CommonWinCtrls.ucTextBox documentsDocumentsProcessed;
        private CS2010.CommonWinCtrls.ucGroupBox grpImportFile;
        protected CS2010.CommonWinCtrls.ucTextBox fileFailed;
        protected CS2010.CommonWinCtrls.ucTextBox fileSuccess;
        protected CS2010.CommonWinCtrls.ucTextBox fileRecordsProcessed;
        private CS2010.CommonWinCtrls.ucButton btnOK;
        private System.Windows.Forms.Label lblFileErrorMsg;
    }
}