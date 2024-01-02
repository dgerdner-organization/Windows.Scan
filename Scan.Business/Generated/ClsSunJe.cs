using System;
using System.Data;
using System.Text;
using System.Data.Common;
using System.Collections.Generic;
using CS2010.Common;

namespace CS2010.SCAN.Business
{
	public partial class ClsSunJe : ClsBaseTable
	{
		#region Connection Manager

		protected static ClsConnection Connection
		{
			get { return ClsConMgr.Manager["SCAN"]; }
		}
		#endregion		// #region Connection Manager

		#region Table Constants

		public const string TableName = "T_SUN_JE";
		public const int PrimaryKeyCount = 1;
		public static bool HasPrimaryKey
		{
			get { return PrimaryKeyCount > 0; }
		}
		public static string[] GetPrimaryKeys()
		{
			return new string[PrimaryKeyCount] { "SUN_JE_ID" };
		}

		public const string SelectSQL = @"SELECT * FROM T_SUN_JE 
				INNER JOIN R_OFFICE
				ON T_SUN_JE.OFFICE_CD=R_OFFICE.OFFICE_CD ";

		#endregion	// #region Table Constants

		#region Column Length Constants
	
		public const int Create_UserMax = 30;
		public const int Modify_UserMax = 30;
		public const int Active_FlgMax = 1;
		public const int Office_CdMax = 3;
		public const int Database_CodeMax = 50;
		public const int Journal_NoMax = 50;
		public const int Accounting_PeriodMax = 50;
		public const int Journal_SourceMax = 50;
		public const int Journal_TypeMax = 50;
		public const int Matched_FlgMax = 1;

		#endregion	// #region Column Length Constants

		#region Column Fields

		protected Int64? _Sun_Je_ID;
		protected string _Create_User;
		protected DateTime? _Create_Dt;
		protected string _Modify_User;
		protected DateTime? _Modify_Dt;
		protected string _Active_Flg;
		protected string _Office_Cd;
		protected string _Database_Code;
		protected DateTime? _Entry_Dt;
		protected string _Journal_No;
		protected string _Accounting_Period;
		protected string _Journal_Source;
		protected string _Journal_Type;
		protected Int32? _Sun_Version_No;
		protected string _Matched_Flg;

		#endregion	// #region Column Fields

		#region Column Properties

		public Int64? Sun_Je_ID
		{
			get { return _Sun_Je_ID; }
			set
			{
				if( _Sun_Je_ID == value ) return;
		
				_Sun_Je_ID = value;
				_IsDirty = true;
				NotifyPropertyChanged("Sun_Je_ID");
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
		public string Database_Code
		{
			get { return _Database_Code; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Database_Code, val, false) == 0 ) return;
		
				if( val != null && val.Length > Database_CodeMax )
					_Database_Code = val.Substring(0, (int)Database_CodeMax);
				else
					_Database_Code = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Database_Code");
			}
		}
		public DateTime? Entry_Dt
		{
			get { return _Entry_Dt; }
			set
			{
				DateTime? val = ( value != null )
					? (DateTime?)value.Value.Date : null;
		
				if( _Entry_Dt == val ) return;
		
				_Entry_Dt = val;
				_IsDirty = true;
				NotifyPropertyChanged("Entry_Dt");
			}
		}
		public string Journal_No
		{
			get { return _Journal_No; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Journal_No, val, false) == 0 ) return;
		
