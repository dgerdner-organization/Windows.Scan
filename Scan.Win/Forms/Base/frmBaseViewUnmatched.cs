using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CS2010.SCAN.Business;

namespace Scan.Win
{
    public partial class frmBaseViewUnmatched : Form
    {
        public frmBaseViewUnmatched()
        {
            InitializeComponent();
        }

        #region Virtual Methods

        virtual protected void Match() { }
        virtual protected void CommitToDatabase() { }
        virtual protected void DeleteImages() { }
        virtual protected void DeleteSunRecords() { } 

        #endregion

        #region Event Handlers  

        private void btnMatch_Click(object sender, EventArgs e)
        {
            Match();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            CommitToDatabase();
        }

        private void tsmiDeleteImages_Click(object sender, EventArgs e)
        {
            DeleteImages();
        }

        private void tsmiDeleteSunRecords_Click(object sender, EventArgs e)
        {
            DeleteSunRecords();
        }

        #endregion

        #region Protected Methods

        protected void ViewFile(string Folder, string FileNm)
        {
            try
            {
                string shellFileName = string.Format("{0}\\{1}",  Folder, FileNm);
                //System.Diagnostics.Process.Start(shellFileName);

                Program.ShellExecute(this.Handle, "open", shellFileName, "", "", 3);
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

        #endregion


    }
}
