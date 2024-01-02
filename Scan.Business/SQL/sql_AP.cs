using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS2010.Common;

namespace Scan.Business 
{
    public class sql_AP : sql_base
    {
        protected override string connection_key
        {
            get { return "SCAN"; }
        }

        protected override string base_query
        {
            get
            {
                return @"Select 
                    sap.*,
                    ap.check_no as ap_check_no,
                    ap.folder_nm, 
                    ap.file_nm,
                    ap.office_cd as true_office_cd,
                    ap.image_ap_id
 
                    from t_image_ap ap
                    inner join t_sun_ap sap on sap.sun_ap_id = ap.sun_ap_id
                    where 1=1
                    and ap.active_flg = 'Y'
                    and sap.active_flg = 'Y'
                    [WHERE]
                    order by sap.create_dt ";
            }
        }

        public void RunIt(APSearchArguments sa)
        {
            StringBuilder sqlWhere = new StringBuilder();

            if (sa.VendorCd.IsNotNull())
                sqlWhere.AppendFormat(" and sap.vendor_account_cd = '{0}'", sa.VendorCd);

            if (sa.SunDatabaseCd.IsNotNull())
                sqlWhere.AppendFormat(" and sap.database_code = '{0}'", sa.SunDatabaseCd);

            if (sa.ReferenceNo.IsNotNull())
                sqlWhere.AppendFormat(" and sap.reference_no = '{0}'", sa.ReferenceNo);

            if (sa.CheckNo.IsNotNull())
                sqlWhere.AppendFormat(" and ap.check_no like '{0}'", sa.CheckNo);

            if (sa.InvoiceDateFrom.IsNotNull())
                sqlWhere.AppendFormat(" and trunc(sap.invoice_dt) >= {0} ", ((DateTime)sa.InvoiceDateFrom).FormatToOracleDate());

            if (sa.InvoiceDateTo.IsNotNull())
                sqlWhere.AppendFormat(" and trunc(sap.invoice_dt) <= {0} ",  ((DateTime)sa.InvoiceDateTo).FormatToOracleDate());

            if (sa.CheckDateFrom.IsNotNull())
                sqlWhere.AppendFormat(" and trunc(sap.check_dt) >= {0} ",  ((DateTime)sa.CheckDateFrom).FormatToOracleDate());

            if (sa.CheckDateTo.IsNotNull())
                sqlWhere.AppendFormat(" and trunc(sap.check_dt) <= {0} ",  ((DateTime)sa.CheckDateTo).FormatToOracleDate());

            if (sa.ExcludeSun4)
                sqlWhere.AppendFormat(" and sap.sun_version_no != 4"); 

            RunWhere(sqlWhere.ToString());

        }
    }

    public class APSearchArguments
    {
        public string VendorCd { get; set; }
        public string SunDatabaseCd { get; set; }
        public string ReferenceNo { get; set; }
        public string CheckNo { get; set; }
        public DateTime? InvoiceDateFrom { get; set; }
        public DateTime? InvoiceDateTo { get; set; }
        public DateTime? CheckDateFrom { get; set; }
        public DateTime? CheckDateTo { get; set; }
        public bool ExcludeSun4 { get; set; }

    }
}