				if( val != null && val.Length > Journal_NoMax )
					_Journal_No = val.Substring(0, (int)Journal_NoMax);
				else
					_Journal_No = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Journal_No");
			}
		}
		public string Accounting_Period
		{
			get { return _Accounting_Period; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Accounting_Period, val, false) == 0 ) return;
		
				if( val != null && val.Length > Accounting_PeriodMax )
					_Accounting_Period = val.Substring(0, (int)Accounting_PeriodMax);
				else
					_Accounting_Period = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Accounting_Period");
			}
		}
		public string Journal_Source
		{
			get { return _Journal_Source; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Journal_Source, val, false) == 0 ) return;
		
				if( val != null && val.Length > Journal_SourceMax )
					_Journal_Source = val.Substring(0, (int)Journal_SourceMax);
				else
					_Journal_Source = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Journal_Source");
			}
		}
		public string Journal_Type
		{
			get { return _Journal_Type; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Journal_Type, val, false) == 0 ) return;
		
				if( val != null && val.Length > Journal_TypeMax )
					_Journal_Type = val.Substring(0, (int)Journal_TypeMax);
				else
					_Journal_Type = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Journal_Type");
			}
		}
		public Int32? Sun_Version_No
		{
			get { return _Sun_Version_No; }
			set
			{
				if( _Sun_Version_No == value ) return;
		
				_Sun_Version_No = value;
				_IsDirty = true;
				NotifyPropertyChanged("Sun_Version_No");
			}
		}
		public string Matched_Flg
		{
			get { return _Matched_Flg; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Matched_Flg, val, false) == 0 ) return;
		
				if( val != null && val.Length > Matched_FlgMax )
					_Matched_Flg = val.Substring(0, (int)Matched_FlgMax);
				else
					_Matched_Flg = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Matched_Flg");
			}
		}

		#endregion	// #region Column Properties

		#region Foreign Key Fields

		protected ClsOffice _Office;

		#endregion	// #region Foreign Key Fields

		#region Foreign Key Properties

		public ClsOffice Office
		{
			get
			{
				if( Office_Cd == null )
					_Office = null;
				else if( _Office == null ||
					_Office.Office_Cd != Office_Cd )
					_Office = ClsOffice.GetUsingKey(Office_Cd);
				return _Office;
			}
			set
			{
				if( _Office == value ) return;
		
				_Office = value;
			}
		}

		#endregion	// #region Foreign Key Properties

		#region Constructors

		public ClsSunJe() : base() {}
		public ClsSunJe(DataRow dr) : base(dr) {}
		public ClsSunJe(ClsSunJe src) { CopyFrom(src); }

		#endregion		// #region Constructors

		#region Init methods

		public override void ResetColumns()
		{
			Sun_Je_ID = null;
			Create_User = null;
			Create_Dt = null;
			Modify_User = null;
			Modify_Dt = null;
			Active_Flg = null;
			Office_Cd = null;
			Database_Code = null;
			Entry_Dt = null;
			Journal_No = null;
			Accounting_Period = null;
			Journal_Source = null;
			Journal_Type = null;
			Sun_Version_No = null;
			Matched_Flg = null;
		}

		public void CopyFrom(ClsSunJe src)
		{
			Sun_Je_ID = src._Sun_Je_ID;
			Create_User = src._Create_User;
			Create_Dt = src._Create_Dt;
			Modify_User = src._Modify_User;
			Modify_Dt = src._Modify_Dt;
			Active_Flg = src._Active_Flg;
			Office_Cd = src._Office_Cd;
			Database_Code = src._Database_Code;
			Entry_Dt = src._Entry_Dt;
			Journal_No = src._Journal_No;
			Accounting_Period = src._Accounting_Period;
			Journal_Source = src._Journal_Source;
			Journal_Type = src._Journal_Type;
			Sun_Version_No = src._Sun_Version_No;
			Matched_Flg = src._Matched_Flg;
		}

		public override bool ReloadFromDB()
		{
			ClsSunJe tmp = ClsSunJe.GetUsingKey(Sun_Je_ID.Value);
			if( tmp != null ) CopyFrom(tmp);

			ResetFKs();
			OnReload();

			return ( tmp != null );
		}

		public override void ResetFKs()
		{
			_Office = null;
		}
		#endregion		// #region Init methods

		#region Insert, Update, Delete

		public override int Insert()
		{

			DbParameter[] p = new DbParameter[15];

			p[0] = Connection.GetParameter
				("@ACTIVE_FLG", Active_Flg);
			p[1] = Connection.GetParameter
				("@OFFICE_CD", Office_Cd);
			p[2] = Connection.GetParameter
				("@DATABASE_CODE", Database_Code);
			p[3] = Connection.GetParameter
				("@ENTRY_DT", Entry_Dt);
			p[4] = Connection.GetParameter
				("@JOURNAL_NO", Journal_No);
			p[5] = Connection.GetParameter
				("@ACCOUNTING_PERIOD", Accounting_Period);
			p[6] = Connection.GetParameter
				("@JOURNAL_SOURCE", Journal_Source);
			p[7] = Connection.GetParameter
				("@JOURNAL_TYPE", Journal_Type);
			p[8] = Connection.GetParameter
				("@SUN_VERSION_NO", Sun_Version_No);
			p[9] = Connection.GetParameter
				("@MATCHED_FLG", Matched_Flg);
			p[10] = Connection.GetParameter
				("@SUN_JE_ID", Sun_Je_ID, ParameterDirection.Output, DbType.Int64, 0);
			p[11] = Connection.GetParameter
				("@CREATE_USER", Create_User, ParameterDirection.Output, DbType.AnsiStringFixedLength, Create_UserMax);
			p[12] = Connection.GetParameter
				("@CREATE_DT", Create_Dt, ParameterDirection.Output, DbType.DateTime, 0);
			p[13] = Connection.GetParameter
				("@MODIFY_USER", Modify_User, ParameterDirection.Output, DbType.AnsiStringFixedLength, Modify_UserMax);
			p[14] = Connection.GetParameter
				("@MODIFY_DT", Modify_Dt, ParameterDirection.Output, DbType.DateTime, 0);

			const string sql = @"
				INSERT INTO T_SUN_JE
					(SUN_JE_ID, ACTIVE_FLG, OFFICE_CD,
					DATABASE_CODE, ENTRY_DT, JOURNAL_NO,
					ACCOUNTING_PERIOD, JOURNAL_SOURCE, JOURNAL_TYPE,
					SUN_VERSION_NO, MATCHED_FLG)
				VALUES
					(SUN_JE_ID_SEQ.NEXTVAL, @ACTIVE_FLG, @OFFICE_CD,
					@DATABASE_CODE, @ENTRY_DT, @JOURNAL_NO,
					@ACCOUNTING_PERIOD, @JOURNAL_SOURCE, @JOURNAL_TYPE,
					@SUN_VERSION_NO, @MATCHED_FLG)
				RETURNING
					SUN_JE_ID, CREATE_USER, CREATE_DT,
					MODIFY_USER, MODIFY_DT
				INTO
					@SUN_JE_ID, @CREATE_USER, @CREATE_DT,
					@MODIFY_USER, @MODIFY_DT";
			int ret = Connection.RunSQL(sql, p);

			Sun_Je_ID = ClsConvert.ToInt64Nullable(p[10].Value);
			Create_User = ClsConvert.ToString(p[11].Value);
			Create_Dt = ClsConvert.ToDateTimeNullable(p[12].Value);
			Modify_User = ClsConvert.ToString(p[13].Value);
			Modify_Dt = ClsConvert.ToDateTimeNullable(p[14].Value);
			return ret;
		}
		public override int Update()
		{
			DbParameter[] p = new DbParameter[13];

			p[0] = Connection.GetParameter
				("@MODIFY_DT", Modify_Dt, ParameterDirection.InputOutput, DbType.DateTime, 0);
			p[1] = Connection.GetParameter
				("@ACTIVE_FLG", Active_Flg);
			p[2] = Connection.GetParameter
				("@OFFICE_CD", Office_Cd);
			p[3] = Connection.GetParameter
				("@DATABASE_CODE", Database_Code);
			p[4] = Connection.GetParameter
				("@ENTRY_DT", Entry_Dt);
			p[5] = Connection.GetParameter
				("@JOURNAL_NO", Journal_No);
			p[6] = Connection.GetParameter
				("@ACCOUNTING_PERIOD", Accounting_Period);
			p[7] = Connection.GetParameter
				("@JOURNAL_SOURCE", Journal_Source);
			p[8] = Connection.GetParameter
				("@JOURNAL_TYPE", Journal_Type);
			p[9] = Connection.GetParameter
				("@SUN_VERSION_NO", Sun_Version_No);
			p[10] = Connection.GetParameter
				("@MATCHED_FLG", Matched_Flg);
			p[11] = Connection.GetParameter
				("@SUN_JE_ID", Sun_Je_ID);
			p[12] = Connection.GetParameter
				("@MODIFY_USER", Modify_User, ParameterDirection.Output, DbType.AnsiStringFixedLength, Modify_UserMax);

			const string sql = @"
				UPDATE T_SUN_JE SET
					MODIFY_DT = @MODIFY_DT,
					ACTIVE_FLG = @ACTIVE_FLG,
					OFFICE_CD = @OFFICE_CD,
					DATABASE_CODE = @DATABASE_CODE,
					ENTRY_DT = @ENTRY_DT,
					JOURNAL_NO = @JOURNAL_NO,
					ACCOUNTING_PERIOD = @ACCOUNTING_PERIOD,
					JOURNAL_SOURCE = @JOURNAL_SOURCE,
					JOURNAL_TYPE = @JOURNAL_TYPE,
					SUN_VERSION_NO = @SUN_VERSION_NO,
					MATCHED_FLG = @MATCHED_FLG
				WHERE
					SUN_JE_ID = @SUN_JE_ID
				RETURNING
					MODIFY_USER, MODIFY_DT
				INTO
					@MODIFY_USER, @MODIFY_DT";
			int ret = Connection.RunSQL(sql, p);

			Modify_Dt = ClsConvert.ToDateTimeNullable(p[0].Value);
			Modify_User = ClsConvert.ToString(p[12].Value);
			return ret;
		}
		public override int Delete()
		{
            DbParameter[] p = new DbParameter[1];

            p[0] = Connection.GetParameter
                ("@SUN_JE_ID", Sun_Je_ID);

            const string sql = @"
				DELETE FROM T_SUN_JE WHERE
				SUN_JE_ID=@SUN_JE_ID";

            return Connection.RunSQL(sql, p);

    	}
		#endregion		// #region Insert, Update, Delete

		#region Conversion methods

		public override void LoadFromDataReader(DbDataReader dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataReader: DataReader parameter was null");

			Sun_Je_ID = ClsConvert.ToInt64Nullable(dr["SUN_JE_ID"]);
			Create_User = ClsConvert.ToString(dr["CREATE_USER"]);
			Create_Dt = ClsConvert.ToDateTimeNullable(dr["CREATE_DT"]);
			Modify_User = ClsConvert.ToString(dr["MODIFY_USER"]);
			Modify_Dt = ClsConvert.ToDateTimeNullable(dr["MODIFY_DT"]);
			Active_Flg = ClsConvert.ToString(dr["ACTIVE_FLG"]);
			Office_Cd = ClsConvert.ToString(dr["OFFICE_CD"]);
			Database_Code = ClsConvert.ToString(dr["DATABASE_CODE"]);
			Entry_Dt = ClsConvert.ToDateTimeNullable(dr["ENTRY_DT"]);
			Journal_No = ClsConvert.ToString(dr["JOURNAL_NO"]);
			Accounting_Period = ClsConvert.ToString(dr["ACCOUNTING_PERIOD"]);
			Journal_Source = ClsConvert.ToString(dr["JOURNAL_SOURCE"]);
			Journal_Type = ClsConvert.ToString(dr["JOURNAL_TYPE"]);
			Sun_Version_No = ClsConvert.ToInt32Nullable(dr["SUN_VERSION_NO"]);
			Matched_Flg = ClsConvert.ToString(dr["MATCHED_FLG"]);
		}

		public override void LoadFromDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataRow: DataRow parameter was null");

			DataRowVersion v = ( dr.RowState == DataRowState.Deleted )
				? DataRowVersion.Original : DataRowVersion.Current;

			Sun_Je_ID = ClsConvert.ToInt64Nullable(dr["SUN_JE_ID", v]);
			Create_User = ClsConvert.ToString(dr["CREATE_USER", v]);
			Create_Dt = ClsConvert.ToDateTimeNullable(dr["CREATE_DT", v]);
			Modify_User = ClsConvert.ToString(dr["MODIFY_USER", v]);
			Modify_Dt = ClsConvert.ToDateTimeNullable(dr["MODIFY_DT", v]);
			Active_Flg = ClsConvert.ToString(dr["ACTIVE_FLG", v]);
			Office_Cd = ClsConvert.ToString(dr["OFFICE_CD", v]);
			Database_Code = ClsConvert.ToString(dr["DATABASE_CODE", v]);
			Entry_Dt = ClsConvert.ToDateTimeNullable(dr["ENTRY_DT", v]);
			Journal_No = ClsConvert.ToString(dr["JOURNAL_NO", v]);
			Accounting_Period = ClsConvert.ToString(dr["ACCOUNTING_PERIOD", v]);
			Journal_Source = ClsConvert.ToString(dr["JOURNAL_SOURCE", v]);
			Journal_Type = ClsConvert.ToString(dr["JOURNAL_TYPE", v]);
			Sun_Version_No = ClsConvert.ToInt32Nullable(dr["SUN_VERSION_NO", v]);
			Matched_Flg = ClsConvert.ToString(dr["MATCHED_FLG", v]);
		}

		public override void CopyToDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("CopyToDataRow: DataRow parameter was null");

			dr["SUN_JE_ID"] = ClsConvert.ToDbObject(Sun_Je_ID);
			dr["CREATE_USER"] = ClsConvert.ToDbObject(Create_User);
			dr["CREATE_DT"] = ClsConvert.ToDbObject(Create_Dt);
			dr["MODIFY_USER"] = ClsConvert.ToDbObject(Modify_User);
			dr["MODIFY_DT"] = ClsConvert.ToDbObject(Modify_Dt);
			dr["ACTIVE_FLG"] = ClsConvert.ToDbObject(Active_Flg);
			dr["OFFICE_CD"] = ClsConvert.ToDbObject(Office_Cd);
			dr["DATABASE_CODE"] = ClsConvert.ToDbObject(Database_Code);
			dr["ENTRY_DT"] = ClsConvert.ToDbObject(Entry_Dt);
			dr["JOURNAL_NO"] = ClsConvert.ToDbObject(Journal_No);
			dr["ACCOUNTING_PERIOD"] = ClsConvert.ToDbObject(Accounting_Period);
			dr["JOURNAL_SOURCE"] = ClsConvert.ToDbObject(Journal_Source);
			dr["JOURNAL_TYPE"] = ClsConvert.ToDbObject(Journal_Type);
			dr["SUN_VERSION_NO"] = ClsConvert.ToDbObject(Sun_Version_No);
			dr["MATCHED_FLG"] = ClsConvert.ToDbObject(Matched_Flg);
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

		public static ClsSunJe GetUsingKey(Int64 Sun_Je_ID)
		{
			object[] vals = new object[] {Sun_Je_ID};
			DataRow dr = Connection.GetDataRowUsingKey
				(TableName, GetPrimaryKeys(), vals);
			return ( dr == null ) ? null : new ClsSunJe(dr);
		}
		public static DataTable GetAll(string Office_Cd)
		{
			List<DbParameter> lst = new List<DbParameter>();	
			StringBuilder sb = new StringBuilder();
		
			if( string.IsNullOrEmpty(Office_Cd) == false )
			{
				lst.Add(Connection.GetParameter("@OFFICE_CD", Office_Cd));
				sb.Append(" WHERE T_SUN_JE.OFFICE_CD=@OFFICE_CD");
			}
			sb.Insert(0, SelectSQL);
			return Connection.GetDataTable(sb.ToString(), lst.ToArray());
		}
		#endregion		// #region Static Methods
	}
}