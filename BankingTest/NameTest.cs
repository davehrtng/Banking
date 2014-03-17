using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banking; 

namespace BankingTest
{
    [TestClass]
    public class NameTest
    {
        [TestMethod]
        public void name_create_and_use()
        {
            Name name = new Name("David", "Edward", "Harting");
            string last = name.Last;
            string first = name.First;
            string middle = name.Middle;
            string mi = name.MI; 
        }

        [TestMethod]
        public void name_set_properties()
        {
            Name name = new Name("David", "Edward", "Harting");
            name.Last = "Cantrell";
            name.First = "Katie";
            name.Middle = "Susanne";
        }
    }
}
