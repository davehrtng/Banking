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

        // properties

        // public functions 
        public void Deposit(AccountType type, decimal amt, DateTime datetime)
        {

        }
        public void Withdraw(AccountType type, decimal amt, DateTime datetime)
        {

        }
        public void Transfer(AccountType fromAccount, AccountType toAccount, decimal amt)
        {

        }
        public IList<Transaction> GetTransactions(AccountType type)
        {
            throw new NotImplementedException(); 
        }
    }
}
