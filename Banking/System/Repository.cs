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
        private static String rootpath = "";
        public static String Path
        {
            get { return rootpath; }
            set { rootpath = value; }
        }
        private String path; 
        
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

        // public bool Save(IList<Transaction> transactions, String path)
        //{
        //    bool success = false;
        //    if (File.Exists(path))
        //    {
        //        using (StreamWriter writer = new StreamWriter(path, true))
        //        {
        //            foreach (Transaction tran in transactions)
        //            {
        //                writer.WriteLine(tran.toCSV());
        //            }
        //        }
        //        success = true; 
        //    }
        //    else
        //    {
        //        success = false;
        //        throw new FileNotFoundException(); 
        //    }
        //    return success; 
        //}     

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
