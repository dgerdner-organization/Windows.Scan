namespace Scan.Win
{
    partial class frmTest
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
            Janus.Windows.GridEX.GridEXLayout ucGridEx1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            this.ucGridEx1 = new CS2010.CommonWinCtrls.ucGridEx();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ucGridEx1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGridEx1
            // 
            ucGridEx1_DesignTimeLayout.LayoutString = resources.GetString("ucGridEx1_DesignTimeLayout.LayoutString");
            this.ucGridEx1.DesignTimeLayout = ucGridEx1_DesignTimeLayout;
            this.ucGridEx1.ExportFileID = null;
            this.ucGridEx1.Location = new System.Drawing.Point(134, 57);
            this.ucGridEx1.Name = "ucGridEx1";
            this.ucGridEx1.OriginalNewPosition = Janus.Windows.GridEX.NewRowPosition.Default;
            this.ucGridEx1.Size = new System.Drawing.Size(284, 288);
            this.ucGridEx1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ucGridEx1);
            this.Name = "frmTest";
            this.Text = "frmTest";
            ((System.ComponentModel.ISupportInitialize)(this.ucGridEx1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CS2010.CommonWinCtrls.ucGridEx ucGridEx1;
        private System.Windows.Forms.Button button1;
    }
}