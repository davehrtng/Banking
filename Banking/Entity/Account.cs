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
        decimal balance;
        AccountType type;
        TransactionManager objTransactionManager; 

        // private functions
        private void updateBalance()
        {
            decimal result = 0.00m;
            result = objTransactionManager.ComputeBalance();
            balance = result;  
        }

        // public interface

        // constructor for fresh account
        public Account(AccountType typ)
        {
            balance = 0.00m;
            type = typ; 
            objTransactionManager = new TransactionManager(type);
        }

        // deposit money into account 
        public void Deposit(decimal amt)
        {
            objTransactionManager.Add(amt, DateTime.Today, TransactionType.credit);
            balance = objTransactionManager.ComputeBalance(); 
        }
        // deposit a check into an account
        public void SignCheck(decimal amt, String orderof)
        {
            objTransactionManager.Add(amt, DateTime.Today, orderof); 
        }

        // withdraw money from account
        public bool Withdraw(decimal amt)
        {
            bool result;
            updateBalance(); 
            if (amt <= balance)
            {
                objTransactionManager.Add(amt, DateTime.Today, TransactionType.debit);
                balance = objTransactionManager.ComputeBalance();
                result = true; 
            }
            else
            {
                result = false; 
            }
            return result; 
        }
        
        // properties
        public AccountType Type
        {
            get { return type; } 
        }
        public decimal Balance
        {
            get { updateBalance();  return balance; } 
        }
        public IList<Transaction> Transactions
        {
            get { return objTransactionManager.GetAll(); }
        }
    }

    // account type class helps distinguish between different accounts 
    public enum AccountType { checking, savings };

    public static class AccountTypeExtensions
    {
        public static AccountType otherAccount(this AccountType thisAccount)
        {
            if (thisAccount == AccountType.checking)
            {
                return AccountType.savings;
            }
            else
            {
                return AccountType.checking; 
            }
        }
    }
}
