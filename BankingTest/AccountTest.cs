using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banking;
using System.Collections.Generic; 

namespace BankingTest
{
    [TestClass]
    public class AccountTest
    {
        public IList<Transaction> createTransactions()
        {
            IList<Transaction> transactions = new List<Transaction>();
            transactions.Add(new Transaction(500.00m, new DateTime(2014, 2, 23), Transaction.Type.credit));
            transactions.Add(new Transaction(200.00m, new DateTime(2014, 3, 1), Transaction.Type.debit));
            transactions.Add(new Transaction(135.50m, new DateTime(2014, 3, 12), Transaction.Type.debit)); 
            return transactions; 
        }
        
        [TestMethod]
        public void account_create_and_get_props()
        {
            Account savings = new Account("savings", createTransactions());
            String name = savings.Name;
            decimal balance = savings.Balance;
            IList<Transaction> transactions = savings.Transactions; 
        }

        [TestMethod]
        public void account_deposit_withdraw()
        {
            Account savings = new Account("savings");
            savings.Deposit(500.00m);
            savings.Deposit(250.00m);
            savings.Withdraw(201.87m);
            savings.Withdraw(183.23m); 
        }
    }
}
