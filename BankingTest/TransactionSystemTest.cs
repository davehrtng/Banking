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
            transactions.Add(new Transaction(500.00m, new DateTime(2014, 2, 23), Transaction.Type.credit));
            transactions.Add(new Transaction(200.00m, new DateTime(2014, 3, 1), Transaction.Type.debit));
            transactions.Add(new Transaction(135.50m, new DateTime(2014, 3, 12), Transaction.Type.debit));
            return transactions;
        }

        [TestMethod]
        public void save_transaction_list()
        {
            TransactionSystem objSystem = new TransactionSystem();
            bool success = objSystem.Save(createTransactions(), "C:\\Users\\David\\SkyDrive\\School\\Spring 2014\\OOD\\Assignments\\Assignment 3\\Save Files\\Savings.txt"); 
        }

        [TestMethod]
        public void save_transaction_bad_path()
        {
            TransactionSystem objSystem = new TransactionSystem();
            bool success;
            try
            {
                success = objSystem.Save(createTransactions(), "C:\\Users\\David\\SkyDrive\\School\\Spring 2014\\OOD\\Assignments\\Assignment 3\\Save Files\\wrongname.txt");
            }
            catch(FileNotFoundException e)
            {
                success = false; 
            }
        }

        [TestMethod]
        public void transaction_system_GetAll_validPath()
        {
            TransactionSystem objSystem = new TransactionSystem();
            IList<Transaction> transactions = objSystem.GetAll("C:\\Users\\David\\SkyDrive\\School\\Spring 2014\\OOD\\Assignments\\Assignment 3\\Save Files\\Savings.txt"); 
        }

        [TestMethod]
        public void transaction_system_GetAll_invalidPath()
        {
            TransactionSystem objSystem = new TransactionSystem();
            try
            {
                IList<Transaction> transactions = objSystem.GetAll("C:\\Users\\David\\SkyDrive\\School\\Spring 2014\\OOD\\Assignments\\Assignment 3\\Save Files\\wrongname.txt");
            }
            catch (FileNotFoundException e)
            {
                FileNotFoundException exception = e; 
            }
        }

        [TestMethod]
        public void transaction_system_GetAll_invalidData()
        {
            TransactionSystem objSystem = new TransactionSystem();
            try
            {
                IList<Transaction> transactions = objSystem.GetAll("C:\\Users\\David\\SkyDrive\\School\\Spring 2014\\OOD\\Assignments\\Assignment 3\\Save Files\\Savings.txt");
            }
            catch(InvalidCastException e)
            {
                InvalidCastException exception = e; 
            }
        }
    }
}
