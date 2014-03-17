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

        // private functions
        private void updateBalance()
        {
            decimal result = 0.00m; 
            foreach (Transaction trans in transactions)
            {
                if (trans.CreditOrDebit == Transaction.Type.credit)
                {
                    result += trans.Amount;
                }
                else
                {
                    result -= trans.Amount; 
                }
            }
            balance = result;  
        }

        // public interface

        // constructor for fresh account
        public Account(String nm)
        {
            name = nm; 
            balance = 0.00m;
            transactions = new List<Transaction>();
        }

        // constructor with transaction history 
        public Account(String nm, IList<Transaction> history)
        {
            name = nm;
            transactions = history;
            updateBalance();  
        }

        // deposit money into account 
        public void Deposit(decimal amt)
        {
            Transaction deposit = new Transaction(amt, DateTime.Today, Transaction.Type.credit);
            transactions.Add(deposit);
            updateBalance(); 
        }

        // withdraw money from account
        public void Withdraw(decimal amt)
        {
            Transaction withdrawal = new Transaction(amt, DateTime.Today, Transaction.Type.debit);
            transactions.Add(withdrawal);
            updateBalance(); 
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
