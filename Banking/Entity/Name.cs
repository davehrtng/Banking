using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Name
    {
        // members
        string last;
        string first;
        string middle; 

        // properties
        public string Last
        {
            get { return last; }
            set { last = value; }
        }
        public string First
        {
            get { return first; }
            set { first = value; }
        }
        public string Middle
        {
            get { return middle; }
            set { middle = value; }
        }
        public string MI
        {
            get { return middle.Substring(0, 1); }
        }

        // public interface
        public Name(string fn, string mn, string ln)
        {
            first = fn;
            middle = mn;
            last = ln; 
        }

        public string fullName()
        {
            return first + " " + middle + " " + last; 
        }
    }
}
