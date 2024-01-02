using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CS2010.SCAN.Business;
using CS2010.Common;
using System.Data;
using System.ComponentModel;

namespace Scan.Business
{

    public class mgrMatch : mgrBase
    {
        public delegate void MatchHandler(object o, MatchEventArgs e);
        public event MatchHandler MatchEvent;


        #region AP

        public void MatchAP()
        {
            string sqlImages = "Select * from t_image_ap where sun_ap_id is null and ACTIVE_FLG = 'Y' ";
            string sqlSunData = "Select count(*) from t_sun_ap where matched_flg = 'N' and ACTIVE_FLG = 'Y'  ";

            string sqlMatch = @"Select ap.image_ap_id, sap.sun_ap_id   
                                from t_image_ap ap, t_sun_ap sap
                                where 1=1
                                and ap.sun_database_cd = sap.database_code
                                and ap.invoice_amt = sap.invoice_amt
                                and ap.sun_ap_id is null 
                                and ap.ACTIVE_FLG = 'Y' 
                                and sap.ACTIVE_FLG = 'Y' 
                                and sap.matched_flg = 'N' 
                                and ap.image_ap_id = ";

            MatchEventArgs ea = new MatchEventArgs() { Complete = false };
            DataTable dtImages;
            DataTable dtSunAp;
            ClsImageAp ap;
            ClsSunAp sap;
            object objU; 

            try
            {

                Connection.TransactionBegin();

                dtImages = Connection.GetDataTable(sqlImages);
                ea.UnmatchedImages = 0;
                if (dtImages.Rows.IsNotNull()) ea.UnmatchedImages = dtImages.Rows.Count;
                MatchEvent(null, ea);

                // Do we have images
                if (ea.UnmatchedImages > 0)
                {
                    objU = Connection.GetScalar(sqlSunData);
                    ea.UnmatchedSunData = (objU == null) ? 0 : objU.ToInt(); ;
                    MatchEvent(null, ea);

                    // Do we have sun Data
                    if (ea.UnmatchedSunData > 0)
                    {
                        foreach (DataRow dr in dtImages.Rows)
                        {
                            ap = new ClsImageAp(dr);
                            dtSunAp = Connection.GetDataTable(sqlMatch + ap.Image_Ap_ID.ToString());

                            if (dtSunAp.IsNotNull())
                            {
                                if (dtSunAp.Rows.Count > 1)
                                {
                                    ea.NumberUnMatched++;
                                    ClsScanEnvironment.Audit("COULD NOT MATCH - DUPLICATE EXIST FOR T_IMAGE_AP.IMAGE_AP_ID = " + ap.Image_Ap_ID);
                                }
                                else
                                {
                                    sap = ClsSunAp.GetUsingKey(dtSunAp.Rows[0]["SUN_AP_ID"].ToLong());
                                    ap.Sun_Ap_ID = sap.Sun_Ap_ID;
                                    ap.Update();

                                    sap.Matched_Flg = "Y";
                                    sap.Update();

                                    ea.NumberMatched++;
                                }
                                MatchEvent(null, ea);
                            }
                        }
                    }
                }

                Connection.TransactionCommit();
                ea.Complete = true;
                MatchEvent(null, ea);

            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                ClsScanEnvironment.Audit(ex.Message);
                Connection.TransactionRollback();
                throw;
            }
            finally
            {
            }

        }

        public BindingList<ClsImageAp> GetAPUnmatchedImages()
        {
            string sql = @"Select * from t_image_ap ap where ap.sun_ap_id is null and ACTIVE_FLG = 'Y' order by create_dt asc";

            try
            {
                return new BindingList<ClsImageAp>(Connection.GetList<ClsImageAp>(sql));
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                return null;
            }

        }

        public BindingList<ClsSunAp> GetAPUnmatcheSunData()
        {
            string sql = @"Select * from t_sun_ap sap where sap.matched_flg = 'N' and ACTIVE_FLG = 'Y' order by create_dt asc";

            try
            {
                return new BindingList<ClsSunAp>(Connection.GetList<ClsSunAp>(sql));
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                return null;
            }

        }

        public clsAPManualMatch APManualMatch(BindingList<ClsImageAp> lstScannedDoc, BindingList<ClsSunAp> lstSunData)
        {
            clsAPManualMatch amm = new clsAPManualMatch();

            try
            {
                if (lstScannedDoc.IsNull())
                {
                    amm.ErrMsg = "Please select an image to match.";
                    return amm;
                }
                if (lstScannedDoc.Count > 1)
                {
                    amm.ErrMsg = "Please select only one image to match.";
                    return amm;
                }

                if (lstSunData.IsNull())
                {
                    amm.ErrMsg = "Please select SUN data to match.";
                    return amm;
                }
                if (lstSunData.Count > 1)
                {
                    amm.ErrMsg = "Please select only one SUN record to match.";
                    return amm;
                }

                amm.objIMAGE_AP = (ClsImageAp)lstScannedDoc[0];
                amm.objSUN_AP = (ClsSunAp)lstSunData[0];
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                amm.ErrMsg = ex.Message;
            }

            return amm;
        }

