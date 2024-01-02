using System;
using System.Data;
using System.Text;
using System.Data.Common;
using System.Collections.Generic;
using CS2010.Common;

namespace CS2010.SCAN.Business
{
    public partial class ClsUser : ClsBaseTable
    {
        #region Connection Manager

        protected static ClsConnection Connection
        {
            get { return ClsConMgr.Manager["SECURITY"]; }
        }
        #endregion		// #region Connection Manager

        #region Table Constants

        public const string TableName = "R_USER";
        public const int PrimaryKeyCount = 1;
        public static bool HasPrimaryKey
        {
            get { return PrimaryKeyCount > 0; }
        }
        public static string[] GetPrimaryKeys()
        {
            return new string[PrimaryKeyCount] { "USER_ID" };
        }

        public const string SelectSQL = @"SELECT * FROM R_USER 
				INNER JOIN R_OFFICE
				ON R_USER.OFFICE_CD=R_OFFICE.OFFICE_CD
				INNER JOIN R_SECURITY_GROUP
				ON R_USER.SECURITY_GROUP_ID=R_SECURITY_GROUP.SECURITY_GROUP_ID ";

        #endregion	// #region Table Constants

        #region Column Length Constants

        public const int Domain_NmMax = 30;
        public const int Active_FlgMax = 1;
        public const int Office_CdMax = 3;

        #endregion	// #region Column Length Constants

        #region Column Fields

        protected Int64? _User_ID;
        protected string _Domain_Nm;
        protected Int64? _Security_Group_ID;
        protected string _Active_Flg;
        protected string _Office_Cd;

        #endregion	// #region Column Fields

        #region Column Properties

        public Int64? User_ID
        {
            get { return _User_ID; }
            set
            {
                if (_User_ID == value) return;

                _User_ID = value;
                _IsDirty = true;
                NotifyPropertyChanged("User_ID");
            }
        }
        public string Domain_Nm
        {
            get { return _Domain_Nm; }
            set
            {
                string val = (string.IsNullOrEmpty(value) == false)
                    ? value.Trim() : null;

                if (string.IsNullOrEmpty(val) == true) val = null;

                if (string.Compare(_Domain_Nm, val, false) == 0) return;

                if (val != null && val.Length > Domain_NmMax)
                    _Domain_Nm = val.Substring(0, (int)Domain_NmMax);
                else
                    _Domain_Nm = val;

                _IsDirty = true;
                NotifyPropertyChanged("Domain_Nm");
            }
        }
        public Int64? Security_Group_ID
        {
            get { return _Security_Group_ID; }
            set
            {
                if (_Security_Group_ID == value) return;

                _Security_Group_ID = value;
                _IsDirty = true;
                NotifyPropertyChanged("Security_Group_ID");
            }
        }
        public string Active_Flg
        {
            get { return _Active_Flg; }
            set
            {
                string val = (string.IsNullOrEmpty(value) == false)
                    ? value.Trim() : null;

                if (string.IsNullOrEmpty(val) == true) val = null;

                if (string.Compare(_Active_Flg, val, false) == 0) return;

                if (val != null && val.Length > Active_FlgMax)
                    _Active_Flg = val.Substring(0, (int)Active_FlgMax);
                else
                    _Active_Flg = val;

                _IsDirty = true;
                NotifyPropertyChanged("Active_Flg");
            }
        }
        public string Office_Cd
        {
            get { return _Office_Cd; }
            set
            {
                string val = (string.IsNullOrEmpty(value) == false)
                    ? value.Trim() : null;

                if (string.IsNullOrEmpty(val) == true) val = null;

                if (string.Compare(_Office_Cd, val, false) == 0) return;

                if (val != null && val.Length > Office_CdMax)
                    _Office_Cd = val.Substring(0, (int)Office_CdMax);
                else
                    _Office_Cd = val;

                _IsDirty = true;
                NotifyPropertyChanged("Office_Cd");
            }
        }

        #endregion	// #region Column Properties

        #region Foreign Key Fields

        protected ClsOffice _Office;
        protected ClsSecurityGroup _Security_Group;

        #endregion	// #region Foreign Key Fields

        #region Foreign Key Properties

