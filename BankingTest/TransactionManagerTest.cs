using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banking;
using System.Collections.Generic; 

namespace BankingTest
{
    [TestClass]
    public class TransactionManagerTest
    {
        [TestMethod]
        public void trans_man_add()
        {
            TransactionManager checkTransMan = new TransactionManager(AccountType.checking);
            checkTransMan.Add(760.32m, DateTime.Now, TransactionType.credit);
            TransactionManager saveTransMan = new TransactionManager(AccountType.savings);
            saveTransMan.Add(5487.10m, DateTime.Now, TransactionType.debit); 
        }

        [TestMethod]
        public void trans_man_getall()
        {
            TransactionManager saveTransMan = new TransactionManager(AccountType.savings);
            IList<Transaction> result = new List<Transaction>(); 
            result = saveTransMan.GetAll(); 
        }
    }
}
