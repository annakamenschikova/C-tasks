using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_8__2_
{
    abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TaxID { get; set; }

        public Employee(string fname, string lname, int taxid)
        {
            FirstName = fname;
            LastName = lname;
            TaxID = taxid;
        }

        /*public abstract string Greetings();*/
    }
}
