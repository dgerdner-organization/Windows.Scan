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
    public partial class ucAPVendorCombo : ucMultiColumnCombo
    {
		#region Fields/Properties

		protected bool _DisplayUserAPVendorsOnly;
		/// <summary>Gets/Sets whether we should only bring back APVendors that
		/// the user can see (true) or all APVendors (false)</summary>
		[Browsable(true), DefaultValue(false),
		Description("Gets/Sets whether we should only bring back APVendors that " +
			"the user can see (true) or all APVendors (false)")]
		public bool DisplayUserAPVendorsOnly
		{
			get { return _DisplayUserAPVendorsOnly; }
			set
			{
				if (_DisplayUserAPVendorsOnly == value) return;

				_DisplayUserAPVendorsOnly = value;
				Reset();
			}
		}

		/// <summary>Gets the selected ClsAPVendor object</summary>
		[Browsable(false)]
		public string SelectedAPVendor
		{
			get
			{
				DataRowView drv = SelectedItem as DataRowView;
				return (drv != null) ? drv["vendor_account_nm"].ToString() : null;
			}
		}

		/// <summary>Gets the selected APVendor code</summary>
		[Browsable(false)]
		public string SelectedAPVendorCD
		{
			get
			{
                DataRowView drv = SelectedItem as DataRowView;
                return (drv != null) ? drv["vendor_account_cd"].ToString() : null;
			}
		}

        ///// <summary>Gets the selected APVendor name</summary>
        //[Browsable(false)]
        //public string SelectedDsc
        //{
        //    get
        //    {
        //        ClsAPVendor item = SelectedAPVendor;
        //        return (item != null) ? item.APVendor_Dsc : null;
        //    }
        //}
		#endregion		// #region Fields/Properties

		#region Constructors

		/// <summary>Default Constructor</summary>
		public ucAPVendorCombo()
		{
			InitializeComponent();

			_DisplayUserAPVendorsOnly = false;

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
   
            GridEXColumn c = DropDownList.Columns.Add("vendor_account_cd");
            c.DataMember = "vendor_account_cd";
			c.Caption = "Vendor Code";

            c = DropDownList.Columns.Add("vendor_account_nm");
            c.DataMember = "vendor_account_nm";
			c.Caption = "Vendor Name";
			c.Width = 250;

            //c = DropDownList.Columns.Add("Active_Flg");
            //c.DataMember = "Active_Flg";
            //c.Caption = "Active";
            //c.Visible = false;
            //c.Width = 65;
            //c.HeaderAlignment = TextAlignment.Center;

            //c.ColumnType = ColumnType.CheckBox;
            //c.EditType = EditType.CheckBox;

            //c.CheckBoxTrueValue = "Y";
            //c.CheckBoxFalseValue = "N";

			DropDownList.VisibleRows = 20;

		}

		private void SetTableSource()
		{
			if( ClsEnvironment.IsDesignMode == true ) return;

            mgrReference mgr = new mgrReference();

            DataTable dt = mgr.GetListOfAPVendors();

            if (dt != null) ClsConnection.AddColumns(dt, "vendor_account_cd", "vendor_account_nm");

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
					Display.ShowError("Scan", "Specified APVendor is not in the list");
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
