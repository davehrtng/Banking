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

        }
    }
}
