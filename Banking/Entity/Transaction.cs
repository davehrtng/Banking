using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Transaction
    {        
        // members
        private decimal amount;
        private DateTime date;
        private TransactionType type;

        // constructors
        public Transaction() { }
        public Transaction(decimal amt, DateTime dt, TransactionType typ)
        {
            amount = Math.Abs(amt);
            date = dt;
            type = typ; 
        }

        // properties
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
        public TransactionType CreditOrDebit
        {
            get { return type; }
            set { type = value; }
        }
        
        // public functions
        public String toCSV()
        {
            String result = "";
            result += amount + "," + date.ToShortDateString() + "," + type;
            return result; 
        }
    }
    public enum TransactionType { credit, debit }; 
}
