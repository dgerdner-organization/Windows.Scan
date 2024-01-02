using System;
using System.Data;
using System.Text;
using System.Data.Common;
using System.Collections.Generic;
using CS2010.Common;

namespace CS2010.SCAN.Business
{
	public partial class ClsSecurity : ClsBaseTable
	{
		#region Connection Manager

		protected static ClsConnection Connection
		{
			get { return ClsConMgr.Manager["SECURITY"]; }
		}
		#endregion		// #region Connection Manager

		#region Table Constants

		public const string TableName = "R_SECURITY";
		public const int PrimaryKeyCount = 1;
		public static bool HasPrimaryKey
		{
			get { return PrimaryKeyCount > 0; }
		}
		public static string[] GetPrimaryKeys()
		{
			return new string[PrimaryKeyCount] { "SECURITY_ID" };
		}

		public const string SelectSQL = @"SELECT * FROM R_SECURITY 
				INNER JOIN R_SECURITY_FEATURE
				ON R_SECURITY.SECURITY_FEATURE_CD=R_SECURITY_FEATURE.SECURITY_FEATURE_CD
				INNER JOIN R_SECURITY_GROUP
				ON R_SECURITY.SECURITY_GROUP_ID=R_SECURITY_GROUP.SECURITY_GROUP_ID ";

		#endregion	// #region Table Constants

		#region Column Length Constants
	
		public const int Create_UserMax = 30;
		public const int Modify_UserMax = 30;
		public const int Security_Feature_CdMax = 20;
		public const int Allow_FlgMax = 1;

		#endregion	// #region Column Length Constants

		#region Column Fields

		protected Int64? _Security_ID;
		protected string _Create_User;
		protected DateTime? _Create_Dt;
		protected string _Modify_User;
		protected DateTime? _Modify_Dt;
		protected string _Security_Feature_Cd;
		protected Int64? _Security_Group_ID;
		protected string _Allow_Flg;

		#endregion	// #region Column Fields

		#region Column Properties

		public Int64? Security_ID
		{
			get { return _Security_ID; }
			set
			{
				if( _Security_ID == value ) return;
		
				_Security_ID = value;
				_IsDirty = true;
				NotifyPropertyChanged("Security_ID");
			}
		}
		public string Create_User
		{
			get { return _Create_User; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Create_User, val, false) == 0 ) return;
		
