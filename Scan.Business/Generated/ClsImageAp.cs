using System;
using System.Data;
using System.Text;
using System.Data.Common;
using System.Collections.Generic;
using CS2010.Common;

namespace CS2010.SCAN.Business
{
	public partial class ClsImageAp : ClsBaseTable
	{
		#region Connection Manager

		protected static ClsConnection Connection
		{
			get { return ClsConMgr.Manager["SCAN"]; }
		}
		#endregion		// #region Connection Manager

		#region Table Constants

		public const string TableName = "T_IMAGE_AP";
		public const int PrimaryKeyCount = 1;
		public static bool HasPrimaryKey
		{
			get { return PrimaryKeyCount > 0; }
		}
		public static string[] GetPrimaryKeys()
		{
			return new string[PrimaryKeyCount] { "IMAGE_AP_ID" };
		}

		public const string SelectSQL = @"SELECT * FROM T_IMAGE_AP 
				INNER JOIN R_OFFICE
				ON T_IMAGE_AP.OFFICE_CD=R_OFFICE.OFFICE_CD
				INNER JOIN R_SUN_DATABASE
				ON T_IMAGE_AP.SUN_DATABASE_CD=R_SUN_DATABASE.SUN_DATABASE_CD ";

		#endregion	// #region Table Constants

		#region Column Length Constants
	
		public const int Create_UserMax = 30;
		public const int Modify_UserMax = 30;
		public const int Active_FlgMax = 1;
		public const int Office_CdMax = 3;
		public const int Sun_Database_CdMax = 3;
		public const int Check_NoMax = 10;
		public const int Folder_NmMax = 200;
		public const int File_NmMax = 100;

		#endregion	// #region Column Length Constants

		#region Column Fields

		protected Int64? _Image_Ap_ID;
		protected string _Create_User;
		protected DateTime? _Create_Dt;
		protected string _Modify_User;
		protected DateTime? _Modify_Dt;
		protected string _Active_Flg;
		protected string _Office_Cd;
		protected string _Sun_Database_Cd;
		protected string _Check_No;
		protected decimal? _Invoice_Amt;
		protected string _Folder_Nm;
		protected string _File_Nm;
		protected Int64? _Sun_Ap_ID;

		#endregion	// #region Column Fields

		#region Column Properties

		public Int64? Image_Ap_ID
		{
			get { return _Image_Ap_ID; }
			set
			{
				if( _Image_Ap_ID == value ) return;
		
				_Image_Ap_ID = value;
				_IsDirty = true;
				NotifyPropertyChanged("Image_Ap_ID");
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
		public string Folder_Nm
		{
			get { return _Folder_Nm; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Folder_Nm, val, false) == 0 ) return;
		
				if( val != null && val.Length > Folder_NmMax )
					_Folder_Nm = val.Substring(0, (int)Folder_NmMax);
				else
					_Folder_Nm = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Folder_Nm");
			}
		}
		public string File_Nm
		{
			get { return _File_Nm; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_File_Nm, val, false) == 0 ) return;
		
