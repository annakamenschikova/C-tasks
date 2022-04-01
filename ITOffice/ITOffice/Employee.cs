using System;
using System.Collections.Generic;
using System.Text;

namespace ITOffice
{
    abstract class Employee
    {
        public string FirstName { get; set; }
        public abstract string Greetings();
    }
}
