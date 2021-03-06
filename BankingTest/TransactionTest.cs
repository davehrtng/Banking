﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banking; 

namespace BankingTest
{
    [TestClass]
    public class TransactionTest
    {
        [TestMethod]
        public void transaction_get()
        {
            Transaction transaction = new Transaction(35.00m, new DateTime(2014, 3, 7), TransactionType.credit);
            decimal amt = transaction.Amount;
            TransactionType type = transaction.CreditOrDebit;
            DateTime date = transaction.Date; 
        }

        [TestMethod]
        public void transaction_set()
        {
            Transaction transaction = new Transaction();
            transaction.Amount = 35.00m;
            transaction.CreditOrDebit = TransactionType.debit;
            transaction.Date = DateTime.Today; 
        }

        [TestMethod]
        public void transaction_negative_amount()
        {
            Transaction trans = new Transaction(-40.00m, new DateTime(1992, 3, 4), TransactionType.debit);
            decimal amt_t1 = trans.Amount;
            trans.Amount = -400.00m; 
            decimal amt_t2 = trans.Amount; 
        }

        [TestMethod]
        public void transaction_toCSV()
        {
            Transaction trans = new Transaction(-40.00m, new DateTime(1992, 11, 18), TransactionType.debit);
            String csv = trans.toCSV(); 
        }
    }
}
