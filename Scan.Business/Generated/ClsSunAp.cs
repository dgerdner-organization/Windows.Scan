using System;
using System.Data;
using System.Text;
using System.Data.Common;
using System.Collections.Generic;
using CS2010.Common;

namespace CS2010.SCAN.Business
{
	public partial class ClsSunAp : ClsBaseTable
	{
		#region Connection Manager

		protected static ClsConnection Connection
		{
			get { return ClsConMgr.Manager["SCAN"]; }
		}
		#endregion		// #region Connection Manager

		#region Table Constants

		public const string TableName = "T_SUN_AP";
		public const int PrimaryKeyCount = 1;
		public static bool HasPrimaryKey
		{
			get { return PrimaryKeyCount > 0; }
		}
		public static string[] GetPrimaryKeys()
		{
			return new string[PrimaryKeyCount] { "SUN_AP_ID" };
		}

		public const string SelectSQL = @"SELECT * FROM T_SUN_AP 
				INNER JOIN R_OFFICE
				ON T_SUN_AP.OFFICE_CD=R_OFFICE.OFFICE_CD ";

		#endregion	// #region Table Constants

		#region Column Length Constants
	
		public const int Create_UserMax = 30;
		public const int Modify_UserMax = 30;
		public const int Active_FlgMax = 1;
		public const int Office_CdMax = 3;
		public const int Database_CodeMax = 50;
		public const int Journal_EntryMax = 50;
		public const int Reference_NoMax = 50;
		public const int Vendor_Account_CdMax = 50;
		public const int Vendor_Account_NmMax = 50;
		public const int Entry_UserMax = 50;
		public const int Check_NoMax = 50;
		public const int Matched_FlgMax = 1;

		#endregion	// #region Column Length Constants

		#region Column Fields

		protected Int64? _Sun_Ap_ID;
		protected string _Create_User;
		protected DateTime? _Create_Dt;
		protected string _Modify_User;
		protected DateTime? _Modify_Dt;
		protected string _Active_Flg;
		protected string _Office_Cd;
		protected string _Database_Code;
		protected string _Journal_Entry;
		protected string _Reference_No;
		protected string _Vendor_Account_Cd;
		protected string _Vendor_Account_Nm;
		protected decimal? _Invoice_Amt;
		protected string _Entry_User;
		protected DateTime? _Invoice_Dt;
		protected DateTime? _Check_Dt;
		protected string _Check_No;
		protected Int32? _Sun_Version_No;
		protected string _Matched_Flg;

		#endregion	// #region Column Fields

		#region Column Properties

		public Int64? Sun_Ap_ID
		{
			get { return _Sun_Ap_ID; }
			set
			{
				if( _Sun_Ap_ID == value ) return;
		
				_Sun_Ap_ID = value;
				_IsDirty = true;
				NotifyPropertyChanged("Sun_Ap_ID");
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
		public string Journal_Entry
		{
			get { return _Journal_Entry; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Journal_Entry, val, false) == 0 ) return;
		
				if( val != null && val.Length > Journal_EntryMax )
					_Journal_Entry = val.Substring(0, (int)Journal_EntryMax);
				else
					_Journal_Entry = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Journal_Entry");
			}
		}
		public string Reference_No
		{
			get { return _Reference_No; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Reference_No, val, false) == 0 ) return;
		
