using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS2010.Common;

namespace CS2010.SCAN.Business
{
    public partial class ClsUser
    {

        public void AddUser()
        {
            bool newTx = !Connection.IsInTransaction;

            try
            {
                if (newTx == true) Connection.TransactionBegin();

                // 1- Insert user into Database
                Insert();

                // 2 - Create User in Database
                string sqlOracleUser = string.Format(@"
				create user {0}
					identified by {1}
					default tablespace USERS
					temporary tablespace TEMP
					profile DEFAULT", Domain_Nm, ClsEnvironment.GlobalDictionary["SCAN_USER_PWD"]);
                Connection.RunSQL(sqlOracleUser);

                // 3 - Assign 'SCAN_USER' Role
                string sqlRole = string.Format("grant SCAN_USER to {0} with admin option", Domain_Nm);
                Connection.RunSQL(sqlRole);

                if (newTx == true) Connection.TransactionCommit();
                
            }
            catch 
            {
                if (newTx == true) Connection.TransactionRollback();
                throw;
            }
        }

        public void DefaultInsert()
        {
            Active_Flg = "Y";
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
            if (this.Domain_Nm.IsNull()) r.ErrMsgAdd("User Name is not valid.");
            if (this.Security_Group_ID.IsNull()) r.ErrMsgAdd("Security Group is not valid.");
            if (this.Office_Cd.IsNull()) r.ErrMsgAdd("Office is not valid.");
            return r;
        }

        public void DefaultUpdate()
        {
            // Nothing ...
        }

        public static ClsUser GetByUserName(string userName)
        {
            string sql = "Select * from r_user where DOMAIN_NM = '" + userName + "'";
            return new ClsUser(Connection.GetDataRow(sql));
        }
    }
}
