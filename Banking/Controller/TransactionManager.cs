using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class TransactionManager
    {
        // members
        private IList<Transaction> transactions;
        private AccountType accountType; 

        // properties
        public IList<Transaction> Transactions
        {
            get { return transactions; } 
        }

        // public functions

        public TransactionManager(AccountType type)
        {
            transactions = new List<Transaction>();
            accountType = type;
        }
        
        public decimal ComputeBalance()
        {
            decimal result = 0.00m; 
            foreach (Transaction trans in transactions)
            {
                if (trans.CreditOrDebit == TransactionType.credit)
                {
                    result += trans.Amount;
                }
                else
                {
                    result -= trans.Amount;
                }
            }
            return result; 
        }

        public IList<Transaction> GetAll()
        {
            Repository repo = new Repository(accountType);
            transactions.Clear();
            transactions = repo.GetAll();
            return transactions; 
        }

        public Transaction Add(decimal amt, DateTime dateTime, TransactionType type)
        {
            Transaction trans = new Transaction(amt, dateTime, type);
            Repository repo = new Repository(accountType); // consider making private member
            trans = repo.Post(trans);
            transactions.Add(trans); 
            return trans; 
        }
    }
}
