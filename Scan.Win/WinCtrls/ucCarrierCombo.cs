using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using CS2010.SCAN.Business;
using System.Data;
using CS2010.CommonWinCtrls;
using CS2010.Common;
using Janus.Windows.GridEX;

namespace Scan.Win
{
    public partial class ucOceanCarrierCombo : ucMultiColumnCombo
    {
		#region Fields/Properties

		protected bool _DisplayUserOceanCarriersOnly;
		/// <summary>Gets/Sets whether we should only bring back OceanCarriers that
		/// the user can see (true) or all OceanCarriers (false)</summary>
		[Browsable(true), DefaultValue(false),
		Description("Gets/Sets whether we should only bring back Ocean Carriers that " +
			"the user can see (true) or all Ocean Carriers (false)")]
		public bool DisplayUserOceanCarriersOnly
		{
			get { return _DisplayUserOceanCarriersOnly; }
			set
			{
				if (_DisplayUserOceanCarriersOnly == value) return;

				_DisplayUserOceanCarriersOnly = value;
				Reset();
			}
		}

		/// <summary>Gets the selected ClsOceanCarrier object</summary>
		[Browsable(false)]
		public ClsOceanCarrier SelectedOceanCarrier
		{
			get
			{
				DataRowView drv = SelectedItem as DataRowView;
				return (drv != null) ? new ClsOceanCarrier(drv.Row) : null;
			}
		}

		/// <summary>Gets the selected OceanCarrier code</summary>
		[Browsable(false)]
		public string SelectedOceanCarrierCD
		{
			get
			{
				ClsOceanCarrier item = SelectedOceanCarrier;
				return (item != null) ? item.Ocean_Carrier_Cd : null;
			}
		}

		/// <summary>Gets the selected OceanCarrier name</summary>
		[Browsable(false)]
		public string SelectedDsc
		{
			get
			{
				ClsOceanCarrier item = SelectedOceanCarrier;
				return (item != null) ? item.Ocean_Carrier_Dsc : null;
			}
		}
		#endregion		// #region Fields/Properties

		#region Constructors

		/// <summary>Default Constructor</summary>
		public ucOceanCarrierCombo()
		{
			InitializeComponent();

			_DisplayUserOceanCarriersOnly = false;

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
			GridEXColumn c = DropDownList.Columns.Add("Ocean_Carrier_Cd");
			c.DataMember = "Ocean_Carrier_Cd";
			c.Caption = "Carrier";

			c = DropDownList.Columns.Add("Ocean_Carrier_Dsc");
			c.DataMember = "Ocean_Carrier_Dsc";
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

            DataTable dt = mgr.GetListOfOceanCarriers();

			if (dt != null) ClsConnection.AddColumns(dt, "Ocean_Carrier_Cd", "Ocean_Carrier_Dsc");

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
					Display.ShowError("Scan", "Specified Ocean Carrier is not in the list");
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
