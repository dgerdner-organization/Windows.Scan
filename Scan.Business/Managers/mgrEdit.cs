using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS2010.Common;
using CS2010.SCAN.Business;

namespace Scan.Business
{
    public class mgrEdit : mgrBase
    {
        public ClsResult UnlinkAP(ClsSunAp sap, ClsImageAp iap)
        {
            ClsResult r = new ClsResult();
            Connection.TransactionBegin();

            try
            {
                sap.Matched_Flg = "N";
                if (sap.Update() != 1) r.ErrMsgAdd("Could not unlink the SUN Data.");

                iap.Sun_Ap_ID = null;
                if (iap.Update() != 1) r.ErrMsgAdd("Could not unlink the Image Data.");

                if (r.AreThereErrors)
                    Connection.TransactionRollback();
                else
                    Connection.TransactionCommit();
            }
            catch (Exception ex)
            {
                Connection.TransactionRollback();
                r.ErrMsgAdd(ex.Message);
            }
            return r;
        }

        public ClsResult UnlinkJE(ClsSunJe sje, ClsImageJe ije)
        {
            ClsResult r = new ClsResult();
            Connection.TransactionBegin();

            try
            {
                sje.Matched_Flg = "N";
                if (sje.Update() != 1) r.ErrMsgAdd("Could not unlink the SUN Data.");

                ije.Sun_Je_ID = null;
                if (ije.Update() != 1) r.ErrMsgAdd("Could not unlink the Image Data.");

                if (r.AreThereErrors)
                    Connection.TransactionRollback();
                else
                    Connection.TransactionCommit();
            }
            catch (Exception ex)
            {
                Connection.TransactionRollback();
                r.ErrMsgAdd(ex.Message);
            }
            return r;
        }


    }
}
