using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    /*
     * a check is just like a transaction (a withdrawal, specifically) except it also has an extra string associated with it - the recipient of the check
     */
    public class Check : Transaction
    {
        private String recipient;
        public String OrderOf
        {
            get { return recipient; }
            set { OrderOf = value; } 
        }
        public Check(decimal amt, DateTime dt, String orderof)
        {
            amount = amt;
            date = dt;
            type = TransactionType.debit; 
            recipient = orderof; 
        }
        public override String toCSV()
        {
            String result = "";
            result += amount + "," + date.ToShortDateString() + "," + type + "," + recipient; 
            return result; 
        }
    }
}
