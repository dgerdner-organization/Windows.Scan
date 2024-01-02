using System;
using System.Data;
using System.Text;
using System.Data.Common;
using System.Collections.Generic;
using CS2010.Common;

namespace CS2010.SCAN.Business
{
	public partial class ClsImageJe : ClsBaseTable
	{
		#region Connection Manager

		protected static ClsConnection Connection
		{
			get { return ClsConMgr.Manager["SCAN"]; }
		}
		#endregion		// #region Connection Manager

		#region Table Constants

		public const string TableName = "T_IMAGE_JE";
		public const int PrimaryKeyCount = 1;
		public static bool HasPrimaryKey
		{
			get { return PrimaryKeyCount > 0; }
		}
		public static string[] GetPrimaryKeys()
		{
			return new string[PrimaryKeyCount] { "IMAGE_JE_ID" };
		}

		public const string SelectSQL = @"SELECT * FROM T_IMAGE_JE 
				INNER JOIN R_SUN_DATABASE
				ON T_IMAGE_JE.SUN_DATABASE_CD=R_SUN_DATABASE.SUN_DATABASE_CD
				INNER JOIN R_OFFICE
				ON T_IMAGE_JE.OFFICE_CD=R_OFFICE.OFFICE_CD
				LEFT OUTER JOIN T_SUN_JE
				ON T_IMAGE_JE.SUN_JE_ID=T_SUN_JE.SUN_JE_ID ";

		#endregion	// #region Table Constants

		#region Column Length Constants
	
		public const int Create_UserMax = 30;
		public const int Modify_UserMax = 30;
		public const int Active_FlgMax = 1;
		public const int Office_CdMax = 3;
		public const int Sun_Database_CdMax = 3;
		public const int Journal_NoMax = 20;
		public const int Folder_NmMax = 200;
		public const int File_NmMax = 100;

		#endregion	// #region Column Length Constants

		#region Column Fields

		protected Int64? _Image_Je_ID;
		protected string _Create_User;
		protected DateTime? _Create_Dt;
		protected string _Modify_User;
		protected DateTime? _Modify_Dt;
		protected string _Active_Flg;
		protected string _Office_Cd;
		protected string _Sun_Database_Cd;
		protected string _Journal_No;
		protected string _Folder_Nm;
		protected string _File_Nm;
		protected Int64? _Sun_Je_ID;

		#endregion	// #region Column Fields

		#region Column Properties

