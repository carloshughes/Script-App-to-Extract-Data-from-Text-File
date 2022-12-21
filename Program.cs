using System;
using System.IO;
using System.Collections.Generic;

namespace ReadATextFile
{
    class Program
    {
       
        //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE   
        static readonly string textFile = @"C:\Temp\SAMPLE-FILE.txt";
        static readonly string pathFR = @"C:\Temp\FinalResult.csv";

        static void Main(string[] args)
        {
            List<string> NewlistText = new List<string>();

            string Country = "Country";
            string FullName = "Full Name";
            string EmailAddress = "Email Address";
            string PhoneNumber = "Phone Number";
            string NameLogo = "Name in Logo";

            if (File.Exists(pathFR))
            {
                File.Delete(pathFR);
            }


            if (File.Exists(textFile))
            {
                // Read a text file line by line.  
                string[] lines = File.ReadAllLines(textFile);
                List<string> listText = new List<string>();

                foreach (string line in lines)
                {
                    listText.Add(line);
                }

                foreach (var a in listText)
                {
                    if (a.Contains(Country)) { NewlistText.Add(a); }
                    if (a.Contains(FullName)) { NewlistText.Add(a); }
                    if (a.Contains(EmailAddress)) { NewlistText.Add(a); }
                    if (a.Contains(PhoneNumber)) { NewlistText.Add(a); }
                    if (a.Contains(NameLogo))       {NewlistText.Add(a);}
                }





                if (!File.Exists(pathFR))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(pathFR))
                    {
                       sw.Write("{0}" + "," + "\t{1}" + ","+ "\t{2}" + ","+ "\t{3}" + "," + "\t{4}", Country, FullName, EmailAddress, PhoneNumber, NameLogo);
                       Console.Write("{0}" + "," + "\t{1}" + "," + "\t{2}" + "," + "\t{3}" + "," + "\t{4}", Country, FullName, EmailAddress, PhoneNumber, NameLogo);


                        foreach (var b in NewlistText)
                    {
                        if (b.Contains("Country"))
                        {
                            int startIndexc = 7;
                            int lengthc = b.Length;
                            Console.Write("{0} \t", b.Substring(startIndexc, (b.Length - startIndexc))+ ",");
                            sw.Write("{0} \t", b.Substring(startIndexc, (b.Length - startIndexc)) + ",");
                        }

                        if (b.Contains("Full Name"))
                        {
                           int startIndexfn = 9;
                           int lengthfn = b.Length;
                           Console.Write("{0} \t", b.Substring(startIndexfn, (b.Length - startIndexfn)) + ",");
                           sw.Write("{0} \t", b.Substring(startIndexfn, (b.Length - startIndexfn)) + ",");
                        }

                        if (b.Contains("Email Address"))
                        {
                          int startIndexea = 13;
                          int lengthea = b.Length;
                          Console.Write("{0} \t", b.Substring(startIndexea, (b.Length - startIndexea)) + ",");
                          sw.Write("{0} \t", b.Substring(startIndexea, (b.Length - startIndexea)) + ",");
                        }

                        if (b.Contains("Phone Number"))
                        {
                          int startIndexpn = 12;
                          int lengthpn = b.Length;
                          Console.Write("{0} \t", b.Substring(startIndexpn, (b.Length - startIndexpn)) + ",");
                          sw.Write("{0} \t", b.Substring(startIndexpn, (b.Length - startIndexpn)) + ",");
                        }

                        if (b.Contains("Name in Logo"))
                        {
                         int startIndexnl = 12;
                         int lengthnl = b.Length;
                         Console.WriteLine("{0}", b.Substring(startIndexnl, (b.Length - startIndexnl)) + ",");
                         sw.WriteLine("{0}", b.Substring(startIndexnl, (b.Length - startIndexnl)) + ",");
                        }
                    }
                }


                }
            }          
            Console.ReadKey();
        }
    }
}
