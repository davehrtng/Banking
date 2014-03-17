using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class TransactionSystem
    {
        public TransactionSystem() { }

        public bool Save(IList<Transaction> transactions, String path)
        {
            bool success = false;
            if (File.Exists(path))
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    foreach (Transaction tran in transactions)
                    {
                        writer.WriteLine(tran.toCSV());
                    }
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
            Transaction.Type type;
            if (parts[2].Equals("debit"))
            {
                type = Transaction.Type.debit;
            }
            else if (parts[2].Equals("credit"))
            {
                type = Transaction.Type.credit;
            }
            else
            {
                throw new InvalidCastException("type"); 
            }
            return new Transaction(amount, date, type); 
        }

        public IList<Transaction> GetAll(String path)
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
    }
}