		public Int64? Image_Je_ID
		{
			get { return _Image_Je_ID; }
			set
			{
				if( _Image_Je_ID == value ) return;
		
				_Image_Je_ID = value;
				_IsDirty = true;
				NotifyPropertyChanged("Image_Je_ID");
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

		#endregion	// #region Column Properties

		#region Foreign Key Fields

		protected ClsSunDatabase _Sun_Database;
		protected ClsOffice _Office;
		protected ClsSunJe _Sun_Je;

		#endregion	// #region Foreign Key Fields

		#region Foreign Key Properties

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
		public ClsSunJe Sun_Je
		{
			get
			{
				if( Sun_Je_ID == null )
					_Sun_Je = null;
				else if( _Sun_Je == null ||
					_Sun_Je.Sun_Je_ID != Sun_Je_ID )
					_Sun_Je = ClsSunJe.GetUsingKey(Sun_Je_ID.Value);
				return _Sun_Je;
			}
			set
			{
				if( _Sun_Je == value ) return;
		
				_Sun_Je = value;
			}
		}

		#endregion	// #region Foreign Key Properties

		#region Constructors

		public ClsImageJe() : base() {}
		public ClsImageJe(DataRow dr) : base(dr) {}
		public ClsImageJe(ClsImageJe src) { CopyFrom(src); }

		#endregion		// #region Constructors

		#region Init methods

		public override void ResetColumns()
		{
			Image_Je_ID = null;
			Create_User = null;
			Create_Dt = null;
			Modify_User = null;
			Modify_Dt = null;
			Active_Flg = null;
			Office_Cd = null;
			Sun_Database_Cd = null;
			Journal_No = null;
			Folder_Nm = null;
			File_Nm = null;
			Sun_Je_ID = null;
		}

		public void CopyFrom(ClsImageJe src)
		{
			Image_Je_ID = src._Image_Je_ID;
			Create_User = src._Create_User;
			Create_Dt = src._Create_Dt;
			Modify_User = src._Modify_User;
			Modify_Dt = src._Modify_Dt;
			Active_Flg = src._Active_Flg;
			Office_Cd = src._Office_Cd;
			Sun_Database_Cd = src._Sun_Database_Cd;
			Journal_No = src._Journal_No;
			Folder_Nm = src._Folder_Nm;
			File_Nm = src._File_Nm;
			Sun_Je_ID = src._Sun_Je_ID;
		}

		public override bool ReloadFromDB()
		{
			ClsImageJe tmp = ClsImageJe.GetUsingKey(Image_Je_ID.Value);
			if( tmp != null ) CopyFrom(tmp);

			ResetFKs();
			OnReload();

			return ( tmp != null );
		}

		public override void ResetFKs()
		{
			_Sun_Database = null;
			_Office = null;
			_Sun_Je = null;
		}
		#endregion		// #region Init methods

		#region Insert, Update, Delete

		public override int Insert()
		{

			DbParameter[] p = new DbParameter[12];

			p[0] = Connection.GetParameter
				("@ACTIVE_FLG", Active_Flg);
			p[1] = Connection.GetParameter
				("@OFFICE_CD", Office_Cd);
			p[2] = Connection.GetParameter
				("@SUN_DATABASE_CD", Sun_Database_Cd);
			p[3] = Connection.GetParameter
				("@JOURNAL_NO", Journal_No);
			p[4] = Connection.GetParameter
				("@FOLDER_NM", Folder_Nm);
			p[5] = Connection.GetParameter
				("@FILE_NM", File_Nm);
			p[6] = Connection.GetParameter
				("@SUN_JE_ID", Sun_Je_ID);
			p[7] = Connection.GetParameter
				("@IMAGE_JE_ID", Image_Je_ID, ParameterDirection.Output, DbType.Int64, 0);
			p[8] = Connection.GetParameter
				("@CREATE_USER", Create_User, ParameterDirection.Output, DbType.AnsiStringFixedLength, Create_UserMax);
			p[9] = Connection.GetParameter
				("@CREATE_DT", Create_Dt, ParameterDirection.Output, DbType.DateTime, 0);
			p[10] = Connection.GetParameter
				("@MODIFY_USER", Modify_User, ParameterDirection.Output, DbType.AnsiStringFixedLength, Modify_UserMax);
			p[11] = Connection.GetParameter
				("@MODIFY_DT", Modify_Dt, ParameterDirection.Output, DbType.DateTime, 0);

			const string sql = @"
				INSERT INTO T_IMAGE_JE
					(IMAGE_JE_ID, ACTIVE_FLG, OFFICE_CD,
					SUN_DATABASE_CD, JOURNAL_NO, FOLDER_NM,
					FILE_NM, SUN_JE_ID)
				VALUES
					(IMAGE_JE_ID_SEQ.NEXTVAL, @ACTIVE_FLG, @OFFICE_CD,
					@SUN_DATABASE_CD, @JOURNAL_NO, @FOLDER_NM,
					@FILE_NM, @SUN_JE_ID)
				RETURNING
					IMAGE_JE_ID, CREATE_USER, CREATE_DT,
					MODIFY_USER, MODIFY_DT
				INTO
					@IMAGE_JE_ID, @CREATE_USER, @CREATE_DT,
					@MODIFY_USER, @MODIFY_DT";
			int ret = Connection.RunSQL(sql, p);

			Image_Je_ID = ClsConvert.ToInt64Nullable(p[7].Value);
			Create_User = ClsConvert.ToString(p[8].Value);
			Create_Dt = ClsConvert.ToDateTimeNullable(p[9].Value);
			Modify_User = ClsConvert.ToString(p[10].Value);
			Modify_Dt = ClsConvert.ToDateTimeNullable(p[11].Value);
			return ret;
		}
		public override int Update()
		{
			DbParameter[] p = new DbParameter[10];

			p[0] = Connection.GetParameter
				("@MODIFY_DT", Modify_Dt, ParameterDirection.InputOutput, DbType.DateTime, 0);
			p[1] = Connection.GetParameter
				("@ACTIVE_FLG", Active_Flg);
			p[2] = Connection.GetParameter
				("@OFFICE_CD", Office_Cd);
			p[3] = Connection.GetParameter
				("@SUN_DATABASE_CD", Sun_Database_Cd);
			p[4] = Connection.GetParameter
				("@JOURNAL_NO", Journal_No);
			p[5] = Connection.GetParameter
				("@FOLDER_NM", Folder_Nm);
			p[6] = Connection.GetParameter
				("@FILE_NM", File_Nm);
			p[7] = Connection.GetParameter
				("@SUN_JE_ID", Sun_Je_ID);
			p[8] = Connection.GetParameter
				("@IMAGE_JE_ID", Image_Je_ID);
			p[9] = Connection.GetParameter
				("@MODIFY_USER", Modify_User, ParameterDirection.Output, DbType.AnsiStringFixedLength, Modify_UserMax);

			const string sql = @"
				UPDATE T_IMAGE_JE SET
					MODIFY_DT = @MODIFY_DT,
					ACTIVE_FLG = @ACTIVE_FLG,
					OFFICE_CD = @OFFICE_CD,
					SUN_DATABASE_CD = @SUN_DATABASE_CD,
					JOURNAL_NO = @JOURNAL_NO,
					FOLDER_NM = @FOLDER_NM,
					FILE_NM = @FILE_NM,
					SUN_JE_ID = @SUN_JE_ID
				WHERE
					IMAGE_JE_ID = @IMAGE_JE_ID
				RETURNING
					MODIFY_USER, MODIFY_DT
				INTO
					@MODIFY_USER, @MODIFY_DT";
			int ret = Connection.RunSQL(sql, p);

			Modify_Dt = ClsConvert.ToDateTimeNullable(p[0].Value);
			Modify_User = ClsConvert.ToString(p[9].Value);
			return ret;
		}
		public override int Delete()
		{
			DbParameter[] p = new DbParameter[1];

			p[0] = Connection.GetParameter
				("@IMAGE_JE_ID", Image_Je_ID);

			const string sql = @"
				DELETE FROM T_IMAGE_JE WHERE
				IMAGE_JE_ID=@IMAGE_JE_ID";
			return Connection.RunSQL(sql, p);
		}
		#endregion		// #region Insert, Update, Delete

		#region Conversion methods

		public override void LoadFromDataReader(DbDataReader dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataReader: DataReader parameter was null");

			Image_Je_ID = ClsConvert.ToInt64Nullable(dr["IMAGE_JE_ID"]);
			Create_User = ClsConvert.ToString(dr["CREATE_USER"]);
			Create_Dt = ClsConvert.ToDateTimeNullable(dr["CREATE_DT"]);
			Modify_User = ClsConvert.ToString(dr["MODIFY_USER"]);
			Modify_Dt = ClsConvert.ToDateTimeNullable(dr["MODIFY_DT"]);
			Active_Flg = ClsConvert.ToString(dr["ACTIVE_FLG"]);
			Office_Cd = ClsConvert.ToString(dr["OFFICE_CD"]);
			Sun_Database_Cd = ClsConvert.ToString(dr["SUN_DATABASE_CD"]);
			Journal_No = ClsConvert.ToString(dr["JOURNAL_NO"]);
			Folder_Nm = ClsConvert.ToString(dr["FOLDER_NM"]);
			File_Nm = ClsConvert.ToString(dr["FILE_NM"]);
			Sun_Je_ID = ClsConvert.ToInt64Nullable(dr["SUN_JE_ID"]);
		}

		public override void LoadFromDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataRow: DataRow parameter was null");

			DataRowVersion v = ( dr.RowState == DataRowState.Deleted )
				? DataRowVersion.Original : DataRowVersion.Current;

			Image_Je_ID = ClsConvert.ToInt64Nullable(dr["IMAGE_JE_ID", v]);
			Create_User = ClsConvert.ToString(dr["CREATE_USER", v]);
			Create_Dt = ClsConvert.ToDateTimeNullable(dr["CREATE_DT", v]);
			Modify_User = ClsConvert.ToString(dr["MODIFY_USER", v]);
			Modify_Dt = ClsConvert.ToDateTimeNullable(dr["MODIFY_DT", v]);
			Active_Flg = ClsConvert.ToString(dr["ACTIVE_FLG", v]);
			Office_Cd = ClsConvert.ToString(dr["OFFICE_CD", v]);
			Sun_Database_Cd = ClsConvert.ToString(dr["SUN_DATABASE_CD", v]);
			Journal_No = ClsConvert.ToString(dr["JOURNAL_NO", v]);
			Folder_Nm = ClsConvert.ToString(dr["FOLDER_NM", v]);
			File_Nm = ClsConvert.ToString(dr["FILE_NM", v]);
			Sun_Je_ID = ClsConvert.ToInt64Nullable(dr["SUN_JE_ID", v]);
		}

		public override void CopyToDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("CopyToDataRow: DataRow parameter was null");

			dr["IMAGE_JE_ID"] = ClsConvert.ToDbObject(Image_Je_ID);
			dr["CREATE_USER"] = ClsConvert.ToDbObject(Create_User);
			dr["CREATE_DT"] = ClsConvert.ToDbObject(Create_Dt);
			dr["MODIFY_USER"] = ClsConvert.ToDbObject(Modify_User);
			dr["MODIFY_DT"] = ClsConvert.ToDbObject(Modify_Dt);
			dr["ACTIVE_FLG"] = ClsConvert.ToDbObject(Active_Flg);
			dr["OFFICE_CD"] = ClsConvert.ToDbObject(Office_Cd);
			dr["SUN_DATABASE_CD"] = ClsConvert.ToDbObject(Sun_Database_Cd);
			dr["JOURNAL_NO"] = ClsConvert.ToDbObject(Journal_No);
			dr["FOLDER_NM"] = ClsConvert.ToDbObject(Folder_Nm);
			dr["FILE_NM"] = ClsConvert.ToDbObject(File_Nm);
			dr["SUN_JE_ID"] = ClsConvert.ToDbObject(Sun_Je_ID);
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

		public static ClsImageJe GetUsingKey(Int64 Image_Je_ID)
		{
			object[] vals = new object[] {Image_Je_ID};
			DataRow dr = Connection.GetDataRowUsingKey
				(TableName, GetPrimaryKeys(), vals);
			return ( dr == null ) ? null : new ClsImageJe(dr);
		}
		public static DataTable GetAll(string Sun_Database_Cd, string Office_Cd,
			Int64? Sun_Je_ID)
		{
			List<DbParameter> lst = new List<DbParameter>();	
			StringBuilder sb = new StringBuilder();
		
			if( string.IsNullOrEmpty(Sun_Database_Cd) == false )
			{
				lst.Add(Connection.GetParameter("@SUN_DATABASE_CD", Sun_Database_Cd));
				sb.Append(" WHERE T_IMAGE_JE.SUN_DATABASE_CD=@SUN_DATABASE_CD");
			}
			if( string.IsNullOrEmpty(Office_Cd) == false )
			{
				lst.Add(Connection.GetParameter("@OFFICE_CD", Office_Cd));
				sb.AppendFormat(" {0} T_IMAGE_JE.OFFICE_CD=@OFFICE_CD",
					sb.Length > 0 ? "AND" : "WHERE");
			}
			if( Sun_Je_ID != null && Sun_Je_ID > 0 )
			{
				lst.Add(Connection.GetParameter("@SUN_JE_ID", Sun_Je_ID));
				sb.AppendFormat(" {0} T_IMAGE_JE.SUN_JE_ID=@SUN_JE_ID",
					sb.Length > 0 ? "AND" : "WHERE");
			}
			sb.Insert(0, SelectSQL);
			return Connection.GetDataTable(sb.ToString(), lst.ToArray());
		}
		#endregion		// #region Static Methods
	}
}