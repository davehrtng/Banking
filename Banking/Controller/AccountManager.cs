﻿using System;
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
        public IList<Transaction> GetTransactions(AccountType type)
        {
            throw new NotImplementedException();
        }
    }
}
