using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS2010.Common;

namespace CS2010.SCAN.Business
{
    public partial class ClsSunDatabase
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
            if (this.Sun_Database_Cd.IsNull()) r.ErrMsgAdd("Database Code is not valid.");
            if (this.Sun_Database_Dsc.IsNull()) r.ErrMsgAdd("Database Description is not valid.");
            return r;
        }

    }
}
