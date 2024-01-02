using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS2010.Common;

namespace CS2010.SCAN.Business
{
    public partial class ClsOceanCarrier
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
            if (this.Ocean_Carrier_Cd.IsNull()) r.ErrMsgAdd("Ocean Carrier Code is not valid.");
            if (this.Ocean_Carrier_Dsc.IsNull()) r.ErrMsgAdd("Ocean Carrier Description is not valid.");
            return r;
        }

    }
}
