using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CS2010.Common;

namespace Scan.Win
{
    public partial class frmBaseMatchImport : Form
    {
        public frmBaseMatchImport()
        {
            InitializeComponent();
        }

        #region Virtual Methods

        protected virtual void ImportSunFile() { } 
        protected virtual void ImportScannedDocuments() { } 
        protected virtual void Match() { } 
        protected virtual void ViewMatchedUnMatched() { } 

        #endregion

        #region Protected Properties

        private List<string> _SunErrors;
        protected List<string> SunErrors 
        {
            set
            {
                _SunErrors = value;
                if (_SunErrors.IsNotNull())
                    if (_SunErrors.Count > 0)
                        btnErrorsSunFile.Visible = true;
            }
        }

        private List<string> _ScannedDocumentErrors;
        protected List<string> ScannedDocumentErrors 
        {
            set
            {
                _ScannedDocumentErrors = value;
                if (_ScannedDocumentErrors.IsNotNull())
                    if (_ScannedDocumentErrors.Count > 0)
                        btnErrorsScannedDocuments.Visible = true;
            }
        }

        #endregion

        #region Event Handlers

        private void btnImportSunFile_Click(object sender, EventArgs e)
        {
            ImportSunFile();
        }

        private void btnImportScannedDocuments_Click(object sender, EventArgs e)
        {
            ImportScannedDocuments();
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            Match();
        }

        private void btnErrorsSunFile_Click(object sender, EventArgs e)
        {
            frmGridView gv = new frmGridView();
            gv.ShowForm(_SunErrors);
        }

        private void btnErrorsScannedDocuments_Click(object sender, EventArgs e)
        {
            frmGridView gv = new frmGridView();
            gv.ShowForm(_ScannedDocumentErrors);
        }

        private void btnViewMatchedUnMatched_Click(object sender, EventArgs e)
        {
            ViewMatchedUnMatched();
        }

        #endregion

        #region Protected Methods

        protected string OpenFileDialog()
        {
            try
            {
                openFileDialog.FileName = string.Empty;
                openFileDialog.ShowDialog();
                this.Refresh();
                return (openFileDialog.FileName.IsNull()) ? string.Empty : openFileDialog.FileName;
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
                return string.Empty;
            }
        }

        #endregion

    }
}
