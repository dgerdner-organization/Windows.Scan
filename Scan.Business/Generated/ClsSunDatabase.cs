using System;
using System.Data;
using System.Text;
using System.Data.Common;
using System.Collections.Generic;
using CS2010.Common;

namespace CS2010.SCAN.Business
{
	public partial class ClsSunDatabase : ClsBaseTable
	{
		#region Connection Manager

		protected static ClsConnection Connection
		{
			get { return ClsConMgr.Manager["SCAN"]; }
		}
		#endregion		// #region Connection Manager

		#region Table Constants

		public const string TableName = "R_SUN_DATABASE";
		public const int PrimaryKeyCount = 1;
		public static bool HasPrimaryKey
		{
			get { return PrimaryKeyCount > 0; }
		}
		public static string[] GetPrimaryKeys()
		{
			return new string[PrimaryKeyCount] { "SUN_DATABASE_CD" };
		}

		public const string SelectSQL = "SELECT * FROM R_SUN_DATABASE";

		#endregion	// #region Table Constants

		#region Column Length Constants
	
		public const int Sun_Database_CdMax = 3;
		public const int Sun_Database_DscMax = 20;
		public const int Active_FlgMax = 1;

		#endregion	// #region Column Length Constants

		#region Column Fields

		protected string _Sun_Database_Cd;
		protected string _Sun_Database_Dsc;
		protected string _Active_Flg;

		#endregion	// #region Column Fields

		#region Column Properties

		public string Sun_Database_Cd
		{
			get { return _Sun_Database_Cd; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Sun_Database_Cd, val, false) == 0 ) return;
		
				if( val != null && val.Length > Sun_Database_CdMax )
					_Sun_Database_Cd = val.Substring(0, (int)Sun_Database_CdMax);
				else
					_Sun_Database_Cd = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Sun_Database_Cd");
			}
		}
		public string Sun_Database_Dsc
		{
			get { return _Sun_Database_Dsc; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Sun_Database_Dsc, val, false) == 0 ) return;
		
				if( val != null && val.Length > Sun_Database_DscMax )
					_Sun_Database_Dsc = val.Substring(0, (int)Sun_Database_DscMax);
				else
					_Sun_Database_Dsc = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Sun_Database_Dsc");
			}
		}
		public string Active_Flg
		{
			get { return _Active_Flg; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Active_Flg, val, false) == 0 ) return;
		
				if( val != null && val.Length > Active_FlgMax )
					_Active_Flg = val.Substring(0, (int)Active_FlgMax);
				else
					_Active_Flg = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Active_Flg");
			}
		}

		#endregion	// #region Column Properties

		#region Foreign Key Fields



		#endregion	// #region Foreign Key Fields

		#region Foreign Key Properties



		#endregion	// #region Foreign Key Properties

		#region Constructors

		public ClsSunDatabase() : base() {}
		public ClsSunDatabase(DataRow dr) : base(dr) {}
		public ClsSunDatabase(ClsSunDatabase src) { CopyFrom(src); }

		#endregion		// #region Constructors

		#region Init methods

		public override void ResetColumns()
		{
			Sun_Database_Cd = null;
			Sun_Database_Dsc = null;
			Active_Flg = null;
		}

		public void CopyFrom(ClsSunDatabase src)
		{
			Sun_Database_Cd = src._Sun_Database_Cd;
			Sun_Database_Dsc = src._Sun_Database_Dsc;
			Active_Flg = src._Active_Flg;
		}

		public override bool ReloadFromDB()
		{
			ClsSunDatabase tmp = ClsSunDatabase.GetUsingKey(Sun_Database_Cd);
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

			DbParameter[] p = new DbParameter[3];

			p[0] = Connection.GetParameter
				("@SUN_DATABASE_CD", Sun_Database_Cd);
			p[1] = Connection.GetParameter
				("@SUN_DATABASE_DSC", Sun_Database_Dsc);
			p[2] = Connection.GetParameter
				("@ACTIVE_FLG", Active_Flg);

			const string sql = @"
				INSERT INTO R_SUN_DATABASE
					(SUN_DATABASE_CD, SUN_DATABASE_DSC, ACTIVE_FLG)
				VALUES
					(@SUN_DATABASE_CD, @SUN_DATABASE_DSC, @ACTIVE_FLG)

					";
			int ret = Connection.RunSQL(sql, p);


			return ret;
		}
		public override int Update()
		{
			DbParameter[] p = new DbParameter[3];

			p[0] = Connection.GetParameter
				("@SUN_DATABASE_DSC", Sun_Database_Dsc);
			p[1] = Connection.GetParameter
				("@ACTIVE_FLG", Active_Flg);
			p[2] = Connection.GetParameter
				("@SUN_DATABASE_CD", Sun_Database_Cd);

			const string sql = @"
				UPDATE R_SUN_DATABASE SET
					SUN_DATABASE_DSC = @SUN_DATABASE_DSC,
					ACTIVE_FLG = @ACTIVE_FLG
				WHERE
					SUN_DATABASE_CD = @SUN_DATABASE_CD
					";
			int ret = Connection.RunSQL(sql, p);


			return ret;
		}
		public override int Delete()
		{
			DbParameter[] p = new DbParameter[1];

			p[0] = Connection.GetParameter
				("@SUN_DATABASE_CD", Sun_Database_Cd);

			const string sql = @"
				DELETE FROM R_SUN_DATABASE WHERE
				SUN_DATABASE_CD=@SUN_DATABASE_CD";
			return Connection.RunSQL(sql, p);
		}
		#endregion		// #region Insert, Update, Delete

		#region Conversion methods

		public override void LoadFromDataReader(DbDataReader dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataReader: DataReader parameter was null");

			Sun_Database_Cd = ClsConvert.ToString(dr["SUN_DATABASE_CD"]);
			Sun_Database_Dsc = ClsConvert.ToString(dr["SUN_DATABASE_DSC"]);
			Active_Flg = ClsConvert.ToString(dr["ACTIVE_FLG"]);
		}

		public override void LoadFromDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataRow: DataRow parameter was null");

			DataRowVersion v = ( dr.RowState == DataRowState.Deleted )
				? DataRowVersion.Original : DataRowVersion.Current;

			Sun_Database_Cd = ClsConvert.ToString(dr["SUN_DATABASE_CD", v]);
			Sun_Database_Dsc = ClsConvert.ToString(dr["SUN_DATABASE_DSC", v]);
			Active_Flg = ClsConvert.ToString(dr["ACTIVE_FLG", v]);
		}

		public override void CopyToDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("CopyToDataRow: DataRow parameter was null");

			dr["SUN_DATABASE_CD"] = ClsConvert.ToDbObject(Sun_Database_Cd);
			dr["SUN_DATABASE_DSC"] = ClsConvert.ToDbObject(Sun_Database_Dsc);
			dr["ACTIVE_FLG"] = ClsConvert.ToDbObject(Active_Flg);
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

		public static ClsSunDatabase GetUsingKey(string Sun_Database_Cd)
		{
			object[] vals = new object[] {Sun_Database_Cd};
			DataRow dr = Connection.GetDataRowUsingKey
				(TableName, GetPrimaryKeys(), vals);
			return ( dr == null ) ? null : new ClsSunDatabase(dr);
		}

		#endregion		// #region Static Methods
	}
}