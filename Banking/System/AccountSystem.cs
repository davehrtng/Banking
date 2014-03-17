using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class AccountSystem
    {
        // members
        private static String path; 

        // interface 
        public AccountSystem() { }

        public String Path
        {
            get { return path; }
            set { path = value; }
        }

        public bool Save(Account acct)
        {
            bool success = true; 
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(acct.Name); 
            }
            return success;  
        }

        //public Account Fetch()
        //{

        //}
    }
}
