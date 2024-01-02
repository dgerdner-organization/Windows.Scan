using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CS2010.SCAN.Business;
using CS2010.Common;
using System.IO;

namespace Scan.Business
{
    public class mgrImportSunFiles : mgrBase
    {
        public delegate void ImportSunHandler(object sender, ImportSunFileEventArgs e);
        public event ImportSunHandler ImportSunEvent;

        public List<string> ImportSunAPFile(string fileName, ClsOffice CurrentOffice) 
        {

            string line;
            string[] parsedline;
            ClsSunAp ap;
            List<string> lst = new List<string>();
            int counter = 0;
            int NumberGood = 0;
            int NumberBad = 0;

            StreamReader sr = new StreamReader(fileName);

            //Connection.TransactionBegin();

            try
            {

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    parsedline = line.Split('|');
                    ap = new ClsSunAp()
                    {
                        Office_Cd = CurrentOffice.Office_Cd,
                        Database_Code = parsedline[0].ToString(),
                        Journal_Entry = parsedline[1].ToString(),
                        Reference_No = parsedline[2].ToString(),
                        Vendor_Account_Cd = parsedline[3].ToString(),
                        Vendor_Account_Nm = parsedline[4].ToString(),
                        Invoice_Amt = Convert.ToDecimal(parsedline[5]),
                        Entry_User = parsedline[6],
                        Invoice_Dt = parsedline[7].ToDateYYYYMMDD(),
                        Check_Dt = parsedline[8].ToDateYYYYMMDD(),
                        Sun_Version_No = 5,
                        Active_Flg = "Y",
                        Matched_Flg = "N"
                    };
                    try
                    {
                        if (ap.Insert() == 1)
                            NumberGood++;
                        else
                        {
                            NumberBad++;
                            lst.Add("Insert failed without an error message.");
                        }
                    }
                    catch (Exception ex)
                    {
                        NumberBad++;
                        lst.Add(string.Format("Insert failed ... Database_Code={0}, Journal_Entry{1}, Reference_No={2} ... Err={3}.",
                            parsedline[0].ToString(),
                            parsedline[1].ToString(),
                            parsedline[2].ToString(),
                            ex.Message));
                    }
                    counter++;
                    ImportSunEvent(null, new ImportSunFileEventArgs() { Number = counter, Complete=false } );
                }

                ImportSunEvent(null, new ImportSunFileEventArgs() { Number = counter, NumberGood = NumberGood, NumberBad = NumberBad, Complete = true });

                //if (NumberBad > 1)
                //    Connection.TransactionRollback();
                //else 
                //    Connection.TransactionCommit();

                return lst;
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                ClsScanEnvironment.Audit(ex.Message);
                //Connection.TransactionRollback();
                throw;
            }
        }

        public List<string> ImportSunJEFile(string fileName, ClsOffice CurrentOffice)
        {
            string line;
            string[] parsedline;
            ClsSunJe je;
            List<string> lst = new List<string>();
            int counter = 0;
            int good = 0;
            int bad = 0;

            StreamReader sr = new StreamReader(fileName);

            //Connection.TransactionBegin();

            try
            {
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    parsedline = line.Split('|');
                    je = new ClsSunJe()
                    {
                        Office_Cd = CurrentOffice.Office_Cd,
                        Database_Code = parsedline[0].ToString(),
                        Journal_No = parsedline[12].ToString(),
                        Journal_Source = parsedline[23].ToString(),
                        Entry_Dt = parsedline[3].ToDateYYYYMMDD(),
                        Accounting_Period = parsedline[20].ToString(),
                        Sun_Version_No = 5,
                        Active_Flg = "Y",
                        Matched_Flg = "N"
                    };
                    try
                    {
                        if (je.Insert() == 1)
                            good++;
                        else
                        {
                            bad++;
                            lst.Add("Insert failed without an error message.");
                        }
                    }
                    catch (Exception ex)
                    {
                        bad++;
                        lst.Add(string.Format("Insert failed ... Database_Code={0}, Journal_No{1} ... Err={2}.",
                            parsedline[0].ToString(),
                            parsedline[12].ToString(),
                            ex.Message));
                    }
                    counter++;
                    ImportSunEvent(null, new ImportSunFileEventArgs() { Number = counter, Complete = false } );
                }

                ImportSunEvent(null, new ImportSunFileEventArgs() { Number = counter, NumberGood = good, NumberBad = bad, Complete = true });

                //if (bad > 1)
                //    Connection.TransactionRollback();
                //else
                //    Connection.TransactionCommit();

                return lst;
            }
            catch (Exception ex)
            {
                ClsErrorHandler.LogException(ex);
                ClsScanEnvironment.Audit(ex.Message);
                //Connection.TransactionRollback();
                throw;
            }
        }
    }

    public class ImportSunFileEventArgs
    {
        public int Number = 0;
        public int NumberGood = 0;
        public int NumberBad = 0;
        public bool Complete = false;
    }

}