        public bool CommitAP(IBindingList lstMM)
        {
            try
            {
                Connection.TransactionBegin();

                foreach (clsAPManualMatch ap in lstMM)
                {
                    ap.objIMAGE_AP.Sun_Ap_ID = ap.objSUN_AP.Sun_Ap_ID;
                    ap.objSUN_AP.Matched_Flg = "Y";
                    
                    if (ap.objIMAGE_AP.Update() != 1)
                    {
                        Connection.TransactionRollback();
                        return false;
                    }
                    if (ap.objSUN_AP.Update() != 1)
                    {
                        Connection.TransactionRollback();
                        return false;
                    }
                }

                Connection.TransactionCommit();
                return true;
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Connection.TransactionRollback();
                return false;
            }
        }

        public ClsResult APDeleteImages(BindingList<ClsImageAp> lstImages)
        {
            ClsResult r = new ClsResult();

            foreach (ClsImageAp ap in lstImages)
            {
                if (ap.Delete() != 1)
                    r.ErrMsgAdd("Could not 'Delete' image {0}.", ap.File_Nm);
                else
                    DeleteFile(ap.FullFileName);
                r.Counter++;
            }

            return r;
        }

        public ClsResult APDeleteSunRecords(BindingList<ClsSunAp> lst)
        {
            ClsResult r = new ClsResult();

            foreach (ClsSunAp ap in lst)
            {
                if (ap.Delete() != 1)
                    r.ErrMsgAdd("Could not 'Delete' Sun Record. DB={0}, Ref={1}, Check #={2}", ap.Database_Code, ap.Reference_No, ap.Check_No);
                r.Counter++;
            }

            return r;
        }

        #endregion

        #region JE

        public void MatchJE()
        {
            string sqlImages = "Select * from t_image_je where sun_je_id is null and ACTIVE_FLG = 'Y' ";
            string sqlSunData = "Select count(*) from t_sun_je where matched_flg = 'N' and ACTIVE_FLG = 'Y' ";

            string sqlMatch = @"Select je.image_Je_id, sje.sun_je_id   
                                from t_image_je je, t_sun_je sje
                                where 1=1
                                and je.sun_database_cd = sje.database_code
                                and je.journal_no = sje.journal_no
                                and je.sun_je_id is null 
                                and je.ACTIVE_FLG = 'Y' 
                                and sje.ACTIVE_FLG = 'Y' 
                                and sje.matched_flg = 'N'
                                and je.image_je_id =";

            MatchEventArgs ea = new MatchEventArgs() { Complete = false };
            DataTable dtSunJe;
            DataTable dtImages;
            object objU;
            ClsImageJe je;
            ClsSunJe sje;

            try
            {

                Connection.TransactionBegin();

                dtImages = Connection.GetDataTable(sqlImages);
                ea.UnmatchedImages = 0;
                if (dtImages.Rows.IsNotNull()) ea.UnmatchedImages = dtImages.Rows.Count;
                MatchEvent(null, ea);

                // Do we have images
                if (ea.UnmatchedImages > 0)
                {
                    objU = Connection.GetScalar(sqlSunData);
                    ea.UnmatchedSunData = (objU == null) ? 0 : objU.ToInt(); ;
                    MatchEvent(null, ea);

                    // Do we have sun Data
                    if (ea.UnmatchedSunData > 0)
                    {
                        foreach (DataRow dr in dtImages.Rows)
                        {
                            je = new ClsImageJe(dr);
                            dtSunJe = Connection.GetDataTable(sqlMatch + je.Image_Je_ID.ToString());

                            if (dtSunJe.IsNotNull())
                            {
                                if (dtSunJe.Rows.Count > 1)
                                {
                                    ea.NumberUnMatched++;
                                    ClsScanEnvironment.Audit("COULD NOT MATCH - DUPLICATE EXIST FOR T_IMAGE_JE.IMAGE_JE_ID = " + je.Image_Je_ID);
                                }
                                else
                                {
                                    sje = ClsSunJe.GetUsingKey(dtSunJe.Rows[0]["SUN_JE_ID"].ToLong());
                                    je.Sun_Je_ID = sje.Sun_Je_ID;
                                    je.Update();

                                    sje.Matched_Flg = "Y";
                                    sje.Update();

                                    ea.NumberMatched++;
                                }
                                MatchEvent(null, ea);
                            }
                        }
                    }
                }

                Connection.TransactionCommit();
                ea.Complete = true;
                MatchEvent(null, ea);

            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                ClsScanEnvironment.Audit(ex.Message);
                Connection.TransactionRollback();
                throw;
            }
            finally
            {
            }

        }

