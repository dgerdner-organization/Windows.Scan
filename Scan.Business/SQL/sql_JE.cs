using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS2010.Common;

namespace Scan.Business
{
    public class sql_JE : sql_base
    {
        protected override string connection_key
        {
            get { return "SCAN"; }
        }

        protected override string base_query
        {
            get
            {
                return @"
                    Select 
                    sje.*,
                    je.folder_nm, 
                    je.file_nm,
                    je.office_cd as true_office_cd,
                    je.image_je_id
 
                    from t_image_je je
                    inner join t_sun_je sje on sje.sun_je_id = je.sun_je_id
                    where 1=1
                    and je.active_flg = 'Y'
                    and sje.active_flg = 'Y'
                    [WHERE]
                    order by sje.create_dt";
            }

        }

        public void RunIt(JESearchArguments je)
        {
            StringBuilder sqlWhere = new StringBuilder();

            if (je.SunDatabaseCd.IsNotNull())
                sqlWhere.AppendFormat(" and sje.database_code = '{0}'", je.SunDatabaseCd);

            if (je.JournalNo.IsNotNull())
                sqlWhere.AppendFormat(" and sje.journal_no like '{0}'", je.JournalNo);

            if (je.JournalSource.IsNotNull())
                sqlWhere.AppendFormat(" and sje.journal_source like '{0}'", je.JournalSource);

            if (je.JournalType.IsNotNull())
                sqlWhere.AppendFormat(" and sje.journal_type like '{0}'", je.JournalType);

            if (je.AccountingPeriod.IsNotNull())
                sqlWhere.AppendFormat(" and sje.accounting_period like '{0}'", je.AccountingPeriod);

            if (je.EntryDateFrom.IsNotNull())
                sqlWhere.AppendFormat(" and trunc(sje.entry_dt) >= {0}", ((DateTime)je.EntryDateFrom).FormatToOracleDate());

            if (je.EntryDateTo.IsNotNull())
                sqlWhere.AppendFormat(" and trunc(sje.entry_dt) <= {0} ", ((DateTime)je.EntryDateTo).FormatToOracleDate());

            if (je.ExcludeSun4)
                sqlWhere.AppendFormat(" and sje.sun_version_no != 4"); 

            RunWhere(sqlWhere.ToString());

        }
    }

    public class JESearchArguments
    {
        public string SunDatabaseCd { get; set; }
        public string JournalNo { get; set; }
        public string JournalSource { get; set; }
        public string JournalType { get; set; }
        public string AccountingPeriod { get; set; }
        public DateTime? EntryDateFrom { get; set; }
        public DateTime? EntryDateTo { get; set; }
        public bool ExcludeSun4 { get; set; }

    }
}
