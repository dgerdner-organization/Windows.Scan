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
    public partial class frmWorking : Form
    {
        private Boolean AreWeLoading = true;

        public string Message 
        {
            set
            {
                lblMessage.Text = value;
                this.Refresh();
            }
        }

        public frmWorking()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            this.Show();
            while (AreWeLoading)
            {
                //Something
            }
            this.Refresh();
        }

        private void frmWorking_Load(object sender, EventArgs e)
        {
            AreWeLoading = false;
        }


    }
}
