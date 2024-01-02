using System;
using System.Data;
using System.Text;
using System.Data.Common;
using System.Collections.Generic;
using CS2010.Common;

namespace CS2010.SCAN.Business
{
	public partial class ClsImageGpcInvoice : ClsBaseTable
	{
		#region Connection Manager

		protected static ClsConnection Connection
		{
			get { return ClsConMgr.Manager["SCAN"]; }
		}
		#endregion		// #region Connection Manager

		#region Table Constants

		public const string TableName = "T_IMAGE_GPC_INVOICE";
		public const int PrimaryKeyCount = 1;
		public static bool HasPrimaryKey
		{
			get { return PrimaryKeyCount > 0; }
		}
		public static string[] GetPrimaryKeys()
		{
			return new string[PrimaryKeyCount] { "IMAGE_GPC_INVOICE_ID" };
		}

		public const string SelectSQL = @"SELECT * FROM T_IMAGE_GPC_INVOICE 
				INNER JOIN R_OFFICE
				ON T_IMAGE_GPC_INVOICE.OFFICE_CD=R_OFFICE.OFFICE_CD
				INNER JOIN R_OCEAN_CARRIER
				ON T_IMAGE_GPC_INVOICE.OCEAN_CARRIER_CD=R_OCEAN_CARRIER.OCEAN_CARRIER_CD ";

		#endregion	// #region Table Constants

		#region Column Length Constants
	
		public const int Create_UserMax = 30;
		public const int Modify_UserMax = 30;
		public const int Active_FlgMax = 1;
		public const int Office_CdMax = 3;
		public const int Ocean_Carrier_CdMax = 10;
		public const int Bol_NoMax = 20;
		public const int Invoice_NoMax = 20;
		public const int Folder_NmMax = 200;
		public const int File_NmMax = 50;

		#endregion	// #region Column Length Constants

		#region Column Fields

		protected Int64? _Image_Gpc_Invoice_ID;
		protected string _Create_User;
		protected DateTime? _Create_Dt;
		protected string _Modify_User;
		protected DateTime? _Modify_Dt;
		protected string _Active_Flg;
		protected string _Office_Cd;
		protected string _Ocean_Carrier_Cd;
		protected string _Bol_No;
		protected string _Invoice_No;
		protected string _Folder_Nm;
		protected string _File_Nm;

		#endregion	// #region Column Fields

		#region Column Properties

