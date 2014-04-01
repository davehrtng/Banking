using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banking;
using System.Collections.Generic; 

namespace BankingTest
{
    [TestClass]
    public class CheckTest
    {
        [TestMethod]
        public void check_save()
        {
            Repository repo = new Repository(AccountType.checking);
            Check check = new Check(500.00m, DateTime.Now, "the poopsmith");
            repo.Post(check); 
        }

        [TestMethod]
        public void checks_load()
        {
            IList<Transaction> result = new List<Transaction>();
            Repository repo = new Repository(AccountType.checking);
            result = repo.GetAll(); 

        }
    }
}
