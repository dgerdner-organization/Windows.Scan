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
    public partial class ucSecurityFeatureCombo : ucMultiColumnCombo
    {
		#region Fields/Properties

		protected bool _DisplaySecurityFeatureSecurityFeaturesOnly;
		/// <summary>Gets/Sets whether we should only bring back SecurityFeatures that
		/// the SecurityFeature can see (true) or all SecurityFeatures (false)</summary>
		[Browsable(true), DefaultValue(false),
		Description("Gets/Sets whether we should only bring back SecurityFeatures that " +
			"the SecurityFeature can see (true) or all SecurityFeatures (false)")]
		public bool DisplaySecurityFeatureSecurityFeaturesOnly
		{
			get { return _DisplaySecurityFeatureSecurityFeaturesOnly; }
			set
			{
				if (_DisplaySecurityFeatureSecurityFeaturesOnly == value) return;

				_DisplaySecurityFeatureSecurityFeaturesOnly = value;
				Reset();
			}
		}

		/// <summary>Gets the selected ClsSecurityFeature object</summary>
		[Browsable(false)]
		public ClsSecurityFeature SelectedSecurityFeature
		{
			get
			{
				DataRowView drv = SelectedItem as DataRowView;
				return (drv != null) ? new ClsSecurityFeature(drv.Row) : null;
			}
		}

		/// <summary>Gets the selected SecurityFeature code</summary>
		[Browsable(false)]
		public string SelectedSecurityFeatureCD
		{
			get
			{
				ClsSecurityFeature item = SelectedSecurityFeature;
				return (item != null) ? item.Security_Feature_Cd : null;
			}
		}

        ///// <summary>Gets the selected SecurityFeature name</summary>
        //[Browsable(false)]
        //public string SelectedDsc
        //{
        //    get
        //    {
        //        ClsSecurityFeature item = SelectedSecurityFeature;
        //        return (item != null) ? item.SecurityFeature_Dsc : null;
        //    }
        //}
		#endregion		// #region Fields/Properties

		#region Constructors

		/// <summary>Default Constructor</summary>
		public ucSecurityFeatureCombo()
		{
			InitializeComponent();

			_DisplaySecurityFeatureSecurityFeaturesOnly = false;

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
            GridEXColumn c = DropDownList.Columns.Add("Security_Feature_CD");
            c.DataMember = "Security_Feature_Cd";
            c.Caption = "SecurityFeature";
            c.Visible = false;
            c.Width = 0;

            c = DropDownList.Columns.Add("Security_Dsc");
			c.DataMember = "Security_Dsc";
			c.Caption = "Description";
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

            DataTable dt = mgr.GetListOfSecurityFeatures();

            if (dt != null) ClsConnection.AddColumns(dt, "Security_Feature_CD", "Security_Dsc");

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
					Display.ShowError("Scan", "Specified Security Feature is not in the list");
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
