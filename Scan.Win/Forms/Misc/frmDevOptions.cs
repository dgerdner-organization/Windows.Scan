using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CS2010.CommonWinCtrls;
using CS2010.SCAN.Business;

namespace Scan.Win
{
    public partial class frmDevOptions : frmChildBase
    {
        public frmDevOptions()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displays the Developer Database Options.
        /// </summary>
        /// 
        /// <returns></returns>
        public string ShowDevOptions()
        {

            foreach (string s in ClsScanEnvironment.lstDatabaseMode)
                cmbDatabaseMode.Items.Add(s);

            cmbDatabaseMode.Text = "D";
            cmbDatabaseMode.Focus();

            this.ShowDialog();
            return cmbDatabaseMode.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