        public BindingList<ClsImageJe> GetJEUnmatchedImages()
        {
            string sql = @"Select * from t_image_JE JE where JE.sun_JE_id is null and ACTIVE_FLG = 'Y' order by create_dt asc";

            try
            {
                return new BindingList<ClsImageJe>(Connection.GetList<ClsImageJe>(sql));
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                return null;
            }

        }

        public BindingList<ClsSunJe> GetJEUnmatcheSunData()
        {
            string sql = @"Select * from t_sun_JE sJE where sJE.matched_flg = 'N' and ACTIVE_FLG = 'Y' order by create_dt asc";

            try
            {
                return new BindingList<ClsSunJe>(Connection.GetList<ClsSunJe>(sql));
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                return null;
            }

        }

        public ClsResult JEDeleteImages(BindingList<ClsImageJe> lstImages)
        {
            ClsResult r = new ClsResult();

            foreach (ClsImageJe je in lstImages)
            {
                if (je.Delete() != 1)
                    r.ErrMsgAdd("Could not 'Delete' image {0}.", je.File_Nm);
                else                
                    DeleteFile(je.FullFileName);
                r.Counter++;
            }

            return r;
        }

        public ClsResult JEDeleteSunRecords(BindingList<ClsSunJe> lst)
        {
            ClsResult r = new ClsResult();

            foreach (ClsSunJe je in lst)
            {
                if (je.Delete() != 1)
                    r.ErrMsgAdd("Could not 'Delete' Sun Record. DB={0}, Journal={1}", je.Database_Code, je.Journal_No);
                r.Counter++;
            }

            return r;
        }

        public clsJEManualMatch JEManualMatch(BindingList<ClsImageJe> lstScannedDoc, BindingList<ClsSunJe> lstSunData)
        {
            clsJEManualMatch amm = new clsJEManualMatch();

            try
            {
                if (lstScannedDoc.IsNull())
                {
                    amm.ErrMsg = "Please select an image to match.";
                    return amm;
                }
                if (lstScannedDoc.Count > 1)
                {
                    amm.ErrMsg = "Please select only one image to match.";
                    return amm;
                }

                if (lstSunData.IsNull())
                {
                    amm.ErrMsg = "Please select SUN data to match.";
                    return amm;
                }
                if (lstSunData.Count > 1)
                {
                    amm.ErrMsg = "Please select only one SUN record to match.";
                    return amm;
                }

                amm.objIMAGE_JE = (ClsImageJe)lstScannedDoc[0];
                amm.objSUN_JE = (ClsSunJe)lstSunData[0];
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                amm.ErrMsg = ex.Message;
            }

            return amm;
        }

        public bool CommitJE(IBindingList lstMM)
        {
            try
            {
                Connection.TransactionBegin();

                foreach (clsJEManualMatch JE in lstMM)
                {
                    JE.objIMAGE_JE.Sun_Je_ID = JE.objSUN_JE.Sun_Je_ID;
                    JE.objSUN_JE.Matched_Flg = "Y";

                    if (JE.objIMAGE_JE.Update() != 1)
                    {
                        Connection.TransactionRollback();
                        return false;
                    }
                    if (JE.objSUN_JE.Update() != 1)
                    {
                        Connection.TransactionRollback();
                        return false;
                    }
                }

                Connection.TransactionCommit();
                return true;
            }
            catch(Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                Connection.TransactionRollback();
                return false;
            }
        }

        #endregion

    }

    public class MatchEventArgs
    {
        public int UnmatchedImages = 0;
        public int UnmatchedSunData = 0;
        public int NumberMatched = 0;
        public int NumberUnMatched = 0;
        public bool Complete = false;
    }

    public class clsAPManualMatch 
    {

        private ClsImageAp _objIMAGE_AP;
        private ClsSunAp _objSUN_AP;

        public ClsImageAp objIMAGE_AP
        {
            get
            {
                return _objIMAGE_AP;
            }
            set
            {
                _objIMAGE_AP = value;
            }
        }
        public ClsSunAp objSUN_AP
        {
            get
            {
                return _objSUN_AP;
            }
            set
            {
                _objSUN_AP = value;
            }
        }

        public string ErrMsg;

        public bool AreThereErrors
        {
            get
            {
                return (ErrMsg.IsNotNull());
            }
        }

    }

    public class clsJEManualMatch
    {

        private ClsImageJe _objIMAGE_JE;
        private ClsSunJe _objSUN_JE;

        public ClsImageJe objIMAGE_JE
        {
            get
            {
                return _objIMAGE_JE;
            }
            set
            {
                _objIMAGE_JE = value;
            }
        }
        public ClsSunJe objSUN_JE
        {
            get
            {
                return _objSUN_JE;
            }
            set
            {
                _objSUN_JE = value;
            }
        }

        public string ErrMsg;

        public bool AreThereErrors
        {
            get
            {
                return (ErrMsg.IsNotNull());
            }
        }

    }

}
