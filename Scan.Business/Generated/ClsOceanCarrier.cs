using System;
using System.Data;
using System.Text;
using System.Data.Common;
using System.Collections.Generic;
using CS2010.Common;

namespace CS2010.SCAN.Business
{
	public partial class ClsOceanCarrier : ClsBaseTable
	{
		#region Connection Manager

		protected static ClsConnection Connection
		{
			get { return ClsConMgr.Manager["SCAN"]; }
		}
		#endregion		// #region Connection Manager

		#region Table Constants

		public const string TableName = "R_OCEAN_CARRIER";
		public const int PrimaryKeyCount = 1;
		public static bool HasPrimaryKey
		{
			get { return PrimaryKeyCount > 0; }
		}
		public static string[] GetPrimaryKeys()
		{
			return new string[PrimaryKeyCount] { "OCEAN_CARRIER_CD" };
		}

		public const string SelectSQL = "SELECT * FROM R_OCEAN_CARRIER";

		#endregion	// #region Table Constants

		#region Column Length Constants
	
		public const int Ocean_Carrier_CdMax = 10;
		public const int Ocean_Carrier_DscMax = 20;
		public const int Active_FlgMax = 1;

		#endregion	// #region Column Length Constants

		#region Column Fields

		protected string _Ocean_Carrier_Cd;
		protected string _Ocean_Carrier_Dsc;
		protected string _Active_Flg;

		#endregion	// #region Column Fields

		#region Column Properties

		public string Ocean_Carrier_Cd
		{
			get { return _Ocean_Carrier_Cd; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Ocean_Carrier_Cd, val, false) == 0 ) return;
		
				if( val != null && val.Length > Ocean_Carrier_CdMax )
					_Ocean_Carrier_Cd = val.Substring(0, (int)Ocean_Carrier_CdMax);
				else
					_Ocean_Carrier_Cd = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Ocean_Carrier_Cd");
			}
		}
		public string Ocean_Carrier_Dsc
		{
			get { return _Ocean_Carrier_Dsc; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Ocean_Carrier_Dsc, val, false) == 0 ) return;
		
				if( val != null && val.Length > Ocean_Carrier_DscMax )
					_Ocean_Carrier_Dsc = val.Substring(0, (int)Ocean_Carrier_DscMax);
				else
					_Ocean_Carrier_Dsc = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Ocean_Carrier_Dsc");
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

		public ClsOceanCarrier() : base() {}
		public ClsOceanCarrier(DataRow dr) : base(dr) {}
		public ClsOceanCarrier(ClsOceanCarrier src) { CopyFrom(src); }

		#endregion		// #region Constructors

		#region Init methods

		public override void ResetColumns()
		{
			Ocean_Carrier_Cd = null;
			Ocean_Carrier_Dsc = null;
			Active_Flg = null;
		}

		public void CopyFrom(ClsOceanCarrier src)
		{
			Ocean_Carrier_Cd = src._Ocean_Carrier_Cd;
			Ocean_Carrier_Dsc = src._Ocean_Carrier_Dsc;
			Active_Flg = src._Active_Flg;
		}

		public override bool ReloadFromDB()
		{
			ClsOceanCarrier tmp = ClsOceanCarrier.GetUsingKey(Ocean_Carrier_Cd);
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
				("@OCEAN_CARRIER_CD", Ocean_Carrier_Cd);
			p[1] = Connection.GetParameter
				("@OCEAN_CARRIER_DSC", Ocean_Carrier_Dsc);
			p[2] = Connection.GetParameter
				("@ACTIVE_FLG", Active_Flg);

			const string sql = @"
				INSERT INTO R_OCEAN_CARRIER
					(OCEAN_CARRIER_CD, OCEAN_CARRIER_DSC, ACTIVE_FLG)
				VALUES
					(@OCEAN_CARRIER_CD, @OCEAN_CARRIER_DSC, @ACTIVE_FLG)
					";
			int ret = Connection.RunSQL(sql, p);


			return ret;
		}
		public override int Update()
		{
			DbParameter[] p = new DbParameter[3];

			p[0] = Connection.GetParameter
				("@OCEAN_CARRIER_DSC", Ocean_Carrier_Dsc);
			p[1] = Connection.GetParameter
				("@ACTIVE_FLG", Active_Flg);
			p[2] = Connection.GetParameter
				("@OCEAN_CARRIER_CD", Ocean_Carrier_Cd);

			const string sql = @"
				UPDATE R_OCEAN_CARRIER SET
					OCEAN_CARRIER_DSC = @OCEAN_CARRIER_DSC,
					ACTIVE_FLG = @ACTIVE_FLG
				WHERE
					OCEAN_CARRIER_CD = @OCEAN_CARRIER_CD
					";
			int ret = Connection.RunSQL(sql, p);


			return ret;
		}
		public override int Delete()
		{
			DbParameter[] p = new DbParameter[1];

			p[0] = Connection.GetParameter
				("@OCEAN_CARRIER_CD", Ocean_Carrier_Cd);

			const string sql = @"
				DELETE FROM R_OCEAN_CARRIER WHERE
				OCEAN_CARRIER_CD=@OCEAN_CARRIER_CD";
			return Connection.RunSQL(sql, p);
		}
		#endregion		// #region Insert, Update, Delete

		#region Conversion methods

		public override void LoadFromDataReader(DbDataReader dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataReader: DataReader parameter was null");

			Ocean_Carrier_Cd = ClsConvert.ToString(dr["OCEAN_CARRIER_CD"]);
			Ocean_Carrier_Dsc = ClsConvert.ToString(dr["OCEAN_CARRIER_DSC"]);
			Active_Flg = ClsConvert.ToString(dr["ACTIVE_FLG"]);
		}

		public override void LoadFromDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataRow: DataRow parameter was null");

			DataRowVersion v = ( dr.RowState == DataRowState.Deleted )
				? DataRowVersion.Original : DataRowVersion.Current;

			Ocean_Carrier_Cd = ClsConvert.ToString(dr["OCEAN_CARRIER_CD", v]);
			Ocean_Carrier_Dsc = ClsConvert.ToString(dr["OCEAN_CARRIER_DSC", v]);
			Active_Flg = ClsConvert.ToString(dr["ACTIVE_FLG", v]);
		}

		public override void CopyToDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("CopyToDataRow: DataRow parameter was null");

			dr["OCEAN_CARRIER_CD"] = ClsConvert.ToDbObject(Ocean_Carrier_Cd);
			dr["OCEAN_CARRIER_DSC"] = ClsConvert.ToDbObject(Ocean_Carrier_Dsc);
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

		public static ClsOceanCarrier GetUsingKey(string Ocean_Carrier_Cd)
		{
			object[] vals = new object[] {Ocean_Carrier_Cd};
			DataRow dr = Connection.GetDataRowUsingKey
				(TableName, GetPrimaryKeys(), vals);
			return ( dr == null ) ? null : new ClsOceanCarrier(dr);
		}

		#endregion		// #region Static Methods
	}
}