				if( val != null && val.Length > File_NmMax )
					_File_Nm = val.Substring(0, (int)File_NmMax);
				else
					_File_Nm = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("File_Nm");
			}
		}
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

		#endregion	// #region Column Properties

		#region Foreign Key Fields

		protected ClsOffice _Office;
		protected ClsSunDatabase _Sun_Database;

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
		public ClsSunDatabase Sun_Database
		{
			get
			{
				if( Sun_Database_Cd == null )
					_Sun_Database = null;
				else if( _Sun_Database == null ||
					_Sun_Database.Sun_Database_Cd != Sun_Database_Cd )
					_Sun_Database = ClsSunDatabase.GetUsingKey(Sun_Database_Cd);
				return _Sun_Database;
			}
			set
			{
				if( _Sun_Database == value ) return;
		
				_Sun_Database = value;
			}
		}

		#endregion	// #region Foreign Key Properties

		#region Constructors

		public ClsImageAp() : base() {}
		public ClsImageAp(DataRow dr) : base(dr) {}
		public ClsImageAp(ClsImageAp src) { CopyFrom(src); }

		#endregion		// #region Constructors

		#region Init methods

		public override void ResetColumns()
		{
			Image_Ap_ID = null;
			Create_User = null;
			Create_Dt = null;
			Modify_User = null;
			Modify_Dt = null;
			Active_Flg = null;
			Office_Cd = null;
			Sun_Database_Cd = null;
			Check_No = null;
			Invoice_Amt = null;
			Folder_Nm = null;
			File_Nm = null;
			Sun_Ap_ID = null;
		}

		public void CopyFrom(ClsImageAp src)
		{
			Image_Ap_ID = src._Image_Ap_ID;
			Create_User = src._Create_User;
			Create_Dt = src._Create_Dt;
			Modify_User = src._Modify_User;
			Modify_Dt = src._Modify_Dt;
			Active_Flg = src._Active_Flg;
			Office_Cd = src._Office_Cd;
			Sun_Database_Cd = src._Sun_Database_Cd;
			Check_No = src._Check_No;
			Invoice_Amt = src._Invoice_Amt;
			Folder_Nm = src._Folder_Nm;
			File_Nm = src._File_Nm;
			Sun_Ap_ID = src._Sun_Ap_ID;
		}

		public override bool ReloadFromDB()
		{
			ClsImageAp tmp = ClsImageAp.GetUsingKey(Image_Ap_ID.Value);
			if( tmp != null ) CopyFrom(tmp);

			ResetFKs();
			OnReload();

			return ( tmp != null );
		}

		public override void ResetFKs()
		{
			_Office = null;
			_Sun_Database = null;
		}
		#endregion		// #region Init methods

		#region Insert, Update, Delete

		public override int Insert()
		{

			DbParameter[] p = new DbParameter[13];

			p[0] = Connection.GetParameter
				("@ACTIVE_FLG", Active_Flg);
			p[1] = Connection.GetParameter
				("@OFFICE_CD", Office_Cd);
			p[2] = Connection.GetParameter
				("@SUN_DATABASE_CD", Sun_Database_Cd);
			p[3] = Connection.GetParameter
				("@CHECK_NO", Check_No);
			p[4] = Connection.GetParameter
				("@INVOICE_AMT", Invoice_Amt);
			p[5] = Connection.GetParameter
				("@FOLDER_NM", Folder_Nm);
			p[6] = Connection.GetParameter
				("@FILE_NM", File_Nm);
			p[7] = Connection.GetParameter
				("@SUN_AP_ID", Sun_Ap_ID);
			p[8] = Connection.GetParameter
				("@IMAGE_AP_ID", Image_Ap_ID, ParameterDirection.Output, DbType.Int64, 0);
			p[9] = Connection.GetParameter
				("@CREATE_USER", Create_User, ParameterDirection.Output, DbType.AnsiStringFixedLength, Create_UserMax);
			p[10] = Connection.GetParameter
				("@CREATE_DT", Create_Dt, ParameterDirection.Output, DbType.DateTime, 0);
			p[11] = Connection.GetParameter
				("@MODIFY_USER", Modify_User, ParameterDirection.Output, DbType.AnsiStringFixedLength, Modify_UserMax);
			p[12] = Connection.GetParameter
				("@MODIFY_DT", Modify_Dt, ParameterDirection.Output, DbType.DateTime, 0);

			const string sql = @"
				INSERT INTO T_IMAGE_AP
					(IMAGE_AP_ID, ACTIVE_FLG, OFFICE_CD,
					SUN_DATABASE_CD, CHECK_NO, INVOICE_AMT,
					FOLDER_NM, FILE_NM, SUN_AP_ID)
				VALUES
					(IMAGE_AP_ID_SEQ.NEXTVAL, @ACTIVE_FLG, @OFFICE_CD,
					@SUN_DATABASE_CD, @CHECK_NO, @INVOICE_AMT,
					@FOLDER_NM, @FILE_NM, @SUN_AP_ID)
				RETURNING
					IMAGE_AP_ID, CREATE_USER, CREATE_DT,
					MODIFY_USER, MODIFY_DT
				INTO
					@IMAGE_AP_ID, @CREATE_USER, @CREATE_DT,
					@MODIFY_USER, @MODIFY_DT";
			int ret = Connection.RunSQL(sql, p);

			Image_Ap_ID = ClsConvert.ToInt64Nullable(p[8].Value);
			Create_User = ClsConvert.ToString(p[9].Value);
			Create_Dt = ClsConvert.ToDateTimeNullable(p[10].Value);
			Modify_User = ClsConvert.ToString(p[11].Value);
			Modify_Dt = ClsConvert.ToDateTimeNullable(p[12].Value);
			return ret;
		}
		public override int Update()
		{
			DbParameter[] p = new DbParameter[11];

			p[0] = Connection.GetParameter
				("@MODIFY_DT", Modify_Dt, ParameterDirection.InputOutput, DbType.DateTime, 0);
			p[1] = Connection.GetParameter
				("@ACTIVE_FLG", Active_Flg);
			p[2] = Connection.GetParameter
				("@OFFICE_CD", Office_Cd);
			p[3] = Connection.GetParameter
				("@SUN_DATABASE_CD", Sun_Database_Cd);
			p[4] = Connection.GetParameter
				("@CHECK_NO", Check_No);
			p[5] = Connection.GetParameter
				("@INVOICE_AMT", Invoice_Amt);
			p[6] = Connection.GetParameter
				("@FOLDER_NM", Folder_Nm);
			p[7] = Connection.GetParameter
				("@FILE_NM", File_Nm);
			p[8] = Connection.GetParameter
				("@SUN_AP_ID", Sun_Ap_ID);
			p[9] = Connection.GetParameter
				("@IMAGE_AP_ID", Image_Ap_ID);
			p[10] = Connection.GetParameter
				("@MODIFY_USER", Modify_User, ParameterDirection.Output, DbType.AnsiStringFixedLength, Modify_UserMax);

			const string sql = @"
				UPDATE T_IMAGE_AP SET
					MODIFY_DT = @MODIFY_DT,
					ACTIVE_FLG = @ACTIVE_FLG,
					OFFICE_CD = @OFFICE_CD,
					SUN_DATABASE_CD = @SUN_DATABASE_CD,
					CHECK_NO = @CHECK_NO,
					INVOICE_AMT = @INVOICE_AMT,
					FOLDER_NM = @FOLDER_NM,
					FILE_NM = @FILE_NM,
					SUN_AP_ID = @SUN_AP_ID
				WHERE
					IMAGE_AP_ID = @IMAGE_AP_ID
				RETURNING
					MODIFY_USER, MODIFY_DT
				INTO
					@MODIFY_USER, @MODIFY_DT";
			int ret = Connection.RunSQL(sql, p);

			Modify_Dt = ClsConvert.ToDateTimeNullable(p[0].Value);
			Modify_User = ClsConvert.ToString(p[10].Value);
			return ret;
		}
		public override int Delete()
		{
			DbParameter[] p = new DbParameter[1];

			p[0] = Connection.GetParameter
				("@IMAGE_AP_ID", Image_Ap_ID);

			const string sql = @"
				DELETE FROM T_IMAGE_AP WHERE
				IMAGE_AP_ID=@IMAGE_AP_ID";
			return Connection.RunSQL(sql, p);
		}
		#endregion		// #region Insert, Update, Delete

		#region Conversion methods

		public override void LoadFromDataReader(DbDataReader dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataReader: DataReader parameter was null");

			Image_Ap_ID = ClsConvert.ToInt64Nullable(dr["IMAGE_AP_ID"]);
			Create_User = ClsConvert.ToString(dr["CREATE_USER"]);
			Create_Dt = ClsConvert.ToDateTimeNullable(dr["CREATE_DT"]);
			Modify_User = ClsConvert.ToString(dr["MODIFY_USER"]);
			Modify_Dt = ClsConvert.ToDateTimeNullable(dr["MODIFY_DT"]);
			Active_Flg = ClsConvert.ToString(dr["ACTIVE_FLG"]);
			Office_Cd = ClsConvert.ToString(dr["OFFICE_CD"]);
			Sun_Database_Cd = ClsConvert.ToString(dr["SUN_DATABASE_CD"]);
			Check_No = ClsConvert.ToString(dr["CHECK_NO"]);
			Invoice_Amt = ClsConvert.ToDecimalNullable(dr["INVOICE_AMT"]);
			Folder_Nm = ClsConvert.ToString(dr["FOLDER_NM"]);
			File_Nm = ClsConvert.ToString(dr["FILE_NM"]);
			Sun_Ap_ID = ClsConvert.ToInt64Nullable(dr["SUN_AP_ID"]);
		}

		public override void LoadFromDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataRow: DataRow parameter was null");

			DataRowVersion v = ( dr.RowState == DataRowState.Deleted )
				? DataRowVersion.Original : DataRowVersion.Current;

			Image_Ap_ID = ClsConvert.ToInt64Nullable(dr["IMAGE_AP_ID", v]);
			Create_User = ClsConvert.ToString(dr["CREATE_USER", v]);
			Create_Dt = ClsConvert.ToDateTimeNullable(dr["CREATE_DT", v]);
			Modify_User = ClsConvert.ToString(dr["MODIFY_USER", v]);
			Modify_Dt = ClsConvert.ToDateTimeNullable(dr["MODIFY_DT", v]);
			Active_Flg = ClsConvert.ToString(dr["ACTIVE_FLG", v]);
			Office_Cd = ClsConvert.ToString(dr["OFFICE_CD", v]);
			Sun_Database_Cd = ClsConvert.ToString(dr["SUN_DATABASE_CD", v]);
			Check_No = ClsConvert.ToString(dr["CHECK_NO", v]);
			Invoice_Amt = ClsConvert.ToDecimalNullable(dr["INVOICE_AMT", v]);
			Folder_Nm = ClsConvert.ToString(dr["FOLDER_NM", v]);
			File_Nm = ClsConvert.ToString(dr["FILE_NM", v]);
			Sun_Ap_ID = ClsConvert.ToInt64Nullable(dr["SUN_AP_ID", v]);
		}

		public override void CopyToDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("CopyToDataRow: DataRow parameter was null");

			dr["IMAGE_AP_ID"] = ClsConvert.ToDbObject(Image_Ap_ID);
			dr["CREATE_USER"] = ClsConvert.ToDbObject(Create_User);
			dr["CREATE_DT"] = ClsConvert.ToDbObject(Create_Dt);
			dr["MODIFY_USER"] = ClsConvert.ToDbObject(Modify_User);
			dr["MODIFY_DT"] = ClsConvert.ToDbObject(Modify_Dt);
			dr["ACTIVE_FLG"] = ClsConvert.ToDbObject(Active_Flg);
			dr["OFFICE_CD"] = ClsConvert.ToDbObject(Office_Cd);
			dr["SUN_DATABASE_CD"] = ClsConvert.ToDbObject(Sun_Database_Cd);
			dr["CHECK_NO"] = ClsConvert.ToDbObject(Check_No);
			dr["INVOICE_AMT"] = ClsConvert.ToDbObject(Invoice_Amt);
			dr["FOLDER_NM"] = ClsConvert.ToDbObject(Folder_Nm);
			dr["FILE_NM"] = ClsConvert.ToDbObject(File_Nm);
			dr["SUN_AP_ID"] = ClsConvert.ToDbObject(Sun_Ap_ID);
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

		public static ClsImageAp GetUsingKey(Int64 Image_Ap_ID)
		{
			object[] vals = new object[] {Image_Ap_ID};
			DataRow dr = Connection.GetDataRowUsingKey
				(TableName, GetPrimaryKeys(), vals);
			return ( dr == null ) ? null : new ClsImageAp(dr);
		}
		public static DataTable GetAll(string Office_Cd, string Sun_Database_Cd)
		{
			List<DbParameter> lst = new List<DbParameter>();	
			StringBuilder sb = new StringBuilder();
		
			if( string.IsNullOrEmpty(Office_Cd) == false )
			{
				lst.Add(Connection.GetParameter("@OFFICE_CD", Office_Cd));
				sb.Append(" WHERE T_IMAGE_AP.OFFICE_CD=@OFFICE_CD");
			}
			if( string.IsNullOrEmpty(Sun_Database_Cd) == false )
			{
				lst.Add(Connection.GetParameter("@SUN_DATABASE_CD", Sun_Database_Cd));
				sb.AppendFormat(" {0} T_IMAGE_AP.SUN_DATABASE_CD=@SUN_DATABASE_CD",
					sb.Length > 0 ? "AND" : "WHERE");
			}
			sb.Insert(0, SelectSQL);
			return Connection.GetDataTable(sb.ToString(), lst.ToArray());
		}
		#endregion		// #region Static Methods
	}
}