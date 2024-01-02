using System;
using System.Data;
using System.Text;
using System.Data.Common;
using System.Collections.Generic;
using CS2010.Common;

namespace CS2010.SCAN.Business
{
	public partial class ClsSecurityGroup : ClsBaseTable
	{
		#region Connection Manager

		protected static ClsConnection Connection
		{
            get { return ClsConMgr.Manager["SECURITY"]; }
		}
		#endregion		// #region Connection Manager

		#region Table Constants

		public const string TableName = "R_SECURITY_GROUP";
		public const int PrimaryKeyCount = 1;
		public static bool HasPrimaryKey
		{
			get { return PrimaryKeyCount > 0; }
		}
		public static string[] GetPrimaryKeys()
		{
			return new string[PrimaryKeyCount] { "SECURITY_GROUP_ID" };
		}

		public const string SelectSQL = "SELECT * FROM R_SECURITY_GROUP";

		#endregion	// #region Table Constants

		#region Column Length Constants
	
		public const int Security_Group_DscMax = 50;

		#endregion	// #region Column Length Constants

		#region Column Fields

		protected Int64? _Security_Group_ID;
		protected string _Security_Group_Dsc;

		#endregion	// #region Column Fields

		#region Column Properties

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
		public string Security_Group_Dsc
		{
			get { return _Security_Group_Dsc; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Security_Group_Dsc, val, false) == 0 ) return;
		
				if( val != null && val.Length > Security_Group_DscMax )
					_Security_Group_Dsc = val.Substring(0, (int)Security_Group_DscMax);
				else
					_Security_Group_Dsc = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Security_Group_Dsc");
			}
		}

		#endregion	// #region Column Properties

		#region Foreign Key Fields



		#endregion	// #region Foreign Key Fields

		#region Foreign Key Properties



		#endregion	// #region Foreign Key Properties

		#region Constructors

		public ClsSecurityGroup() : base() {}
		public ClsSecurityGroup(DataRow dr) : base(dr) {}
		public ClsSecurityGroup(ClsSecurityGroup src) { CopyFrom(src); }

		#endregion		// #region Constructors

		#region Init methods

		public override void ResetColumns()
		{
			Security_Group_ID = null;
			Security_Group_Dsc = null;
		}

		public void CopyFrom(ClsSecurityGroup src)
		{
			Security_Group_ID = src._Security_Group_ID;
			Security_Group_Dsc = src._Security_Group_Dsc;
		}

		public override bool ReloadFromDB()
		{
			ClsSecurityGroup tmp = ClsSecurityGroup.GetUsingKey(Security_Group_ID.Value);
			if( tmp != null ) CopyFrom(tmp);

			ResetFKs();
			OnReload();

			return ( tmp != null );
		}

		public override void ResetFKs()
		{

		}
		#endregion		// #region Init methods

		#region Insert, Update, Delete

		public override int Insert()
		{

			DbParameter[] p = new DbParameter[2];

			p[0] = Connection.GetParameter
				("@SECURITY_GROUP_DSC", Security_Group_Dsc);
			p[1] = Connection.GetParameter
				("@SECURITY_GROUP_ID", Security_Group_ID, ParameterDirection.Output, DbType.Int64, 0);

			const string sql = @"
				INSERT INTO R_SECURITY_GROUP
					(SECURITY_GROUP_ID, SECURITY_GROUP_DSC)
				VALUES
					(SECURITY_GROUP_ID_SEQ.NEXTVAL, @SECURITY_GROUP_DSC)
				RETURNING
					SECURITY_GROUP_ID
				INTO
					@SECURITY_GROUP_ID";
			int ret = Connection.RunSQL(sql, p);

			Security_Group_ID = ClsConvert.ToInt64Nullable(p[1].Value);
			return ret;
		}
		public override int Update()
		{
			DbParameter[] p = new DbParameter[2];

			p[0] = Connection.GetParameter
				("@SECURITY_GROUP_DSC", Security_Group_Dsc);
			p[1] = Connection.GetParameter
				("@SECURITY_GROUP_ID", Security_Group_ID);

			const string sql = @"
				UPDATE R_SECURITY_GROUP SET
					SECURITY_GROUP_DSC = @SECURITY_GROUP_DSC
				WHERE
					SECURITY_GROUP_ID = @SECURITY_GROUP_ID
					";
			int ret = Connection.RunSQL(sql, p);


			return ret;
		}
		public override int Delete()
		{
			DbParameter[] p = new DbParameter[1];

			p[0] = Connection.GetParameter
				("@SECURITY_GROUP_ID", Security_Group_ID);

			const string sql = @"
				DELETE FROM R_SECURITY_GROUP WHERE
				SECURITY_GROUP_ID=@SECURITY_GROUP_ID";
			return Connection.RunSQL(sql, p);
		}
		#endregion		// #region Insert, Update, Delete

		#region Conversion methods

		public override void LoadFromDataReader(DbDataReader dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataReader: DataReader parameter was null");

			Security_Group_ID = ClsConvert.ToInt64Nullable(dr["SECURITY_GROUP_ID"]);
			Security_Group_Dsc = ClsConvert.ToString(dr["SECURITY_GROUP_DSC"]);
		}

		public override void LoadFromDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataRow: DataRow parameter was null");

			DataRowVersion v = ( dr.RowState == DataRowState.Deleted )
				? DataRowVersion.Original : DataRowVersion.Current;

			Security_Group_ID = ClsConvert.ToInt64Nullable(dr["SECURITY_GROUP_ID", v]);
			Security_Group_Dsc = ClsConvert.ToString(dr["SECURITY_GROUP_DSC", v]);
		}

		public override void CopyToDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("CopyToDataRow: DataRow parameter was null");

			dr["SECURITY_GROUP_ID"] = ClsConvert.ToDbObject(Security_Group_ID);
			dr["SECURITY_GROUP_DSC"] = ClsConvert.ToDbObject(Security_Group_Dsc);
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

		public static ClsSecurityGroup GetUsingKey(Int64 Security_Group_ID)
		{
			object[] vals = new object[] {Security_Group_ID};
			DataRow dr = Connection.GetDataRowUsingKey
				(TableName, GetPrimaryKeys(), vals);
			return ( dr == null ) ? null : new ClsSecurityGroup(dr);
		}

		#endregion		// #region Static Methods
	}
}