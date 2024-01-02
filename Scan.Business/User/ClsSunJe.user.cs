using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS2010.SCAN.Business;
using CS2010.Common;
using System.IO;
using Scan.Business;

namespace CS2010.SCAN.Business
{
    public partial class ClsSunJe
    {




        private bool _importError = false;
        public bool importError
        {
            get
            {
                return _importError;
            }
            set
            {
                _importError = value;
            }
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
            if (this.Entry_Dt.IsNull()) r.ErrMsgAdd("Entry Date is not valid.");
            if (this.Journal_No.IsNull()) r.ErrMsgAdd("Journal # is not valid.");
            if (this.Accounting_Period.IsNull()) r.ErrMsgAdd("Accounting Period is not valid.");
            if (this.Journal_Source.IsNull()) r.ErrMsgAdd("Journal Source is not valid.");
            if (this.Journal_Type.IsNull()) r.ErrMsgAdd("Journal Type is not valid.");
            if (this.Sun_Version_No.IsNull()) r.ErrMsgAdd("SUN Version # is not valid.");

            return r;
        }

    }
}
