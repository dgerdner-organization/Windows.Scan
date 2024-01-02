namespace Scan.Win
{
    partial class frmBaseMatchImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseMatchImport));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnErrorsSunFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnImportSunFile = new System.Windows.Forms.Button();
            this.ucGroupBox3 = new CS2010.CommonWinCtrls.ucGroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMatch = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnErrorsScannedDocuments = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnImportScannedDocuments = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.browseFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ucGroupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ucGroupBox3, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(540, 202);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnErrorsSunFile);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnImportSunFile);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 54);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SUN File";
            // 
            // btnErrorsSunFile
            // 
            this.btnErrorsSunFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErrorsSunFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnErrorsSunFile.Location = new System.Drawing.Point(273, 21);
            this.btnErrorsSunFile.Name = "btnErrorsSunFile";
            this.btnErrorsSunFile.Size = new System.Drawing.Size(75, 23);
            this.btnErrorsSunFile.TabIndex = 2;
            this.btnErrorsSunFile.Text = "ERRORS!";
            this.btnErrorsSunFile.UseVisualStyleBackColor = true;
            this.btnErrorsSunFile.Visible = false;
            this.btnErrorsSunFile.Click += new System.EventHandler(this.btnErrorsSunFile_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "1 - Import file from SUN";
            // 
            // btnImportSunFile
            // 
            this.btnImportSunFile.Location = new System.Drawing.Point(192, 21);
            this.btnImportSunFile.Name = "btnImportSunFile";
            this.btnImportSunFile.Size = new System.Drawing.Size(75, 23);
            this.btnImportSunFile.TabIndex = 0;
            this.btnImportSunFile.Text = "Import";
            this.btnImportSunFile.UseVisualStyleBackColor = true;
            this.btnImportSunFile.Click += new System.EventHandler(this.btnImportSunFile_Click);
            // 
            // ucGroupBox3
            // 
            this.ucGroupBox3.Controls.Add(this.label4);
            this.ucGroupBox3.Controls.Add(this.btnMatch);
            this.ucGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGroupBox3.Location = new System.Drawing.Point(3, 143);
            this.ucGroupBox3.Name = "ucGroupBox3";
            this.ucGroupBox3.Size = new System.Drawing.Size(534, 54);
            this.ucGroupBox3.TabIndex = 1;
            this.ucGroupBox3.TabStop = false;
            this.ucGroupBox3.Text = "Matching";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "3 - Start Matching Process";
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(192, 23);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(75, 23);
            this.btnMatch.TabIndex = 2;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnErrorsScannedDocuments);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.btnImportScannedDocuments);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(3, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(534, 54);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Scanned Documents";
            // 
            // btnErrorsScannedDocuments
            // 
            this.btnErrorsScannedDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErrorsScannedDocuments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnErrorsScannedDocuments.Location = new System.Drawing.Point(273, 19);
            this.btnErrorsScannedDocuments.Name = "btnErrorsScannedDocuments";
            this.btnErrorsScannedDocuments.Size = new System.Drawing.Size(75, 23);
            this.btnErrorsScannedDocuments.TabIndex = 4;
            this.btnErrorsScannedDocuments.Text = "ERRORS!";
            this.btnErrorsScannedDocuments.UseVisualStyleBackColor = true;
            this.btnErrorsScannedDocuments.Visible = false;
            this.btnErrorsScannedDocuments.Click += new System.EventHandler(this.btnErrorsScannedDocuments_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "2 - Import the Scanned Documents";
            // 
            // btnImportScannedDocuments
            // 
            this.btnImportScannedDocuments.Location = new System.Drawing.Point(192, 19);
            this.btnImportScannedDocuments.Name = "btnImportScannedDocuments";
            this.btnImportScannedDocuments.Size = new System.Drawing.Size(75, 23);
            this.btnImportScannedDocuments.TabIndex = 2;
            this.btnImportScannedDocuments.Text = "Import";
            this.btnImportScannedDocuments.UseVisualStyleBackColor = true;
            this.btnImportScannedDocuments.Click += new System.EventHandler(this.btnImportScannedDocuments_Click);
            // 
            // frmBaseMatchImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 202);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaseMatchImport";
            this.Text = "frmBaseMatchImport";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ucGroupBox3.ResumeLayout(false);
            this.ucGroupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnErrorsSunFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImportSunFile;
        private CS2010.CommonWinCtrls.ucGroupBox ucGroupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnErrorsScannedDocuments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnImportScannedDocuments;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog browseFolderDialog;
    }
}