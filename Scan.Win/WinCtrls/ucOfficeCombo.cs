using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using CS2010.CommonWinCtrls;
using CS2010.Common;
using CS2010.SCAN.Business;
using System.Data;
using Janus.Windows.GridEX;

namespace Scan.Win
{
    public partial class ucOfficeCombo : ucMultiColumnCombo
    {
		#region Fields/Properties

		protected bool _DisplayUserOfficesOnly;
		/// <summary>Gets/Sets whether we should only bring back Offices that
		/// the user can see (true) or all Offices (false)</summary>
		[Browsable(true), DefaultValue(false),
		Description("Gets/Sets whether we should only bring back Offices that " +
			"the user can see (true) or all Offices (false)")]
		public bool DisplayUserOfficesOnly
		{
			get { return _DisplayUserOfficesOnly; }
			set
			{
				if (_DisplayUserOfficesOnly == value) return;

				_DisplayUserOfficesOnly = value;
				Reset();
			}
		}

		/// <summary>Gets the selected ClsOffice object</summary>
		[Browsable(false)]
		public ClsOffice SelectedOffice
		{
			get
			{
				DataRowView drv = SelectedItem as DataRowView;
				return (drv != null) ? new ClsOffice(drv.Row) : null;
			}
		}

		/// <summary>Gets the selected Office code</summary>
		[Browsable(false)]
		public string SelectedOfficeCD
		{
			get
			{
				ClsOffice item = SelectedOffice;
				return (item != null) ? item.Office_Cd : null;
			}
		}

		/// <summary>Gets the selected Office name</summary>
		[Browsable(false)]
		public string SelectedDsc
		{
			get
			{
				ClsOffice item = SelectedOffice;
				return (item != null) ? item.Office_Dsc : null;
			}
		}
		#endregion		// #region Fields/Properties

		#region Constructors

		/// <summary>Default Constructor</summary>
		public ucOfficeCombo()
		{
			InitializeComponent();

			_DisplayUserOfficesOnly = false;

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
			GridEXColumn c = DropDownList.Columns.Add("Office_Cd");
			c.DataMember = "Office_Cd";
			c.Caption = "Office";

			c = DropDownList.Columns.Add("Office_Dsc");
			c.DataMember = "Office_Dsc";
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

            DataTable dt = mgr.GetListOfOffices();

			if (dt != null) ClsConnection.AddColumns(dt, "Office_Cd", "Office_Dsc");

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
					Display.ShowError("Scan", "Specified Office is not in the list");
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
