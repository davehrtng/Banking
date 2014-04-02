using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class AccountManager
    {
        // members
        private Account checking;
        private Account savings;

        // constructor
        public AccountManager()
        {
            checking = new Account(AccountType.checking);
            savings = new Account(AccountType.savings);
        }


        // public functions 
        // return the balance
        public decimal Balance(AccountType type)
        {
            if (type == AccountType.checking)
            {
                return checking.Balance; 
            }
            else if (type == AccountType.savings)
            {
                return savings.Balance;
            }
            else
            {
                throw new ArgumentException("not a valid account type"); 
            }
        }
        // add a deposit to an account
        public void Deposit(AccountType type, decimal amt)
        {
            if (type == AccountType.checking)
            {
                checking.Deposit(amt);
            }
            else
            {
                savings.Deposit(amt);
            }
        }
        // deposit a check into an account
        public void SignCheck(AccountType type, decimal amt, String recipient)
        {
            if (type == AccountType.checking)
            {
                checking.SignCheck(amt, recipient); 
            }
            else 
            {
                savings.SignCheck(amt, recipient); 
            }
        }
        // withdraw money from an account
        public bool Withdraw(AccountType type, decimal amt)
        {
            bool result;
            if (type == AccountType.checking)
            {
                if (checking.Withdraw(amt))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {
                if (savings.Withdraw(amt))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
        // transfer money between accounts
        public bool Transfer(AccountType fromAccount, AccountType toAccount, decimal amt)
        {
            bool result;
            if (fromAccount == AccountType.checking)
            {
                if (checking.Withdraw(amt))
                {
                    savings.Deposit(amt);
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            else
            {

                if (savings.Withdraw(amt))
                {
                    checking.Deposit(amt);
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }
        // get all the transactions assoc. with an account 
        public IList<Transaction> GetTransactions(AccountType type)
        {
            if (type == AccountType.checking)
            {
                return checking.Transactions;
            }
            else if (type == AccountType.savings)
            {
                return savings.Transactions;
            }
            else
            {
                throw new ArgumentException("not a valid account type"); 
            }
        }
    }
}
