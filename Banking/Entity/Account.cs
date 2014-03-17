using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Account
    {
        // members
        String name; 
        decimal balance;
        IList<Transaction> transactions;

        // public interface
        public Account(String nm)
        {
            name = nm; 
            balance = 0.00m;
            transactions = new List<Transaction>();
        }
        
        // properties
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Balance
        {
            get { return balance; } 
        }
        public IList<Transaction> Transactions
        {
            get { return transactions; }
        }
    }
}