				if( val != null && val.Length > Create_UserMax )
					_Create_User = val.Substring(0, (int)Create_UserMax);
				else
					_Create_User = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Create_User");
			}
		}
		public DateTime? Create_Dt
		{
			get { return _Create_Dt; }
			set
			{
				if( _Create_Dt == value ) return;
		
				_Create_Dt = value;
				_IsDirty = true;
				NotifyPropertyChanged("Create_Dt");
			}
		}
		public string Modify_User
		{
			get { return _Modify_User; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Modify_User, val, false) == 0 ) return;
		
				if( val != null && val.Length > Modify_UserMax )
					_Modify_User = val.Substring(0, (int)Modify_UserMax);
				else
					_Modify_User = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Modify_User");
			}
		}
		public DateTime? Modify_Dt
		{
			get { return _Modify_Dt; }
			set
			{
				if( _Modify_Dt == value ) return;
		
				_Modify_Dt = value;
				_IsDirty = true;
				NotifyPropertyChanged("Modify_Dt");
			}
		}
		public string Security_Feature_Cd
		{
			get { return _Security_Feature_Cd; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Security_Feature_Cd, val, false) == 0 ) return;
		
				if( val != null && val.Length > Security_Feature_CdMax )
					_Security_Feature_Cd = val.Substring(0, (int)Security_Feature_CdMax);
				else
					_Security_Feature_Cd = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Security_Feature_Cd");
			}
		}
		public Int64? Security_Group_ID
		{
			get { return _Security_Group_ID; }
			set
			{
				if( _Security_Group_ID == value ) return;
		
				_Security_Group_ID = value;
				_IsDirty = true;
				NotifyPropertyChanged("Security_Group_ID");
			}
		}
		public string Allow_Flg
		{
			get { return _Allow_Flg; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Allow_Flg, val, false) == 0 ) return;
		
				if( val != null && val.Length > Allow_FlgMax )
					_Allow_Flg = val.Substring(0, (int)Allow_FlgMax);
				else
					_Allow_Flg = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Allow_Flg");
			}
		}

		#endregion	// #region Column Properties

		#region Foreign Key Fields

		protected ClsSecurityFeature _Security_Feature;
		protected ClsSecurityGroup _Security_Group;

		#endregion	// #region Foreign Key Fields

		#region Foreign Key Properties

		public ClsSecurityFeature Security_Feature
		{
			get
			{
				if( Security_Feature_Cd == null )
					_Security_Feature = null;
				else if( _Security_Feature == null ||
					_Security_Feature.Security_Feature_Cd != Security_Feature_Cd )
					_Security_Feature = ClsSecurityFeature.GetUsingKey(Security_Feature_Cd);
				return _Security_Feature;
			}
			set
			{
				if( _Security_Feature == value ) return;
		
				_Security_Feature = value;
			}
		}
		public ClsSecurityGroup Security_Group
		{
			get
			{
				if( Security_Group_ID == null )
					_Security_Group = null;
				else if( _Security_Group == null ||
					_Security_Group.Security_Group_ID != Security_Group_ID )
					_Security_Group = ClsSecurityGroup.GetUsingKey(Security_Group_ID.Value);
				return _Security_Group;
			}
			set
			{
				if( _Security_Group == value ) return;
		
				_Security_Group = value;
			}
		}

		#endregion	// #region Foreign Key Properties

		#region Constructors

		public ClsSecurity() : base() {}
		public ClsSecurity(DataRow dr) : base(dr) {}
		public ClsSecurity(ClsSecurity src) { CopyFrom(src); }

		#endregion		// #region Constructors

		#region Init methods

		public override void ResetColumns()
		{
			Security_ID = null;
			Create_User = null;
			Create_Dt = null;
			Modify_User = null;
			Modify_Dt = null;
			Security_Feature_Cd = null;
			Security_Group_ID = null;
			Allow_Flg = null;
		}

		public void CopyFrom(ClsSecurity src)
		{
			Security_ID = src._Security_ID;
			Create_User = src._Create_User;
			Create_Dt = src._Create_Dt;
			Modify_User = src._Modify_User;
			Modify_Dt = src._Modify_Dt;
			Security_Feature_Cd = src._Security_Feature_Cd;
			Security_Group_ID = src._Security_Group_ID;
			Allow_Flg = src._Allow_Flg;
		}

		public override bool ReloadFromDB()
		{
			ClsSecurity tmp = ClsSecurity.GetUsingKey(Security_ID.Value);
			if( tmp != null ) CopyFrom(tmp);

			ResetFKs();
			OnReload();

			return ( tmp != null );
		}

		public override void ResetFKs()
		{
			_Security_Feature = null;
			_Security_Group = null;
		}
		#endregion		// #region Init methods

		#region Insert, Update, Delete

		public override int Insert()
		{

			DbParameter[] p = new DbParameter[8];

			p[0] = Connection.GetParameter
				("@SECURITY_FEATURE_CD", Security_Feature_Cd);
			p[1] = Connection.GetParameter
				("@SECURITY_GROUP_ID", Security_Group_ID);
			p[2] = Connection.GetParameter
				("@ALLOW_FLG", Allow_Flg);
			p[3] = Connection.GetParameter
				("@SECURITY_ID", Security_ID, ParameterDirection.Output, DbType.Int64, 0);
			p[4] = Connection.GetParameter
				("@CREATE_USER", Create_User, ParameterDirection.Output, DbType.AnsiStringFixedLength, Create_UserMax);
			p[5] = Connection.GetParameter
				("@CREATE_DT", Create_Dt, ParameterDirection.Output, DbType.DateTime, 0);
			p[6] = Connection.GetParameter
				("@MODIFY_USER", Modify_User, ParameterDirection.Output, DbType.AnsiStringFixedLength, Modify_UserMax);
			p[7] = Connection.GetParameter
				("@MODIFY_DT", Modify_Dt, ParameterDirection.Output, DbType.DateTime, 0);

			const string sql = @"
				INSERT INTO R_SECURITY
					(SECURITY_ID, SECURITY_FEATURE_CD, SECURITY_GROUP_ID,
					ALLOW_FLG)
				VALUES
					(SECURITY_ID_SEQ.NEXTVAL, @SECURITY_FEATURE_CD, @SECURITY_GROUP_ID,
					@ALLOW_FLG)
				RETURNING
					SECURITY_ID, CREATE_USER, CREATE_DT,
					MODIFY_USER, MODIFY_DT
				INTO
					@SECURITY_ID, @CREATE_USER, @CREATE_DT,
					@MODIFY_USER, @MODIFY_DT";
			int ret = Connection.RunSQL(sql, p);

			Security_ID = ClsConvert.ToInt64Nullable(p[3].Value);
			Create_User = ClsConvert.ToString(p[4].Value);
			Create_Dt = ClsConvert.ToDateTimeNullable(p[5].Value);
			Modify_User = ClsConvert.ToString(p[6].Value);
			Modify_Dt = ClsConvert.ToDateTimeNullable(p[7].Value);
			return ret;
		}
		public override int Update()
		{
			DbParameter[] p = new DbParameter[6];

			p[0] = Connection.GetParameter
				("@MODIFY_DT", Modify_Dt, ParameterDirection.InputOutput, DbType.DateTime, 0);
			p[1] = Connection.GetParameter
				("@SECURITY_FEATURE_CD", Security_Feature_Cd);
			p[2] = Connection.GetParameter
				("@SECURITY_GROUP_ID", Security_Group_ID);
			p[3] = Connection.GetParameter
				("@ALLOW_FLG", Allow_Flg);
			p[4] = Connection.GetParameter
				("@SECURITY_ID", Security_ID);
			p[5] = Connection.GetParameter
				("@MODIFY_USER", Modify_User, ParameterDirection.Output, DbType.AnsiStringFixedLength, Modify_UserMax);

			const string sql = @"
				UPDATE R_SECURITY SET
					MODIFY_DT = @MODIFY_DT,
					SECURITY_FEATURE_CD = @SECURITY_FEATURE_CD,
					SECURITY_GROUP_ID = @SECURITY_GROUP_ID,
					ALLOW_FLG = @ALLOW_FLG
				WHERE
					SECURITY_ID = @SECURITY_ID
				RETURNING
					MODIFY_USER, MODIFY_DT
				INTO
					@MODIFY_USER, @MODIFY_DT";
			int ret = Connection.RunSQL(sql, p);

			Modify_Dt = ClsConvert.ToDateTimeNullable(p[0].Value);
			Modify_User = ClsConvert.ToString(p[5].Value);
			return ret;
		}
		public override int Delete()
		{
			DbParameter[] p = new DbParameter[1];

			p[0] = Connection.GetParameter
				("@SECURITY_ID", Security_ID);

			const string sql = @"
				DELETE FROM R_SECURITY WHERE
				SECURITY_ID=@SECURITY_ID";
			return Connection.RunSQL(sql, p);
		}
		#endregion		// #region Insert, Update, Delete

		#region Conversion methods

		public override void LoadFromDataReader(DbDataReader dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataReader: DataReader parameter was null");

			Security_ID = ClsConvert.ToInt64Nullable(dr["SECURITY_ID"]);
			Create_User = ClsConvert.ToString(dr["CREATE_USER"]);
			Create_Dt = ClsConvert.ToDateTimeNullable(dr["CREATE_DT"]);
			Modify_User = ClsConvert.ToString(dr["MODIFY_USER"]);
			Modify_Dt = ClsConvert.ToDateTimeNullable(dr["MODIFY_DT"]);
			Security_Feature_Cd = ClsConvert.ToString(dr["SECURITY_FEATURE_CD"]);
			Security_Group_ID = ClsConvert.ToInt64Nullable(dr["SECURITY_GROUP_ID"]);
			Allow_Flg = ClsConvert.ToString(dr["ALLOW_FLG"]);
		}

		public override void LoadFromDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataRow: DataRow parameter was null");

			DataRowVersion v = ( dr.RowState == DataRowState.Deleted )
				? DataRowVersion.Original : DataRowVersion.Current;

			Security_ID = ClsConvert.ToInt64Nullable(dr["SECURITY_ID", v]);
			Create_User = ClsConvert.ToString(dr["CREATE_USER", v]);
			Create_Dt = ClsConvert.ToDateTimeNullable(dr["CREATE_DT", v]);
			Modify_User = ClsConvert.ToString(dr["MODIFY_USER", v]);
			Modify_Dt = ClsConvert.ToDateTimeNullable(dr["MODIFY_DT", v]);
			Security_Feature_Cd = ClsConvert.ToString(dr["SECURITY_FEATURE_CD", v]);
			Security_Group_ID = ClsConvert.ToInt64Nullable(dr["SECURITY_GROUP_ID", v]);
			Allow_Flg = ClsConvert.ToString(dr["ALLOW_FLG", v]);
		}

		public override void CopyToDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("CopyToDataRow: DataRow parameter was null");

			dr["SECURITY_ID"] = ClsConvert.ToDbObject(Security_ID);
			dr["CREATE_USER"] = ClsConvert.ToDbObject(Create_User);
			dr["CREATE_DT"] = ClsConvert.ToDbObject(Create_Dt);
			dr["MODIFY_USER"] = ClsConvert.ToDbObject(Modify_User);
			dr["MODIFY_DT"] = ClsConvert.ToDbObject(Modify_Dt);
			dr["SECURITY_FEATURE_CD"] = ClsConvert.ToDbObject(Security_Feature_Cd);
			dr["SECURITY_GROUP_ID"] = ClsConvert.ToDbObject(Security_Group_ID);
			dr["ALLOW_FLG"] = ClsConvert.ToDbObject(Allow_Flg);
		}
		#endregion		// #region Conversion methods

		#region Static Methods

		public static DataTable GetAll()
		{
			return Connection.GetTable(TableName);
		}

		public static DataTable GetAll(bool withJoins)
		{
			if( withJoins == false ) return Connection.GetTable(TableName);

			return Connection.GetDataTable(SelectSQL);
		}

		public static ClsSecurity GetUsingKey(Int64 Security_ID)
		{
			object[] vals = new object[] {Security_ID};
			DataRow dr = Connection.GetDataRowUsingKey
				(TableName, GetPrimaryKeys(), vals);
			return ( dr == null ) ? null : new ClsSecurity(dr);
		}
		public static DataTable GetAll(string Security_Feature_Cd, Int64? Security_Group_ID)
		{
			List<DbParameter> lst = new List<DbParameter>();	
			StringBuilder sb = new StringBuilder();
		
			if( string.IsNullOrEmpty(Security_Feature_Cd) == false )
			{
				lst.Add(Connection.GetParameter("@SECURITY_FEATURE_CD", Security_Feature_Cd));
				sb.Append(" WHERE R_SECURITY.SECURITY_FEATURE_CD=@SECURITY_FEATURE_CD");
			}
			if( Security_Group_ID != null && Security_Group_ID > 0 )
			{
				lst.Add(Connection.GetParameter("@SECURITY_GROUP_ID", Security_Group_ID));
				sb.AppendFormat(" {0} R_SECURITY.SECURITY_GROUP_ID=@SECURITY_GROUP_ID",
					sb.Length > 0 ? "AND" : "WHERE");
			}
			sb.Insert(0, SelectSQL);
			return Connection.GetDataTable(sb.ToString(), lst.ToArray());
		}
		#endregion		// #region Static Methods
	}
}