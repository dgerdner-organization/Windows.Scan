using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using CS2010.CommonWinCtrls;
using CS2010.SCAN.Business;
using System.Data;
using CS2010.Common;
using Janus.Windows.GridEX;

namespace Scan.Win
{
    public partial class ucUserCombo : ucMultiColumnCombo
    {
		#region Fields/Properties

		protected bool _DisplayUserUsersOnly;
		/// <summary>Gets/Sets whether we should only bring back Users that
		/// the user can see (true) or all Users (false)</summary>
		[Browsable(true), DefaultValue(false),
		Description("Gets/Sets whether we should only bring back Users that " +
			"the user can see (true) or all Users (false)")]
		public bool DisplayUserUsersOnly
		{
			get { return _DisplayUserUsersOnly; }
			set
			{
				if (_DisplayUserUsersOnly == value) return;

				_DisplayUserUsersOnly = value;
				Reset();
			}
		}

		/// <summary>Gets the selected ClsUser object</summary>
		[Browsable(false)]
		public ClsUser SelectedUser
		{
			get
			{
				DataRowView drv = SelectedItem as DataRowView;
				return (drv != null) ? new ClsUser(drv.Row) : null;
			}
		}

		/// <summary>Gets the selected User code</summary>
		[Browsable(false)]
		public long? SelectedUserID
		{
			get
			{
				ClsUser item = SelectedUser;
				return (item != null) ? item.User_ID : null;
			}
		}

        ///// <summary>Gets the selected User name</summary>
        //[Browsable(false)]
        //public string SelectedDsc
        //{
        //    get
        //    {
        //        ClsUser item = SelectedUser;
        //        return (item != null) ? item.User_Dsc : null;
        //    }
        //}
		#endregion		// #region Fields/Properties

		#region Constructors

		/// <summary>Default Constructor</summary>
		public ucUserCombo()
		{
			InitializeComponent();

			_DisplayUserUsersOnly = false;

			SetTableSource();

			CreateStructure();

		}
		#endregion		// #region Constructors

		#region Public Methods

		public void Reset()
		{
			if( ClsEnvironment.IsDesignMode == true ) return;

			SetTableSource();
		}
		#endregion		// #region Public Methods

		#region Helper Methods

		private void CreateStructure()
		{
            GridEXColumn c = DropDownList.Columns.Add("USER_ID");
            c.DataMember = "User_Id";
            c.Caption = "User";
            c.Visible = false;
            c.Width = 0;

            c = DropDownList.Columns.Add("DOMAIN_NM");
			c.DataMember = "User_Dsc";
			c.Caption = "Description";
			c.Width = 250;

            c = DropDownList.Columns.Add("Active_Flg");
            c.DataMember = "Active_Flg";
            c.Caption = "Active";
            c.Visible = false;
            c.Width = 65;
            c.HeaderAlignment = TextAlignment.Center;

            c.ColumnType = ColumnType.CheckBox;
            c.EditType = EditType.CheckBox;

            c.CheckBoxTrueValue = "Y";
            c.CheckBoxFalseValue = "N";

			DropDownList.VisibleRows = 20;

		}

		private void SetTableSource()
		{
			if( ClsEnvironment.IsDesignMode == true ) return;

            mgrReference mgr = new mgrReference();

            DataTable dt = mgr.GetListOfUsers();

			if (dt != null) ClsConnection.AddColumns(dt, "USER_ID", "DOMAIN_NM");

			if (Table != null)
			{
				Table.Dispose();
				Table = null;
			}

			Table = dt;
		}
		#endregion		// #region Helper Methods

		#region Overrides

		protected override void SetDataSource(object aValue)
		{
			// JR: We keep track of the data source internally,
			// so do not allow it to be overwritten
		}

		protected override void OnValidating(CancelEventArgs e)
		{
			try
			{
				if( NotInList == true )
				{
					e.Cancel = true;
					Display.ShowError("Scan", "Specified User is not in the list");
				}
				else if( DroppedDown == true )
					e.Cancel = true;
			}
			catch( Exception ex )
			{
				Display.ShowError("Scan", ex);
			}
			base.OnValidating(e);
		}
		#endregion		// #region Overrides
    }
}
