using System;
using System.Data;
using System.Text;
using System.Data.Common;
using System.Collections.Generic;
using CS2010.Common;

namespace CS2010.SCAN.Business
{
	public partial class ClsSecurityFeature : ClsBaseTable
	{
		#region Connection Manager

		protected static ClsConnection Connection
		{
            get { return ClsConMgr.Manager["SECURITY"]; }
		}
		#endregion		// #region Connection Manager

		#region Table Constants

		public const string TableName = "R_SECURITY_FEATURE";
		public const int PrimaryKeyCount = 1;
		public static bool HasPrimaryKey
		{
			get { return PrimaryKeyCount > 0; }
		}
		public static string[] GetPrimaryKeys()
		{
			return new string[PrimaryKeyCount] { "SECURITY_FEATURE_CD" };
		}

		public const string SelectSQL = "SELECT * FROM R_SECURITY_FEATURE";

		#endregion	// #region Table Constants

		#region Column Length Constants
	
		public const int Security_Feature_CdMax = 20;
		public const int Security_DscMax = 200;

		#endregion	// #region Column Length Constants

		#region Column Fields

		protected string _Security_Feature_Cd;
		protected string _Security_Dsc;

		#endregion	// #region Column Fields

		#region Column Properties

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
		public string Security_Dsc
		{
			get { return _Security_Dsc; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Security_Dsc, val, false) == 0 ) return;
		
				if( val != null && val.Length > Security_DscMax )
					_Security_Dsc = val.Substring(0, (int)Security_DscMax);
				else
					_Security_Dsc = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Security_Dsc");
			}
		}

		#endregion	// #region Column Properties

		#region Foreign Key Fields



		#endregion	// #region Foreign Key Fields

		#region Foreign Key Properties



		#endregion	// #region Foreign Key Properties

		#region Constructors

		public ClsSecurityFeature() : base() {}
		public ClsSecurityFeature(DataRow dr) : base(dr) {}
		public ClsSecurityFeature(ClsSecurityFeature src) { CopyFrom(src); }

		#endregion		// #region Constructors

		#region Init methods

		public override void ResetColumns()
		{
			Security_Feature_Cd = null;
			Security_Dsc = null;
		}

		public void CopyFrom(ClsSecurityFeature src)
		{
			Security_Feature_Cd = src._Security_Feature_Cd;
			Security_Dsc = src._Security_Dsc;
		}

		public override bool ReloadFromDB()
		{
			ClsSecurityFeature tmp = ClsSecurityFeature.GetUsingKey(Security_Feature_Cd);
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
				("@SECURITY_FEATURE_CD", Security_Feature_Cd);
			p[1] = Connection.GetParameter
				("@SECURITY_DSC", Security_Dsc);

			const string sql = @"
				INSERT INTO R_SECURITY_FEATURE
					(SECURITY_FEATURE_CD, SECURITY_DSC)
				VALUES
					(@SECURITY_FEATURE_CD, @SECURITY_DSC)

					";
			int ret = Connection.RunSQL(sql, p);


			return ret;
		}
		public override int Update()
		{
			DbParameter[] p = new DbParameter[2];

			p[0] = Connection.GetParameter
				("@SECURITY_DSC", Security_Dsc);
			p[1] = Connection.GetParameter
				("@SECURITY_FEATURE_CD", Security_Feature_Cd);

			const string sql = @"
				UPDATE R_SECURITY_FEATURE SET
					SECURITY_DSC = @SECURITY_DSC
				WHERE
					SECURITY_FEATURE_CD = @SECURITY_FEATURE_CD
					";
			int ret = Connection.RunSQL(sql, p);


			return ret;
		}
		public override int Delete()
		{
			DbParameter[] p = new DbParameter[1];

			p[0] = Connection.GetParameter
				("@SECURITY_FEATURE_CD", Security_Feature_Cd);

			const string sql = @"
				DELETE FROM R_SECURITY_FEATURE WHERE
				SECURITY_FEATURE_CD=@SECURITY_FEATURE_CD";
			return Connection.RunSQL(sql, p);
		}
		#endregion		// #region Insert, Update, Delete

		#region Conversion methods

		public override void LoadFromDataReader(DbDataReader dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataReader: DataReader parameter was null");

			Security_Feature_Cd = ClsConvert.ToString(dr["SECURITY_FEATURE_CD"]);
			Security_Dsc = ClsConvert.ToString(dr["SECURITY_DSC"]);
		}

		public override void LoadFromDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataRow: DataRow parameter was null");

			DataRowVersion v = ( dr.RowState == DataRowState.Deleted )
				? DataRowVersion.Original : DataRowVersion.Current;

			Security_Feature_Cd = ClsConvert.ToString(dr["SECURITY_FEATURE_CD", v]);
			Security_Dsc = ClsConvert.ToString(dr["SECURITY_DSC", v]);
		}

		public override void CopyToDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("CopyToDataRow: DataRow parameter was null");

			dr["SECURITY_FEATURE_CD"] = ClsConvert.ToDbObject(Security_Feature_Cd);
			dr["SECURITY_DSC"] = ClsConvert.ToDbObject(Security_Dsc);
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

		public static ClsSecurityFeature GetUsingKey(string Security_Feature_Cd)
		{
			object[] vals = new object[] {Security_Feature_Cd};
			DataRow dr = Connection.GetDataRowUsingKey
				(TableName, GetPrimaryKeys(), vals);
			return ( dr == null ) ? null : new ClsSecurityFeature(dr);
		}

		#endregion		// #region Static Methods
	}
}