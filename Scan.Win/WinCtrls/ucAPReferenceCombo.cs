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
    public partial class ucAPReferenceCombo : ucMultiColumnCombo
    {
		#region Fields/Properties

		protected bool _DisplayUserAPReferencesOnly;
		/// <summary>Gets/Sets whether we should only bring back APReferences that
		/// the user can see (true) or all APReferences (false)</summary>
		[Browsable(true), DefaultValue(false),
		Description("Gets/Sets whether we should only bring back APReferences that " +
			"the user can see (true) or all APReferences (false)")]
		public bool DisplayUserAPReferencesOnly
		{
			get { return _DisplayUserAPReferencesOnly; }
			set
			{
				if (_DisplayUserAPReferencesOnly == value) return;

				_DisplayUserAPReferencesOnly = value;
				Reset();
			}
		}

		/// <summary>Gets the selected ClsAPReference object</summary>
        //[Browsable(false)]
        //public string SelectedAPReference
        //{
        //    get
        //    {
        //        DataRowView drv = SelectedItem as DataRowView;
        //        return (drv != null) ? drv["Reference_account_nm"].ToString() : null;
        //    }
        //}

		/// <summary>Gets the selected APReference code</summary>
		[Browsable(false)]
		public string SelectedAPReference
		{
			get
			{
                DataRowView drv = SelectedItem as DataRowView;
                return (drv != null) ? drv["reference_no"].ToString() : null;
			}
		}

        ///// <summary>Gets the selected APReference name</summary>
        [Browsable(false)]
        public string SelectedDsc
        {
            get
            {
                DataRowView drv = SelectedItem as DataRowView;
                return (drv != null) ? drv["reference_dsc"].ToString() : null;
            }
        }
		#endregion		// #region Fields/Properties

		#region Constructors

		/// <summary>Default Constructor</summary>
		public ucAPReferenceCombo()
		{
			InitializeComponent();

			_DisplayUserAPReferencesOnly = false;

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
            GridEXColumn c = DropDownList.Columns.Add("reference_no");
            c.DataMember = "reference_no";
			c.Caption = "Reference #";

            c = DropDownList.Columns.Add("reference_dsc");
            c.DataMember = "reference_dsc";
            c.Caption = "Reference No";
            c.Visible = false;

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

            DataTable dt = mgr.GetListOfAPReferenceNo();

            if (dt != null) ClsConnection.AddColumns(dt, "reference_no", "reference_dsc");

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
					Display.ShowError("Scan", "Specified Reference # is not in the list");
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
