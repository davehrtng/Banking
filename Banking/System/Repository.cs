using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Repository
    {
        // members
        private static String rootpath = ""; // the path of the folder containing the text files
        public static String Path // it's accessible to the UI so that it can be changed with the folder dialog
        {
            get { return rootpath; }
            set { rootpath = value; }
        }
        private String path; // we will build actual file paths into this, so that we never change the static path variable. 
        
        // private functions
        private Transaction csvToTransaction(String csv)
        {
            String[] parts = csv.Split(',');
            decimal amount;
            try
            {
                amount = Convert.ToDecimal(parts[0]);
            }
            catch
            {
                throw new InvalidCastException("amount");
            }
            DateTime date;
            try
            {
                date = Convert.ToDateTime(parts[1]);
            }
            catch
            {
                throw new InvalidCastException("datetime");
            }
            if (parts.Length > 3)
            {
                String recipient;
                try
                {
                    recipient = parts[3];
                }
                catch
                {
                    throw new InvalidCastException("check");
                }
                return new Check(amount, date, recipient);
            }
            else
            {
                TransactionType type;
                if (parts[2].Equals("debit"))
                {
                    type = TransactionType.debit;
                }
                else if (parts[2].Equals("credit"))
                {
                    type = TransactionType.credit;
                }
                else
                {
                    throw new InvalidCastException("type");
                }
                return new Transaction(amount, date, type);
            }
        }
        
        // public functions 
        
        public Repository(AccountType acctType)
        {
            path = rootpath; 
            if (acctType == AccountType.checking)
            {
                path += "\\Checking.txt";
            }
            else if (acctType == AccountType.savings)
            {
                path += "\\Savings.txt";
            }
            else
            {
                throw new ArgumentException(); 
            }
        }

        // get all transactions for this account from the file
        public IList<Transaction> GetAll()
        {
            if (File.Exists(path))
            {
                IList<String> CSVs = File.ReadAllLines(path);
                IList<Transaction> transactions = new List<Transaction>();
                foreach (String csv in CSVs)
                {
                    if (!String.IsNullOrEmpty(csv))
                    {
                        transactions.Add(csvToTransaction(csv));
                    }
                }
                return transactions;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        // write a new transaction to the file 
        public Transaction Post(Transaction trans)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(trans.toCSV());
                }
            }
            catch(FileNotFoundException ex)
            {
                throw ex; 
            }
            return trans; 
        }

    }
}
