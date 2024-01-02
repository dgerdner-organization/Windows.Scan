using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Scan.Win
{
    public partial class frmResults : Form
    {
        private int locX = 12;
        private int locY = 12;

        public frmResults()
        {
            InitializeComponent();
        }

        public void ShowMatch(int sunData, int scannedDocuments, int matched, int unmatched)
        {
            grpImportFile.Visible = grpMatch.Visible = false;
            grpMatch.Visible = true;
            grpMatch.Left = locX;
            grpMatch.Top = locY;
            matchSunData.Text = sunData.ToString();
            matchScannedDocuments.Text = scannedDocuments.ToString(); 
            matchMatched.Text = matched.ToString();
            //matchUnmatched.Text = unmatched.ToString();
            matchUnmatched.Visible = false;
            this.Refresh();
            this.ShowDialog();
        }

        public void ShowImportSunFile(int RecordsProcessed, int Success, int Failed)
        {
            grpMatch.Visible = grpImportDocuments.Visible = false;
            grpImportFile.Visible = true;
            grpImportFile.Left = locX;
            grpImportFile.Top = locY;
            fileRecordsProcessed.Text = RecordsProcessed.ToString();
            fileSuccess.Text = Success.ToString();
            fileFailed.Text = Failed.ToString();

            lblFileErrorMsg.Visible = (Failed > 0);

            this.Refresh();
            this.ShowDialog();
        }

        public void ShowImportImages(int DocumentsProcessed, int Success, int Failed)
        {
            grpMatch.Visible = grpImportFile.Visible = false;
            grpImportDocuments.Visible = true;
            grpImportDocuments.Left = locX;
            grpImportDocuments.Top = locY;
            documentsDocumentsProcessed.Text = DocumentsProcessed.ToString();
            documentsSuccess.Text = Success.ToString();
            documentsFailed.Text = Failed.ToString();
            this.Refresh();
            this.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}
