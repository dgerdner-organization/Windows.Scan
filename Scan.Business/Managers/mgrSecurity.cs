using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scan.Business
{
    public static class mgrSecurity
    {
        public static bool AllowFeature(string userName, string securityFeatureCd, bool scanMode)
        {
            if (scanMode)
            {
                
            }
            else
            {
                if (securityFeatureCd == "SCAN") return false;




            }



            return true;
        }

    }
}
