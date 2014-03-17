using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Account
    {
        // members
        Name name; 
        decimal balance;
        IList<Transaction> transactions;

        // public interface
        public Account(Name nm)
        {
            name = nm; 
            balance = 0.00m;
            transactions = new List<Transaction>();
        }
        
        // properties
        public Name Name
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
