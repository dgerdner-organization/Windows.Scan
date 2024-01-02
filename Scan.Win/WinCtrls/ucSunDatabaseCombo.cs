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
    public partial class ucSunDatabaseCombo : ucMultiColumnCombo
    {
		#region Fields/Properties

		protected bool _DisplayUserSunDatabasesOnly;
		/// <summary>Gets/Sets whether we should only bring back SunDatabases that
		/// the user can see (true) or all SunDatabases (false)</summary>
		[Browsable(true), DefaultValue(false),
		Description("Gets/Sets whether we should only bring back  SunDatabases that " +
			"the user can see (true) or all  SunDatabases (false)")]
		public bool DisplayUserSunDatabasesOnly
		{
			get { return _DisplayUserSunDatabasesOnly; }
			set
			{
				if (_DisplayUserSunDatabasesOnly == value) return;

				_DisplayUserSunDatabasesOnly = value;
				Reset();
			}
		}

		/// <summary>Gets the selected ClsSunDatabase object</summary>
		[Browsable(false)]
		public ClsSunDatabase SelectedSunDatabase
		{
			get
			{
				DataRowView drv = SelectedItem as DataRowView;
				return (drv != null) ? new ClsSunDatabase(drv.Row) : null;
			}
		}

		/// <summary>Gets the selected SunDatabase code</summary>
		[Browsable(false)]
		public string SelectedSunDatabaseCD
		{
			get
			{
				ClsSunDatabase item = SelectedSunDatabase;
				return (item != null) ? item.Sun_Database_Cd : null;
			}
		}

		/// <summary>Gets the selected SunDatabase name</summary>
		[Browsable(false)]
		public string SelectedDsc
		{
			get
			{
				ClsSunDatabase item = SelectedSunDatabase;
				return (item != null) ? item.Sun_Database_Dsc : null;
			}
		}
		#endregion		// #region Fields/Properties

		#region Constructors

		/// <summary>Default Constructor</summary>
		public ucSunDatabaseCombo()
		{
			InitializeComponent();

			_DisplayUserSunDatabasesOnly = false;

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
			GridEXColumn c = DropDownList.Columns.Add("Sun_Database_Cd");
			c.DataMember = "Sun_Database_Cd";
			c.Caption = "Sun Database";

			c = DropDownList.Columns.Add("Sun_Database_Dsc");
			c.DataMember = "Sun_Database_Dsc";
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

            DataTable dt = mgr.GetListOfSunDatabases();

			if (dt != null) ClsConnection.AddColumns(dt, "Sun_Database_Cd", "Sun_Database_Dsc");

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
					Display.ShowError("Scan", "Specified  Sun_Database is not in the list");
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
