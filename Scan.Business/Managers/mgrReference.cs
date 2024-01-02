using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CS2010.SCAN.Business;
using Scan.Business;
using CS2010.Common;

namespace CS2010.SCAN.Business
{
    public class mgrReference : mgrBase
    {
        public DataTable GetListOfOffices()
        {
            return ClsOffice.GetAll();
        }

        public DataTable GetListOfUsers()
        {
            return ClsUser.GetAll(true);
        }

        public DataTable GetListOfOceanCarriers()
        {
            return ClsOceanCarrier.GetAll();
        }

        public DataTable GetListOfSunDatabases()
        {
            return ClsSunDatabase.GetAll();
        }

        public DataTable GetListOfSecurityGroups()
        {
            return ClsSecurityGroup.GetAll();
        }

        public DataTable GetListOfSecurityFeatures()
        {
            return ClsSecurityFeature.GetAll();
        }

        public DataTable GetListOfSecurity()
        {
            return ClsSecurity.GetAll();
        }

        public DataTable GetListOfAPVendors()
        {
            string sql = @"
                Select distinct sap.vendor_account_cd, sap.vendor_account_nm
                from t_sun_ap sap
                where 1=1 
                and active_flg = 'Y' 
                and sap.matched_flg = 'Y'
                order by sap.vendor_account_nm";


            DataTable dt = Connection.GetDataTable(sql);

            return dt;
        }

        public DataTable GetListOfAPReferenceNo()
        {
            string sql = @"
                Select distinct sap.reference_no, sap.reference_no as reference_dsc
                from t_sun_ap sap 
                where 1=1 
                and active_flg = 'Y' 
                and sap.matched_flg = 'Y'
                order by sap.reference_no";

            DataTable dt = Connection.GetDataTable(sql);

            return dt;

        }

        public DataTable GetDeniedSecurity(string SecurityFeatureCd)
        {
            string sql = @"
                Select s.security_id, sg.security_group_id, sg.security_group_dsc 
                from r_security s 
                inner join r_security_group sg on sg.security_group_id = s.security_group_id
                where s.security_feature_cd = '{0}'
                and s.allow_flg = 'N'
                order by sg.security_group_dsc ";

            sql = string.Format(sql, SecurityFeatureCd);

            return Connection.GetDataTable(sql);

        }

        public ClsResult AddSecurty(string SecurityFeatureCd, long SecurityGroupID)
        {
            ClsResult r = new ClsResult();
            
            try
            {
                ClsSecurity s = new ClsSecurity();
                s.Security_Feature_Cd = SecurityFeatureCd;
                s.Security_Group_ID = SecurityGroupID;
                s.Allow_Flg = "N";

                if (s.Insert() != 1)  r.ErrMsgAdd("Could not insert.");
            }
            catch (Exception ex)
            {
                r.ErrMsgAdd(ex.Message);
            }
            return r;
        }

        public ClsResult RemoveSecurity(long SecurityID)
        {
            ClsResult r = new ClsResult();
            ClsSecurity s;

            try
            {
                s = ClsSecurity.GetUsingKey(SecurityID);

                if (s.IsNull())
                    r.ErrMsgAdd("Could not load Security.");
                else
                    if (s.Delete() != 1)
                        r.ErrMsgAdd("Could not remove Security.");
            }
            catch (Exception ex)
            {
                r.ErrMsgAdd(ex.Message);                
            }
            return r;
        }

        public DataTable GetDeniedSecurityForUser(long UserID)
        {
            string sql = @"
                Select s.security_feature_cd
                from r_user u
                inner join r_security s on s.security_group_id = u.security_group_id
                where u.user_id = {0}";

            sql = string.Format(sql, UserID.ToString());

            return Connection.GetDataTable(sql);

        }
    }
}
