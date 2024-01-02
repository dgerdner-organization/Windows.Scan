using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using CS2010.CommonWinCtrls;
using CS2010.SCAN.Business;
using System.Data;
using Janus.Windows.GridEX;
using CS2010.Common;

namespace Scan.Win
{
    public partial class ucSecurityGroupCombo : ucMultiColumnCombo
    {
		#region Fields/Properties

		protected bool _DisplaySecurityGroupSecurityGroupsOnly;
		/// <summary>Gets/Sets whether we should only bring back SecurityGroups that
		/// the SecurityGroup can see (true) or all SecurityGroups (false)</summary>
        //[Browsable(true), DefaultValue(false),
        //Description("Gets/Sets whether we should only bring back SecurityGroups that " +
        //    "the SecurityGroup can see (true) or all SecurityGroups (false)")]
        //public bool DisplaySecurityGroupSecurityGroupsOnly
        //{
        //    get { return _DisplaySecurityGroupSecurityGroupsOnly; }
        //    set
        //    {
        //        if (_DisplaySecurityGroupSecurityGroupsOnly == value) return;

        //        _DisplaySecurityGroupSecurityGroupsOnly = value;
        //        Reset();
        //    }
        //}

		/// <summary>Gets the selected ClsSecurityGroup object</summary>
		[Browsable(false)]
		public ClsSecurityGroup SelectedSecurityGroup
		{
			get
			{
				DataRowView drv = SelectedItem as DataRowView;
				return (drv != null) ? new ClsSecurityGroup(drv.Row) : null;
			}
		}

		/// <summary>Gets the selected SecurityGroup code</summary>
		[Browsable(false)]
		public long? SelectedSecurityGroupID
		{
			get
			{
				ClsSecurityGroup item = SelectedSecurityGroup;
				return (item != null) ? item.Security_Group_ID : null;
			}
		}

        ///// <summary>Gets the selected SecurityGroup name</summary>
        [Browsable(false)]
        public string SelectedDsc
        {
            get
            {
                ClsSecurityGroup item = SelectedSecurityGroup;
                return (item != null) ? item.Security_Group_Dsc : null;
            }
        }
		#endregion		// #region Fields/Properties

		#region Constructors

		/// <summary>Default Constructor</summary>
		public ucSecurityGroupCombo()
		{
			InitializeComponent();

			_DisplaySecurityGroupSecurityGroupsOnly = false;

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
            GridEXColumn c = DropDownList.Columns.Add("Security_Group_ID");
            c.DataMember = "Security_Group_Id";
            c.Caption = "SecurityGroup";
            c.Visible = false;
            c.Width = 0;

            c = DropDownList.Columns.Add("Security_Group_Dsc");
			c.DataMember = "Security_Group_Dsc";
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

            DataTable dt = mgr.GetListOfSecurityGroups();

            if (dt != null) ClsConnection.AddColumns(dt, "Security_Group_ID", "Security_Group_Dsc");

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
					Display.ShowError("Scan", "Specified Security Group is not in the list");
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
