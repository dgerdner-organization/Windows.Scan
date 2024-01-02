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
    public partial class frmGridView : Form
    {
        public frmGridView()
        {
            InitializeComponent();
        }

        public void ShowForm(List<string> lst)
        {
            LoadListBox(lst);
            this.ShowDialog();
        }

        private void LoadListBox(List<string> l)
        {
            try
            {
                foreach (string s in l)
                    listBox.Items.Add(s);
            }
            catch (Exception ex)
            {
                Program.ShowError(ex);
            }
        }

    }
}
