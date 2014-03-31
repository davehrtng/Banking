using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banking;
using System.Collections.Generic;
using System.IO; 

namespace BankingTest
{
    [TestClass]
    public class TransactionSystemTest
    {

        private IList<Transaction> createTransactions()
        {
            IList<Transaction> transactions = new List<Transaction>();
            transactions.Add(new Transaction(500.00m, new DateTime(2014, 2, 23), TransactionType.credit));
            transactions.Add(new Transaction(200.00m, new DateTime(2014, 3, 1), TransactionType.debit));
            transactions.Add(new Transaction(135.50m, new DateTime(2014, 3, 12), TransactionType.debit));
            return transactions;
        }

        [TestMethod]
        public void trans_system_post()
        {
            Transaction transaction1 = new Transaction(500.00m, new DateTime(2014, 2, 23), TransactionType.credit);
            Transaction transaction2 = new Transaction(200.00m, new DateTime(2014, 3, 1), TransactionType.debit);
            Transaction transaction3 = new Transaction(135.50m, new DateTime(2014, 3, 12), TransactionType.debit);
            Repository checkingRepo = new Repository(AccountType.checking);
            checkingRepo.Post(transaction1);
            Repository savingsRepo = new Repository(AccountType.savings);
            savingsRepo.Post(transaction2);
            checkingRepo.Post(transaction3); 
        }

        [TestMethod]
        public void trans_getall()
        {
            Repository checkrepo = new Repository(AccountType.checking);
            IList<Transaction> result = new List<Transaction>();
            result = checkrepo.GetAll(); 
        }
    }
}
