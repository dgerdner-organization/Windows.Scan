using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS2010.Common;

namespace CS2010.SCAN.Business
{
    public partial class ClsOffice
    {
        public void DefaultInsert()
        {
            this.Active_Flg = "Y";
        }

        public new ClsResult ValidateInsert()
        {
            ClsResult r = new ClsResult();
            r = ValidateCommon(r);
            return r;
        }

        public new ClsResult ValidateUpdate()
        {
            ClsResult r = new ClsResult();
            r = ValidateCommon(r);
            return r;
        }

        private ClsResult ValidateCommon(ClsResult r)
        {
            if (this.Office_Cd.IsNull()) r.ErrMsgAdd("Office Code is not valid.");
            if (this.Office_Dsc.IsNull()) r.ErrMsgAdd("Office Description is not valid.");
            return r;
        }

    }
}
