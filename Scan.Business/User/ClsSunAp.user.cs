using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CS2010.Common;
using Scan.Business;

namespace CS2010.SCAN.Business
{
    public partial class ClsSunAp 
    {
        private bool _importError = false;
        public bool importError
        {
            get { return _importError; }
            set { _importError = value; }
        }

        private string _errorMessage;
        public string errorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
            }
        }

        public new ClsResult ValidateUpdate()
        {
            ClsResult r = new ClsResult();

            if (this.Office_Cd.IsNull()) r.ErrMsgAdd("Office Code is not valid.");
            if (this.Database_Code.IsNull()) r.ErrMsgAdd("Database Code is not valid.");
            if (this.Journal_Entry.IsNull()) r.ErrMsgAdd("Journal Entry is not valid.");
            if (this.Reference_No.IsNull()) r.ErrMsgAdd("Reference # is not valid.");
            if (this.Vendor_Account_Cd.IsNull()) r.ErrMsgAdd("Vendor Account Code is not valid.");
            if (this.Vendor_Account_Nm.IsNull()) r.ErrMsgAdd("Vendor Account Name is not valid.");
            if (this.Invoice_Amt < 0) r.ErrMsgAdd("Invoice Amount is not valid.");
            if (this.Entry_User.IsNull()) r.ErrMsgAdd("Entry User is not valid.");
            // Invoice Date
            // Check Date
            if (this.Check_No.IsNull()) r.ErrMsgAdd("Check # is not valid.");
            if (this.Sun_Version_No.IsNull()) r.ErrMsgAdd("SUN Version # is not valid.");

            return r;
        }

    }
}
