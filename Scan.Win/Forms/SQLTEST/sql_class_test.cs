using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS2010.Common;

namespace Scan.Win
{

    class sql_class_test : sql_base
    {
        protected override string connection_key
        {
            get { return "CLASS"; }
        }

        protected override string base_query
        {
            get { return "SELECT * FROM T_ORDER"; }
        }




    }
}
