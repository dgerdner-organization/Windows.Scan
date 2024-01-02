using System;
using System.Data;
using System.Text;
using System.Data.Common;
using System.Collections.Generic;
using CS2010.Common;

namespace CS2010.SCAN.Business
{
	public partial class ClsOffice : ClsBaseTable
	{
		#region Connection Manager

		protected static ClsConnection Connection
		{
			get { return ClsConMgr.Manager["SCAN"]; }
		}
		#endregion		// #region Connection Manager

		#region Table Constants

		public const string TableName = "R_OFFICE";
		public const int PrimaryKeyCount = 1;
		public static bool HasPrimaryKey
		{
			get { return PrimaryKeyCount > 0; }
		}
		public static string[] GetPrimaryKeys()
		{
			return new string[PrimaryKeyCount] { "OFFICE_CD" };
		}

		public const string SelectSQL = "SELECT * FROM R_OFFICE";

		#endregion	// #region Table Constants

		#region Column Length Constants
	
		public const int Office_CdMax = 3;
		public const int Office_DscMax = 20;
		public const int Active_FlgMax = 1;

		#endregion	// #region Column Length Constants

		#region Column Fields

		protected string _Office_Cd;
		protected string _Office_Dsc;
		protected string _Active_Flg;

		#endregion	// #region Column Fields

		#region Column Properties

		public string Office_Cd
		{
			get { return _Office_Cd; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Office_Cd, val, false) == 0 ) return;
		
				if( val != null && val.Length > Office_CdMax )
					_Office_Cd = val.Substring(0, (int)Office_CdMax);
				else
					_Office_Cd = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Office_Cd");
			}
		}
		public string Office_Dsc
		{
			get { return _Office_Dsc; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Office_Dsc, val, false) == 0 ) return;
		
				if( val != null && val.Length > Office_DscMax )
					_Office_Dsc = val.Substring(0, (int)Office_DscMax);
				else
					_Office_Dsc = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Office_Dsc");
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

		public ClsOffice() : base() {}
		public ClsOffice(DataRow dr) : base(dr) {}
		public ClsOffice(ClsOffice src) { CopyFrom(src); }

		#endregion		// #region Constructors

		#region Init methods

		public override void ResetColumns()
		{
			Office_Cd = null;
			Office_Dsc = null;
			Active_Flg = null;
		}

		public void CopyFrom(ClsOffice src)
		{
			Office_Cd = src._Office_Cd;
			Office_Dsc = src._Office_Dsc;
			Active_Flg = src._Active_Flg;
		}

		public override bool ReloadFromDB()
		{
			ClsOffice tmp = ClsOffice.GetUsingKey(Office_Cd);
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
				("@OFFICE_CD", Office_Cd);
			p[1] = Connection.GetParameter
				("@OFFICE_DSC", Office_Dsc);
			p[2] = Connection.GetParameter
				("@ACTIVE_FLG", Active_Flg);

			const string sql = @"
				INSERT INTO R_OFFICE
					(OFFICE_CD, OFFICE_DSC, ACTIVE_FLG)
				VALUES
					(@OFFICE_CD, @OFFICE_DSC, @ACTIVE_FLG)
					";
			int ret = Connection.RunSQL(sql, p);


			return ret;
		}
		public override int Update()
		{
			DbParameter[] p = new DbParameter[3];

			p[0] = Connection.GetParameter
				("@OFFICE_DSC", Office_Dsc);
			p[1] = Connection.GetParameter
				("@ACTIVE_FLG", Active_Flg);
			p[2] = Connection.GetParameter
				("@OFFICE_CD", Office_Cd);

			const string sql = @"
				UPDATE R_OFFICE SET
					OFFICE_DSC = @OFFICE_DSC,
					ACTIVE_FLG = @ACTIVE_FLG
				WHERE
					OFFICE_CD = @OFFICE_CD
					";
			int ret = Connection.RunSQL(sql, p);


			return ret;
		}
		public override int Delete()
		{
			DbParameter[] p = new DbParameter[1];

			p[0] = Connection.GetParameter
				("@OFFICE_CD", Office_Cd);

			const string sql = @"
				DELETE FROM R_OFFICE WHERE
				OFFICE_CD=@OFFICE_CD";
			return Connection.RunSQL(sql, p);
		}
		#endregion		// #region Insert, Update, Delete

		#region Conversion methods

		public override void LoadFromDataReader(DbDataReader dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataReader: DataReader parameter was null");

			Office_Cd = ClsConvert.ToString(dr["OFFICE_CD"]);
			Office_Dsc = ClsConvert.ToString(dr["OFFICE_DSC"]);
			Active_Flg = ClsConvert.ToString(dr["ACTIVE_FLG"]);
		}

		public override void LoadFromDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataRow: DataRow parameter was null");

			DataRowVersion v = ( dr.RowState == DataRowState.Deleted )
				? DataRowVersion.Original : DataRowVersion.Current;

			Office_Cd = ClsConvert.ToString(dr["OFFICE_CD", v]);
			Office_Dsc = ClsConvert.ToString(dr["OFFICE_DSC", v]);
			Active_Flg = ClsConvert.ToString(dr["ACTIVE_FLG", v]);
		}

		public override void CopyToDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("CopyToDataRow: DataRow parameter was null");

			dr["OFFICE_CD"] = ClsConvert.ToDbObject(Office_Cd);
			dr["OFFICE_DSC"] = ClsConvert.ToDbObject(Office_Dsc);
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

		public static ClsOffice GetUsingKey(string Office_Cd)
		{
			object[] vals = new object[] {Office_Cd};
			DataRow dr = Connection.GetDataRowUsingKey
				(TableName, GetPrimaryKeys(), vals);
			return ( dr == null ) ? null : new ClsOffice(dr);
		}

		#endregion		// #region Static Methods
	}
}