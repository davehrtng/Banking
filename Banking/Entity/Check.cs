using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
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
            type = TransactionType.credit; 
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
