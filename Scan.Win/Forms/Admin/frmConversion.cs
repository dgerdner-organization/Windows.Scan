using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Scan.Business;
using CS2010.Common;
using CS2010.SCAN.Business;

namespace Scan.Win
{
    public partial class frmConversion : Form
    {
        public frmConversion()
        {
            InitializeComponent();
        }

        private void btnConvertAP_Click(object sender, EventArgs e)
        {
            mgrConversion con = new mgrConversion();
            con.ConversionEvent +=new mgrConversion.ConversionHandler(con_ConversionEvent);

            try
            {
                if (!TestJDIndicator()) return;

                con.ExportAP( txtJD_IND.Text);
            }
            catch (Exception ex)
            {
                Program.ShowError(ex.Message);
            }
            finally
            {
                con.ConversionEvent -= new mgrConversion.ConversionHandler(con_ConversionEvent);
            }
        }

        private void con_ConversionEvent(object o, ConversionEventArg e)
        {
            try
            {

                string msg = (e.Msg.IsNull()) ?
                    string.Format("Exported file #: {0} - FileName: {1}", e.FileNumber, e.FileName) :
                    e.Msg;

                ClsScanEnvironment.Audit(msg);
                lblMsg.Text = msg;
            }
            catch 
            {
                // Do nothing ... just keep on processing ...
            }
            this.Refresh();

         
        }

        private void btnConvertJE_Click(object sender, EventArgs e)
        {
            mgrConversion con = new mgrConversion();
            con.ConversionEvent += new mgrConversion.ConversionHandler(con_ConversionEvent);

            try
            {
                if (!TestJDIndicator()) return;
                
                con.ExportJE(txtJD_IND.Text);
            }
            catch (Exception ex)
            {
                Program.ShowError(ex.Message);
            }
            finally
            {
                con.ConversionEvent -= new mgrConversion.ConversionHandler(con_ConversionEvent);
            }
        }


        private bool TestJDIndicator()
        {
            if (!txtJD_IND.Text.IsInteger())
            {
                DialogResult r = MessageBox.Show("You have not specified an 'Indicator'.  Do you want to proceed processing ALL ?", "JD Indicator", MessageBoxButtons.YesNo);
                if (r == System.Windows.Forms.DialogResult.No) return false;
                txtJD_IND.Text = "0";
            }
            return true;
        }

        private void btnSubFolderConvertAP_Click(object sender, EventArgs e)
        {
            mgrConversion con = new mgrConversion();
            con.ConversionEvent += new mgrConversion.ConversionHandler(con_ConversionEvent);

            try
            {
                con.SubFolderConvertAP();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex.Message);
            }
            finally
            {
                con.ConversionEvent -= new mgrConversion.ConversionHandler(con_ConversionEvent);
            }


        }

        private void btnSubFolderConvertJE_Click(object sender, EventArgs e)
        {
            mgrConversion con = new mgrConversion();
            con.ConversionEvent += new mgrConversion.ConversionHandler(con_ConversionEvent);

            try
            {
                con.SubFolderConvertJE();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex.Message);
            }
            finally
            {
                con.ConversionEvent -= new mgrConversion.ConversionHandler(con_ConversionEvent);
            }
        }

        private void btnAPCleanup_Click(object sender, EventArgs e)
        {
            mgrConversion con = new mgrConversion();
            con.ConversionEvent += new mgrConversion.ConversionHandler(con_ConversionEvent);

            try
            {
                con.SubFolderCleanupAP();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex.Message);
            }
            finally
            {
                con.ConversionEvent -= new mgrConversion.ConversionHandler(con_ConversionEvent);
            }
        }

        private void btnJECleanup_Click(object sender, EventArgs e)
        {
            mgrConversion con = new mgrConversion();
            con.ConversionEvent += new mgrConversion.ConversionHandler(con_ConversionEvent);

            try
            {
                con.SubFolderCleanupJE();
            }
            catch (Exception ex)
            {
                Program.ShowError(ex.Message);
            }
            finally
            {
                con.ConversionEvent -= new mgrConversion.ConversionHandler(con_ConversionEvent);
            }
        }

    }
}