				if( val != null && val.Length > Reference_NoMax )
					_Reference_No = val.Substring(0, (int)Reference_NoMax);
				else
					_Reference_No = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Reference_No");
			}
		}
		public string Vendor_Account_Cd
		{
			get { return _Vendor_Account_Cd; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Vendor_Account_Cd, val, false) == 0 ) return;
		
				if( val != null && val.Length > Vendor_Account_CdMax )
					_Vendor_Account_Cd = val.Substring(0, (int)Vendor_Account_CdMax);
				else
					_Vendor_Account_Cd = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Vendor_Account_Cd");
			}
		}
		public string Vendor_Account_Nm
		{
			get { return _Vendor_Account_Nm; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Vendor_Account_Nm, val, false) == 0 ) return;
		
				if( val != null && val.Length > Vendor_Account_NmMax )
					_Vendor_Account_Nm = val.Substring(0, (int)Vendor_Account_NmMax);
				else
					_Vendor_Account_Nm = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Vendor_Account_Nm");
			}
		}
		public decimal? Invoice_Amt
		{
			get { return _Invoice_Amt; }
			set
			{
				if( _Invoice_Amt == value ) return;
		
				_Invoice_Amt = value;
				_IsDirty = true;
				NotifyPropertyChanged("Invoice_Amt");
			}
		}
		public string Entry_User
		{
			get { return _Entry_User; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Entry_User, val, false) == 0 ) return;
		
				if( val != null && val.Length > Entry_UserMax )
					_Entry_User = val.Substring(0, (int)Entry_UserMax);
				else
					_Entry_User = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Entry_User");
			}
		}
		public DateTime? Invoice_Dt
		{
			get { return _Invoice_Dt; }
			set
			{
				DateTime? val = ( value != null )
					? (DateTime?)value.Value.Date : null;
		
				if( _Invoice_Dt == val ) return;
		
				_Invoice_Dt = val;
				_IsDirty = true;
				NotifyPropertyChanged("Invoice_Dt");
			}
		}
		public DateTime? Check_Dt
		{
			get { return _Check_Dt; }
			set
			{
				DateTime? val = ( value != null )
					? (DateTime?)value.Value.Date : null;
		
				if( _Check_Dt == val ) return;
		
				_Check_Dt = val;
				_IsDirty = true;
				NotifyPropertyChanged("Check_Dt");
			}
		}
		public string Check_No
		{
			get { return _Check_No; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Check_No, val, false) == 0 ) return;
		
				if( val != null && val.Length > Check_NoMax )
					_Check_No = val.Substring(0, (int)Check_NoMax);
				else
					_Check_No = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Check_No");
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

		public ClsSunAp() : base() {}
		public ClsSunAp(DataRow dr) : base(dr) {}
		public ClsSunAp(ClsSunAp src) { CopyFrom(src); }

		#endregion		// #region Constructors

		#region Init methods

		public override void ResetColumns()
		{
			Sun_Ap_ID = null;
			Create_User = null;
			Create_Dt = null;
			Modify_User = null;
			Modify_Dt = null;
			Active_Flg = null;
			Office_Cd = null;
			Database_Code = null;
			Journal_Entry = null;
			Reference_No = null;
			Vendor_Account_Cd = null;
			Vendor_Account_Nm = null;
			Invoice_Amt = null;
			Entry_User = null;
			Invoice_Dt = null;
			Check_Dt = null;
			Check_No = null;
			Sun_Version_No = null;
			Matched_Flg = null;
		}

		public void CopyFrom(ClsSunAp src)
		{
			Sun_Ap_ID = src._Sun_Ap_ID;
			Create_User = src._Create_User;
			Create_Dt = src._Create_Dt;
			Modify_User = src._Modify_User;
			Modify_Dt = src._Modify_Dt;
			Active_Flg = src._Active_Flg;
			Office_Cd = src._Office_Cd;
			Database_Code = src._Database_Code;
			Journal_Entry = src._Journal_Entry;
			Reference_No = src._Reference_No;
			Vendor_Account_Cd = src._Vendor_Account_Cd;
			Vendor_Account_Nm = src._Vendor_Account_Nm;
			Invoice_Amt = src._Invoice_Amt;
			Entry_User = src._Entry_User;
			Invoice_Dt = src._Invoice_Dt;
			Check_Dt = src._Check_Dt;
			Check_No = src._Check_No;
			Sun_Version_No = src._Sun_Version_No;
			Matched_Flg = src._Matched_Flg;
		}

		public override bool ReloadFromDB()
		{
			ClsSunAp tmp = ClsSunAp.GetUsingKey(Sun_Ap_ID.Value);
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

			DbParameter[] p = new DbParameter[19];

			p[0] = Connection.GetParameter
				("@ACTIVE_FLG", Active_Flg);
			p[1] = Connection.GetParameter
				("@OFFICE_CD", Office_Cd);
			p[2] = Connection.GetParameter
				("@DATABASE_CODE", Database_Code);
			p[3] = Connection.GetParameter
				("@JOURNAL_ENTRY", Journal_Entry);
			p[4] = Connection.GetParameter
				("@REFERENCE_NO", Reference_No);
			p[5] = Connection.GetParameter
				("@VENDOR_ACCOUNT_CD", Vendor_Account_Cd);
			p[6] = Connection.GetParameter
				("@VENDOR_ACCOUNT_NM", Vendor_Account_Nm);
			p[7] = Connection.GetParameter
				("@INVOICE_AMT", Invoice_Amt);
			p[8] = Connection.GetParameter
				("@ENTRY_USER", Entry_User);
			p[9] = Connection.GetParameter
				("@INVOICE_DT", Invoice_Dt);
			p[10] = Connection.GetParameter
				("@CHECK_DT", Check_Dt);
			p[11] = Connection.GetParameter
				("@CHECK_NO", Check_No);
			p[12] = Connection.GetParameter
				("@SUN_VERSION_NO", Sun_Version_No);
			p[13] = Connection.GetParameter
				("@MATCHED_FLG", Matched_Flg);
			p[14] = Connection.GetParameter
				("@SUN_AP_ID", Sun_Ap_ID, ParameterDirection.Output, DbType.Int64, 0);
			p[15] = Connection.GetParameter
				("@CREATE_USER", Create_User, ParameterDirection.Output, DbType.AnsiStringFixedLength, Create_UserMax);
			p[16] = Connection.GetParameter
				("@CREATE_DT", Create_Dt, ParameterDirection.Output, DbType.DateTime, 0);
			p[17] = Connection.GetParameter
				("@MODIFY_USER", Modify_User, ParameterDirection.Output, DbType.AnsiStringFixedLength, Modify_UserMax);
			p[18] = Connection.GetParameter
				("@MODIFY_DT", Modify_Dt, ParameterDirection.Output, DbType.DateTime, 0);

			const string sql = @"
				INSERT INTO T_SUN_AP
					(SUN_AP_ID, ACTIVE_FLG, OFFICE_CD,
					DATABASE_CODE, JOURNAL_ENTRY, REFERENCE_NO,
					VENDOR_ACCOUNT_CD, VENDOR_ACCOUNT_NM, INVOICE_AMT,
					ENTRY_USER, INVOICE_DT, CHECK_DT,
					CHECK_NO, SUN_VERSION_NO, MATCHED_FLG)
				VALUES
					(SUN_AP_ID_SEQ.NEXTVAL, @ACTIVE_FLG, @OFFICE_CD,
					@DATABASE_CODE, @JOURNAL_ENTRY, @REFERENCE_NO,
					@VENDOR_ACCOUNT_CD, @VENDOR_ACCOUNT_NM, @INVOICE_AMT,
					@ENTRY_USER, @INVOICE_DT, @CHECK_DT,
					@CHECK_NO, @SUN_VERSION_NO, @MATCHED_FLG)
				RETURNING
					SUN_AP_ID, CREATE_USER, CREATE_DT,
					MODIFY_USER, MODIFY_DT
				INTO
					@SUN_AP_ID, @CREATE_USER, @CREATE_DT,
					@MODIFY_USER, @MODIFY_DT";
			int ret = Connection.RunSQL(sql, p);

			Sun_Ap_ID = ClsConvert.ToInt64Nullable(p[14].Value);
			Create_User = ClsConvert.ToString(p[15].Value);
			Create_Dt = ClsConvert.ToDateTimeNullable(p[16].Value);
			Modify_User = ClsConvert.ToString(p[17].Value);
			Modify_Dt = ClsConvert.ToDateTimeNullable(p[18].Value);
			return ret;
		}
		public override int Update()
		{
			DbParameter[] p = new DbParameter[17];

			p[0] = Connection.GetParameter
				("@MODIFY_DT", Modify_Dt, ParameterDirection.InputOutput, DbType.DateTime, 0);
			p[1] = Connection.GetParameter
				("@ACTIVE_FLG", Active_Flg);
			p[2] = Connection.GetParameter
				("@OFFICE_CD", Office_Cd);
			p[3] = Connection.GetParameter
				("@DATABASE_CODE", Database_Code);
			p[4] = Connection.GetParameter
				("@JOURNAL_ENTRY", Journal_Entry);
			p[5] = Connection.GetParameter
				("@REFERENCE_NO", Reference_No);
			p[6] = Connection.GetParameter
				("@VENDOR_ACCOUNT_CD", Vendor_Account_Cd);
			p[7] = Connection.GetParameter
				("@VENDOR_ACCOUNT_NM", Vendor_Account_Nm);
			p[8] = Connection.GetParameter
				("@INVOICE_AMT", Invoice_Amt);
			p[9] = Connection.GetParameter
				("@ENTRY_USER", Entry_User);
			p[10] = Connection.GetParameter
				("@INVOICE_DT", Invoice_Dt);
			p[11] = Connection.GetParameter
				("@CHECK_DT", Check_Dt);
			p[12] = Connection.GetParameter
				("@CHECK_NO", Check_No);
			p[13] = Connection.GetParameter
				("@SUN_VERSION_NO", Sun_Version_No);
			p[14] = Connection.GetParameter
				("@MATCHED_FLG", Matched_Flg);
			p[15] = Connection.GetParameter
				("@SUN_AP_ID", Sun_Ap_ID);
			p[16] = Connection.GetParameter
				("@MODIFY_USER", Modify_User, ParameterDirection.Output, DbType.AnsiStringFixedLength, Modify_UserMax);

			const string sql = @"
				UPDATE T_SUN_AP SET
					MODIFY_DT = @MODIFY_DT,
					ACTIVE_FLG = @ACTIVE_FLG,
					OFFICE_CD = @OFFICE_CD,
					DATABASE_CODE = @DATABASE_CODE,
					JOURNAL_ENTRY = @JOURNAL_ENTRY,
					REFERENCE_NO = @REFERENCE_NO,
					VENDOR_ACCOUNT_CD = @VENDOR_ACCOUNT_CD,
					VENDOR_ACCOUNT_NM = @VENDOR_ACCOUNT_NM,
					INVOICE_AMT = @INVOICE_AMT,
					ENTRY_USER = @ENTRY_USER,
					INVOICE_DT = @INVOICE_DT,
					CHECK_DT = @CHECK_DT,
					CHECK_NO = @CHECK_NO,
					SUN_VERSION_NO = @SUN_VERSION_NO,
					MATCHED_FLG = @MATCHED_FLG
				WHERE
					SUN_AP_ID = @SUN_AP_ID
				RETURNING
					MODIFY_USER, MODIFY_DT
				INTO
					@MODIFY_USER, @MODIFY_DT";
			int ret = Connection.RunSQL(sql, p);

			Modify_Dt = ClsConvert.ToDateTimeNullable(p[0].Value);
			Modify_User = ClsConvert.ToString(p[16].Value);
			return ret;
		}
		public override int Delete()
		{
            DbParameter[] p = new DbParameter[1];

            p[0] = Connection.GetParameter
                ("@SUN_AP_ID", Sun_Ap_ID);

            const string sql = @"
				DELETE FROM T_SUN_AP WHERE
				SUN_AP_ID=@SUN_AP_ID";

            return Connection.RunSQL(sql, p);
    	}
		#endregion		// #region Insert, Update, Delete

		#region Conversion methods

		public override void LoadFromDataReader(DbDataReader dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataReader: DataReader parameter was null");

			Sun_Ap_ID = ClsConvert.ToInt64Nullable(dr["SUN_AP_ID"]);
			Create_User = ClsConvert.ToString(dr["CREATE_USER"]);
			Create_Dt = ClsConvert.ToDateTimeNullable(dr["CREATE_DT"]);
			Modify_User = ClsConvert.ToString(dr["MODIFY_USER"]);
			Modify_Dt = ClsConvert.ToDateTimeNullable(dr["MODIFY_DT"]);
			Active_Flg = ClsConvert.ToString(dr["ACTIVE_FLG"]);
			Office_Cd = ClsConvert.ToString(dr["OFFICE_CD"]);
			Database_Code = ClsConvert.ToString(dr["DATABASE_CODE"]);
			Journal_Entry = ClsConvert.ToString(dr["JOURNAL_ENTRY"]);
			Reference_No = ClsConvert.ToString(dr["REFERENCE_NO"]);
			Vendor_Account_Cd = ClsConvert.ToString(dr["VENDOR_ACCOUNT_CD"]);
			Vendor_Account_Nm = ClsConvert.ToString(dr["VENDOR_ACCOUNT_NM"]);
			Invoice_Amt = ClsConvert.ToDecimalNullable(dr["INVOICE_AMT"]);
			Entry_User = ClsConvert.ToString(dr["ENTRY_USER"]);
			Invoice_Dt = ClsConvert.ToDateTimeNullable(dr["INVOICE_DT"]);
			Check_Dt = ClsConvert.ToDateTimeNullable(dr["CHECK_DT"]);
			Check_No = ClsConvert.ToString(dr["CHECK_NO"]);
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

			Sun_Ap_ID = ClsConvert.ToInt64Nullable(dr["SUN_AP_ID", v]);
			Create_User = ClsConvert.ToString(dr["CREATE_USER", v]);
			Create_Dt = ClsConvert.ToDateTimeNullable(dr["CREATE_DT", v]);
			Modify_User = ClsConvert.ToString(dr["MODIFY_USER", v]);
			Modify_Dt = ClsConvert.ToDateTimeNullable(dr["MODIFY_DT", v]);
			Active_Flg = ClsConvert.ToString(dr["ACTIVE_FLG", v]);
			Office_Cd = ClsConvert.ToString(dr["OFFICE_CD", v]);
			Database_Code = ClsConvert.ToString(dr["DATABASE_CODE", v]);
			Journal_Entry = ClsConvert.ToString(dr["JOURNAL_ENTRY", v]);
			Reference_No = ClsConvert.ToString(dr["REFERENCE_NO", v]);
			Vendor_Account_Cd = ClsConvert.ToString(dr["VENDOR_ACCOUNT_CD", v]);
			Vendor_Account_Nm = ClsConvert.ToString(dr["VENDOR_ACCOUNT_NM", v]);
			Invoice_Amt = ClsConvert.ToDecimalNullable(dr["INVOICE_AMT", v]);
			Entry_User = ClsConvert.ToString(dr["ENTRY_USER", v]);
			Invoice_Dt = ClsConvert.ToDateTimeNullable(dr["INVOICE_DT", v]);
			Check_Dt = ClsConvert.ToDateTimeNullable(dr["CHECK_DT", v]);
			Check_No = ClsConvert.ToString(dr["CHECK_NO", v]);
			Sun_Version_No = ClsConvert.ToInt32Nullable(dr["SUN_VERSION_NO", v]);
			Matched_Flg = ClsConvert.ToString(dr["MATCHED_FLG", v]);
		}

		public override void CopyToDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("CopyToDataRow: DataRow parameter was null");

			dr["SUN_AP_ID"] = ClsConvert.ToDbObject(Sun_Ap_ID);
			dr["CREATE_USER"] = ClsConvert.ToDbObject(Create_User);
			dr["CREATE_DT"] = ClsConvert.ToDbObject(Create_Dt);
			dr["MODIFY_USER"] = ClsConvert.ToDbObject(Modify_User);
			dr["MODIFY_DT"] = ClsConvert.ToDbObject(Modify_Dt);
			dr["ACTIVE_FLG"] = ClsConvert.ToDbObject(Active_Flg);
			dr["OFFICE_CD"] = ClsConvert.ToDbObject(Office_Cd);
			dr["DATABASE_CODE"] = ClsConvert.ToDbObject(Database_Code);
			dr["JOURNAL_ENTRY"] = ClsConvert.ToDbObject(Journal_Entry);
			dr["REFERENCE_NO"] = ClsConvert.ToDbObject(Reference_No);
			dr["VENDOR_ACCOUNT_CD"] = ClsConvert.ToDbObject(Vendor_Account_Cd);
			dr["VENDOR_ACCOUNT_NM"] = ClsConvert.ToDbObject(Vendor_Account_Nm);
			dr["INVOICE_AMT"] = ClsConvert.ToDbObject(Invoice_Amt);
			dr["ENTRY_USER"] = ClsConvert.ToDbObject(Entry_User);
			dr["INVOICE_DT"] = ClsConvert.ToDbObject(Invoice_Dt);
			dr["CHECK_DT"] = ClsConvert.ToDbObject(Check_Dt);
			dr["CHECK_NO"] = ClsConvert.ToDbObject(Check_No);
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

		public static ClsSunAp GetUsingKey(Int64 Sun_Ap_ID)
		{
			object[] vals = new object[] {Sun_Ap_ID};
			DataRow dr = Connection.GetDataRowUsingKey
				(TableName, GetPrimaryKeys(), vals);
			return ( dr == null ) ? null : new ClsSunAp(dr);
		}
		public static DataTable GetAll(string Office_Cd)
		{
			List<DbParameter> lst = new List<DbParameter>();	
			StringBuilder sb = new StringBuilder();
		
			if( string.IsNullOrEmpty(Office_Cd) == false )
			{
				lst.Add(Connection.GetParameter("@OFFICE_CD", Office_Cd));
				sb.Append(" WHERE T_SUN_AP.OFFICE_CD=@OFFICE_CD");
			}
			sb.Insert(0, SelectSQL);
			return Connection.GetDataTable(sb.ToString(), lst.ToArray());
		}
		#endregion		// #region Static Methods
	}
}