        public ClsOffice Office
        {
            get
            {
                if (Office_Cd == null)
                    _Office = null;
                else if (_Office == null ||
                    _Office.Office_Cd != Office_Cd)
                    _Office = ClsOffice.GetUsingKey(Office_Cd);
                return _Office;
            }
            set
            {
                if (_Office == value) return;

                _Office = value;
            }
        }
        public ClsSecurityGroup Security_Group
        {
            get
            {
                if (Security_Group_ID == null)
                    _Security_Group = null;
                else if (_Security_Group == null ||
                    _Security_Group.Security_Group_ID != Security_Group_ID)
                    _Security_Group = ClsSecurityGroup.GetUsingKey(Security_Group_ID.Value);
                return _Security_Group;
            }
            set
            {
                if (_Security_Group == value) return;

                _Security_Group = value;
            }
        }

        #endregion	// #region Foreign Key Properties

        #region Constructors

        public ClsUser() : base() { }
        public ClsUser(DataRow dr) : base(dr) { }
        public ClsUser(ClsUser src) { CopyFrom(src); }

        #endregion		// #region Constructors

        #region Init methods

        public override void ResetColumns()
        {
            User_ID = null;
            Domain_Nm = null;
            Security_Group_ID = null;
            Active_Flg = null;
            Office_Cd = null;
        }

        public void CopyFrom(ClsUser src)
        {
            User_ID = src._User_ID;
            Domain_Nm = src._Domain_Nm;
            Security_Group_ID = src._Security_Group_ID;
            Active_Flg = src._Active_Flg;
            Office_Cd = src._Office_Cd;
        }

        public override bool ReloadFromDB()
        {
            ClsUser tmp = ClsUser.GetUsingKey(User_ID.Value);
            if (tmp != null) CopyFrom(tmp);

            ResetFKs();
            OnReload();

            return (tmp != null);
        }

        public override void ResetFKs()
        {
            _Office = null;
            _Security_Group = null;
        }
        #endregion		// #region Init methods

        #region Insert, Update, Delete

        public override int Insert()
        {

            DbParameter[] p = new DbParameter[5];

            p[0] = Connection.GetParameter
                ("@DOMAIN_NM", Domain_Nm);
            p[1] = Connection.GetParameter
                ("@SECURITY_GROUP_ID", Security_Group_ID);
            p[2] = Connection.GetParameter
                ("@ACTIVE_FLG", Active_Flg);
            p[3] = Connection.GetParameter
                ("@OFFICE_CD", Office_Cd);
            p[4] = Connection.GetParameter
                ("@USER_ID", User_ID, ParameterDirection.Output, DbType.Int64, 0);

            const string sql = @"
				INSERT INTO R_USER
					(USER_ID, DOMAIN_NM, SECURITY_GROUP_ID,
					ACTIVE_FLG, OFFICE_CD)
				VALUES
					(USER_ID_SEQ.NEXTVAL, @DOMAIN_NM, @SECURITY_GROUP_ID,
					@ACTIVE_FLG, @OFFICE_CD)
				RETURNING
					USER_ID
				INTO
					@USER_ID";
            int ret = Connection.RunSQL(sql, p);

            User_ID = ClsConvert.ToInt64Nullable(p[4].Value);
            return ret;
        }
        public override int Update()
        {
            DbParameter[] p = new DbParameter[5];

            p[0] = Connection.GetParameter
                ("@DOMAIN_NM", Domain_Nm);
            p[1] = Connection.GetParameter
                ("@SECURITY_GROUP_ID", Security_Group_ID);
            p[2] = Connection.GetParameter
                ("@ACTIVE_FLG", Active_Flg);
            p[3] = Connection.GetParameter
                ("@OFFICE_CD", Office_Cd);
            p[4] = Connection.GetParameter
                ("@USER_ID", User_ID);

            const string sql = @"
				UPDATE R_USER SET
					DOMAIN_NM = @DOMAIN_NM,
					SECURITY_GROUP_ID = @SECURITY_GROUP_ID,
					ACTIVE_FLG = @ACTIVE_FLG,
					OFFICE_CD = @OFFICE_CD
				WHERE
					USER_ID = @USER_ID
					";
            int ret = Connection.RunSQL(sql, p);


            return ret;
        }
        public override int Delete()
        {
            DbParameter[] p = new DbParameter[1];

            p[0] = Connection.GetParameter
                ("@USER_ID", User_ID);

            const string sql = @"
				DELETE FROM R_USER WHERE
				USER_ID=@USER_ID";
            return Connection.RunSQL(sql, p);
        }
        #endregion		// #region Insert, Update, Delete

