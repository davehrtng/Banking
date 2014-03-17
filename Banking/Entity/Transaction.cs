using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Transaction
    {
        public enum Type { credit, debit }; 
        
        private decimal amount;
        private DateTime date;
        private Type type;

        public Transaction() { }

        public Transaction(decimal amt, DateTime dt, Type typ)
        {
            amount = Math.Abs(amt);
            date = dt;
            type = typ; 
        }

        public decimal Amount
        {
            get { return amount; }
            set { amount = Math.Abs(value); }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public Type CreditOrDebit
        {
            get { return type; }
            set { type = value; }
        }
        
    }
}
