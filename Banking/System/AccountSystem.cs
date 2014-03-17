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
            if (File.Exists(path))
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.WriteLine(acct.Name);
                }
                try
                {
                    TransactionSystem objSystem = new TransactionSystem(); 
                    // TODO: append the transactions to the end of the account file
                }
                catch(InvalidCastException e)
                {
                    
                }
                success = true;
            }
            else
            {
                success = false;
                throw new FileNotFoundException(); 
            }
            return success;  
        }

        //public Account Fetch()
        //{

        //}
    }
}