		public Int64? Image_Gpc_Invoice_ID
		{
			get { return _Image_Gpc_Invoice_ID; }
			set
			{
				if( _Image_Gpc_Invoice_ID == value ) return;
		
				_Image_Gpc_Invoice_ID = value;
				_IsDirty = true;
				NotifyPropertyChanged("Image_Gpc_Invoice_ID");
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
		public string Bol_No
		{
			get { return _Bol_No; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Bol_No, val, false) == 0 ) return;
		
				if( val != null && val.Length > Bol_NoMax )
					_Bol_No = val.Substring(0, (int)Bol_NoMax);
				else
					_Bol_No = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Bol_No");
			}
		}
		public string Invoice_No
		{
			get { return _Invoice_No; }
			set
			{
				string val = ( string.IsNullOrEmpty(value) == false )
					? value.Trim() : null;
		
				if( string.IsNullOrEmpty(val) == true ) val = null;
		
				if( string.Compare(_Invoice_No, val, false) == 0 ) return;
		
				if( val != null && val.Length > Invoice_NoMax )
					_Invoice_No = val.Substring(0, (int)Invoice_NoMax);
				else
					_Invoice_No = val;
		
				_IsDirty = true;
				NotifyPropertyChanged("Invoice_No");
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

		#endregion	// #region Column Properties

		#region Foreign Key Fields

		protected ClsOffice _Office;
		protected ClsOceanCarrier _Ocean_Carrier;

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
		public ClsOceanCarrier Ocean_Carrier
		{
			get
			{
				if( Ocean_Carrier_Cd == null )
					_Ocean_Carrier = null;
				else if( _Ocean_Carrier == null ||
					_Ocean_Carrier.Ocean_Carrier_Cd != Ocean_Carrier_Cd )
					_Ocean_Carrier = ClsOceanCarrier.GetUsingKey(Ocean_Carrier_Cd);
				return _Ocean_Carrier;
			}
			set
			{
				if( _Ocean_Carrier == value ) return;
		
				_Ocean_Carrier = value;
			}
		}

		#endregion	// #region Foreign Key Properties

		#region Constructors

		public ClsImageGpcInvoice() : base() {}
		public ClsImageGpcInvoice(DataRow dr) : base(dr) {}
		public ClsImageGpcInvoice(ClsImageGpcInvoice src) { CopyFrom(src); }

		#endregion		// #region Constructors

		#region Init methods

		public override void ResetColumns()
		{
			Image_Gpc_Invoice_ID = null;
			Create_User = null;
			Create_Dt = null;
			Modify_User = null;
			Modify_Dt = null;
			Active_Flg = null;
			Office_Cd = null;
			Ocean_Carrier_Cd = null;
			Bol_No = null;
			Invoice_No = null;
			Folder_Nm = null;
			File_Nm = null;
		}

		public void CopyFrom(ClsImageGpcInvoice src)
		{
			Image_Gpc_Invoice_ID = src._Image_Gpc_Invoice_ID;
			Create_User = src._Create_User;
			Create_Dt = src._Create_Dt;
			Modify_User = src._Modify_User;
			Modify_Dt = src._Modify_Dt;
			Active_Flg = src._Active_Flg;
			Office_Cd = src._Office_Cd;
			Ocean_Carrier_Cd = src._Ocean_Carrier_Cd;
			Bol_No = src._Bol_No;
			Invoice_No = src._Invoice_No;
			Folder_Nm = src._Folder_Nm;
			File_Nm = src._File_Nm;
		}

		public override bool ReloadFromDB()
		{
			ClsImageGpcInvoice tmp = ClsImageGpcInvoice.GetUsingKey(Image_Gpc_Invoice_ID.Value);
			if( tmp != null ) CopyFrom(tmp);

			ResetFKs();
			OnReload();

			return ( tmp != null );
		}

		public override void ResetFKs()
		{
			_Office = null;
			_Ocean_Carrier = null;
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
				("@OCEAN_CARRIER_CD", Ocean_Carrier_Cd);
			p[3] = Connection.GetParameter
				("@BOL_NO", Bol_No);
			p[4] = Connection.GetParameter
				("@INVOICE_NO", Invoice_No);
			p[5] = Connection.GetParameter
				("@FOLDER_NM", Folder_Nm);
			p[6] = Connection.GetParameter
				("@FILE_NM", File_Nm);
			p[7] = Connection.GetParameter
				("@IMAGE_GPC_INVOICE_ID", Image_Gpc_Invoice_ID, ParameterDirection.Output, DbType.Int64, 0);
			p[8] = Connection.GetParameter
				("@CREATE_USER", Create_User, ParameterDirection.Output, DbType.AnsiStringFixedLength, Create_UserMax);
			p[9] = Connection.GetParameter
				("@CREATE_DT", Create_Dt, ParameterDirection.Output, DbType.DateTime, 0);
			p[10] = Connection.GetParameter
				("@MODIFY_USER", Modify_User, ParameterDirection.Output, DbType.AnsiStringFixedLength, Modify_UserMax);
			p[11] = Connection.GetParameter
				("@MODIFY_DT", Modify_Dt, ParameterDirection.Output, DbType.DateTime, 0);

			const string sql = @"
				INSERT INTO T_IMAGE_GPC_INVOICE
					(IMAGE_GPC_INVOICE_ID, ACTIVE_FLG, OFFICE_CD,
					OCEAN_CARRIER_CD, BOL_NO, INVOICE_NO,
					FOLDER_NM, FILE_NM)
				VALUES
					(IMAGE_GPC_INVOICE_ID_SEQ.NEXTVAL, @ACTIVE_FLG, @OFFICE_CD,
					@OCEAN_CARRIER_CD, @BOL_NO, @INVOICE_NO,
					@FOLDER_NM, @FILE_NM)
				RETURNING
					IMAGE_GPC_INVOICE_ID, CREATE_USER, CREATE_DT,
					MODIFY_USER, MODIFY_DT
				INTO
					@IMAGE_GPC_INVOICE_ID, @CREATE_USER, @CREATE_DT,
					@MODIFY_USER, @MODIFY_DT";
			int ret = Connection.RunSQL(sql, p);

			Image_Gpc_Invoice_ID = ClsConvert.ToInt64Nullable(p[7].Value);
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
				("@OCEAN_CARRIER_CD", Ocean_Carrier_Cd);
			p[4] = Connection.GetParameter
				("@BOL_NO", Bol_No);
			p[5] = Connection.GetParameter
				("@INVOICE_NO", Invoice_No);
			p[6] = Connection.GetParameter
				("@FOLDER_NM", Folder_Nm);
			p[7] = Connection.GetParameter
				("@FILE_NM", File_Nm);
			p[8] = Connection.GetParameter
				("@IMAGE_GPC_INVOICE_ID", Image_Gpc_Invoice_ID);
			p[9] = Connection.GetParameter
				("@MODIFY_USER", Modify_User, ParameterDirection.Output, DbType.AnsiStringFixedLength, Modify_UserMax);

			const string sql = @"
				UPDATE T_IMAGE_GPC_INVOICE SET
					MODIFY_DT = @MODIFY_DT,
					ACTIVE_FLG = @ACTIVE_FLG,
					OFFICE_CD = @OFFICE_CD,
					OCEAN_CARRIER_CD = @OCEAN_CARRIER_CD,
					BOL_NO = @BOL_NO,
					INVOICE_NO = @INVOICE_NO,
					FOLDER_NM = @FOLDER_NM,
					FILE_NM = @FILE_NM
				WHERE
					IMAGE_GPC_INVOICE_ID = @IMAGE_GPC_INVOICE_ID
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
			DbParameter[] p = new DbParameter[0];

			if( p.Length == 0 )
				throw new Exception
					("Cannot delete rows from this table");

			return -1;
		}
		#endregion		// #region Insert, Update, Delete

		#region Conversion methods

		public override void LoadFromDataReader(DbDataReader dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataReader: DataReader parameter was null");

			Image_Gpc_Invoice_ID = ClsConvert.ToInt64Nullable(dr["IMAGE_GPC_INVOICE_ID"]);
			Create_User = ClsConvert.ToString(dr["CREATE_USER"]);
			Create_Dt = ClsConvert.ToDateTimeNullable(dr["CREATE_DT"]);
			Modify_User = ClsConvert.ToString(dr["MODIFY_USER"]);
			Modify_Dt = ClsConvert.ToDateTimeNullable(dr["MODIFY_DT"]);
			Active_Flg = ClsConvert.ToString(dr["ACTIVE_FLG"]);
			Office_Cd = ClsConvert.ToString(dr["OFFICE_CD"]);
			Ocean_Carrier_Cd = ClsConvert.ToString(dr["OCEAN_CARRIER_CD"]);
			Bol_No = ClsConvert.ToString(dr["BOL_NO"]);
			Invoice_No = ClsConvert.ToString(dr["INVOICE_NO"]);
			Folder_Nm = ClsConvert.ToString(dr["FOLDER_NM"]);
			File_Nm = ClsConvert.ToString(dr["FILE_NM"]);
		}

		public override void LoadFromDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("LoadFromDataRow: DataRow parameter was null");

			DataRowVersion v = ( dr.RowState == DataRowState.Deleted )
				? DataRowVersion.Original : DataRowVersion.Current;

			Image_Gpc_Invoice_ID = ClsConvert.ToInt64Nullable(dr["IMAGE_GPC_INVOICE_ID", v]);
			Create_User = ClsConvert.ToString(dr["CREATE_USER", v]);
			Create_Dt = ClsConvert.ToDateTimeNullable(dr["CREATE_DT", v]);
			Modify_User = ClsConvert.ToString(dr["MODIFY_USER", v]);
			Modify_Dt = ClsConvert.ToDateTimeNullable(dr["MODIFY_DT", v]);
			Active_Flg = ClsConvert.ToString(dr["ACTIVE_FLG", v]);
			Office_Cd = ClsConvert.ToString(dr["OFFICE_CD", v]);
			Ocean_Carrier_Cd = ClsConvert.ToString(dr["OCEAN_CARRIER_CD", v]);
			Bol_No = ClsConvert.ToString(dr["BOL_NO", v]);
			Invoice_No = ClsConvert.ToString(dr["INVOICE_NO", v]);
			Folder_Nm = ClsConvert.ToString(dr["FOLDER_NM", v]);
			File_Nm = ClsConvert.ToString(dr["FILE_NM", v]);
		}

		public override void CopyToDataRow(DataRow dr)
		{
			if( dr == null )
				throw new ArgumentException
					("CopyToDataRow: DataRow parameter was null");

			dr["IMAGE_GPC_INVOICE_ID"] = ClsConvert.ToDbObject(Image_Gpc_Invoice_ID);
			dr["CREATE_USER"] = ClsConvert.ToDbObject(Create_User);
			dr["CREATE_DT"] = ClsConvert.ToDbObject(Create_Dt);
			dr["MODIFY_USER"] = ClsConvert.ToDbObject(Modify_User);
			dr["MODIFY_DT"] = ClsConvert.ToDbObject(Modify_Dt);
			dr["ACTIVE_FLG"] = ClsConvert.ToDbObject(Active_Flg);
			dr["OFFICE_CD"] = ClsConvert.ToDbObject(Office_Cd);
			dr["OCEAN_CARRIER_CD"] = ClsConvert.ToDbObject(Ocean_Carrier_Cd);
			dr["BOL_NO"] = ClsConvert.ToDbObject(Bol_No);
			dr["INVOICE_NO"] = ClsConvert.ToDbObject(Invoice_No);
			dr["FOLDER_NM"] = ClsConvert.ToDbObject(Folder_Nm);
			dr["FILE_NM"] = ClsConvert.ToDbObject(File_Nm);
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

		public static ClsImageGpcInvoice GetUsingKey(Int64 Image_Gpc_Invoice_ID)
		{
			object[] vals = new object[] {Image_Gpc_Invoice_ID};
			DataRow dr = Connection.GetDataRowUsingKey
				(TableName, GetPrimaryKeys(), vals);
			return ( dr == null ) ? null : new ClsImageGpcInvoice(dr);
		}
		public static DataTable GetAll(string Office_Cd, string Ocean_Carrier_Cd)
		{
			List<DbParameter> lst = new List<DbParameter>();	
			StringBuilder sb = new StringBuilder();
		
			if( string.IsNullOrEmpty(Office_Cd) == false )
			{
				lst.Add(Connection.GetParameter("@OFFICE_CD", Office_Cd));
				sb.Append(" WHERE T_IMAGE_GPC_INVOICE.OFFICE_CD=@OFFICE_CD");
			}
			if( string.IsNullOrEmpty(Ocean_Carrier_Cd) == false )
			{
				lst.Add(Connection.GetParameter("@OCEAN_CARRIER_CD", Ocean_Carrier_Cd));
				sb.AppendFormat(" {0} T_IMAGE_GPC_INVOICE.OCEAN_CARRIER_CD=@OCEAN_CARRIER_CD",
					sb.Length > 0 ? "AND" : "WHERE");
			}
			sb.Insert(0, SelectSQL);
			return Connection.GetDataTable(sb.ToString(), lst.ToArray());
		}
		#endregion		// #region Static Methods
	}
}