        #region Conversion methods

        public override void LoadFromDataReader(DbDataReader dr)
        {
            if (dr == null)
                throw new ArgumentException
                    ("LoadFromDataReader: DataReader parameter was null");

            User_ID = ClsConvert.ToInt64Nullable(dr["USER_ID"]);
            Domain_Nm = ClsConvert.ToString(dr["DOMAIN_NM"]);
            Security_Group_ID = ClsConvert.ToInt64Nullable(dr["SECURITY_GROUP_ID"]);
            Active_Flg = ClsConvert.ToString(dr["ACTIVE_FLG"]);
            Office_Cd = ClsConvert.ToString(dr["OFFICE_CD"]);
        }

        public override void LoadFromDataRow(DataRow dr)
        {
            if (dr == null)
                throw new ArgumentException
                    ("LoadFromDataRow: DataRow parameter was null");

            DataRowVersion v = (dr.RowState == DataRowState.Deleted)
                ? DataRowVersion.Original : DataRowVersion.Current;

            User_ID = ClsConvert.ToInt64Nullable(dr["USER_ID", v]);
            Domain_Nm = ClsConvert.ToString(dr["DOMAIN_NM", v]);
            Security_Group_ID = ClsConvert.ToInt64Nullable(dr["SECURITY_GROUP_ID", v]);
            Active_Flg = ClsConvert.ToString(dr["ACTIVE_FLG", v]);
            Office_Cd = ClsConvert.ToString(dr["OFFICE_CD", v]);
        }

        public override void CopyToDataRow(DataRow dr)
        {
            if (dr == null)
                throw new ArgumentException
                    ("CopyToDataRow: DataRow parameter was null");

            dr["USER_ID"] = ClsConvert.ToDbObject(User_ID);
            dr["DOMAIN_NM"] = ClsConvert.ToDbObject(Domain_Nm);
            dr["SECURITY_GROUP_ID"] = ClsConvert.ToDbObject(Security_Group_ID);
            dr["ACTIVE_FLG"] = ClsConvert.ToDbObject(Active_Flg);
            dr["OFFICE_CD"] = ClsConvert.ToDbObject(Office_Cd);
        }
        #endregion		// #region Conversion methods

        #region Static Methods

        public static DataTable GetAll()
        {
            return Connection.GetTable(TableName);
        }

        public static DataTable GetAll(bool withJoins)
        {
            if (withJoins == false) return Connection.GetTable(TableName);

            return Connection.GetDataTable(SelectSQL);
        }

        public static ClsUser GetUsingKey(Int64 User_ID)
        {
            object[] vals = new object[] { User_ID };
            DataRow dr = Connection.GetDataRowUsingKey
                (TableName, GetPrimaryKeys(), vals);
            return (dr == null) ? null : new ClsUser(dr);
        }
        public static DataTable GetAll(string Office_Cd, Int64? Security_Group_ID)
        {
            List<DbParameter> lst = new List<DbParameter>();
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(Office_Cd) == false)
            {
                lst.Add(Connection.GetParameter("@OFFICE_CD", Office_Cd));
                sb.Append(" WHERE R_USER.OFFICE_CD=@OFFICE_CD");
            }
            if (Security_Group_ID != null && Security_Group_ID > 0)
            {
                lst.Add(Connection.GetParameter("@SECURITY_GROUP_ID", Security_Group_ID));
                sb.AppendFormat(" {0} R_USER.SECURITY_GROUP_ID=@SECURITY_GROUP_ID",
                    sb.Length > 0 ? "AND" : "WHERE");
            }
            sb.Insert(0, SelectSQL);
            return Connection.GetDataTable(sb.ToString(), lst.ToArray());
        }
        #endregion		// #region Static Methods
    }
}