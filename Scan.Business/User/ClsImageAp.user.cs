﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS2010.Common;
using System.Data.Common;
using System.Data;

namespace CS2010.SCAN.Business
{
    public partial class ClsImageAp
    {

        public ClsImageAp(string fileName)
        {
            string temp = fileName.Replace("[", "");
            string[] s = temp.Split(']');

            Office_Cd = s[1].ToString();
            Sun_Database_Cd = s[2].ToString();
            Check_No = s[3].ToString();
            Invoice_Amt = Convert.ToDecimal(s[4]);
            Folder_Nm = ClsScanEnvironment.ImageAPFolder;
            File_Nm = System.IO.Path.GetFileName(fileName);
            Active_Flg = "Y";

        }

        public new ClsResult ValidateUpdate()
        {
            ClsResult r = new ClsResult();

            if (this.Office_Cd.IsNull()) r.ErrMsgAdd("Office Code is not valid.");
            if (this.Sun_Database_Cd.IsNull()) r.ErrMsgAdd("Database Code is not valid.");
            if (this.Check_No.IsNull()) r.ErrMsgAdd("Check # is not valid.");
            if (this.Invoice_Amt < 1) r.ErrMsgAdd("Invoice Amount is not valid.");

            return r;
        }
        public string FullFileName
        {
            get
            {
                return string.Format(@"{0}\{1}", this.Folder_Nm, this.File_Nm);
            }
        }

        public static ClsImageAp GetByFileName(string fileName)
        {
            string sql = "Select * from t_image_ap ap where ap.file_nm = @FILE_NM";

            List<DbParameter> p = new List<DbParameter>();
            p.Add( Connection.GetParameter("@FILE_NM", fileName));

            DataRow dr = Connection.GetDataRow(sql, p.ToArray());

            if (dr.IsNull()) return null;

            return new ClsImageAp(dr);

        }


    }
}
