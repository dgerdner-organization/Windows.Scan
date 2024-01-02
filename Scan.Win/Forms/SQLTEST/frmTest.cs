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
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<TEST> lstTest = new List<TEST>();

            lstTest.Add(new TEST() { TEST_IT = "HELLO WORLD1", SUBTEST = new sub_TEST() { TEST_IT2 = "1" } });
            lstTest.Add(new TEST() { TEST_IT = "HELLO WORLD2", SUBTEST = new sub_TEST() { TEST_IT2 = "2" } });
            lstTest.Add(new TEST() { TEST_IT = "HELLO WORLD3", SUBTEST = new sub_TEST() { TEST_IT2 = "3" } });
            lstTest.Add(new TEST() { TEST_IT = "HELLO WORLD4", SUBTEST = new sub_TEST() { TEST_IT2 = "4" } });

            ucGridEx1.DataSource = lstTest;

        }
    }

    public class TEST
    {
        public string TEST_IT { get; set; }

        public sub_TEST SUBTEST { get; set; }

    }

    public class sub_TEST
    {
        public string TEST_IT2 { get; set; }
    }

}
