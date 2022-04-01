using System;
using System.Collections.Generic;
using System.Text;

namespace ITOffice
{
    class QAEmployee : Employee
    {
        public string Specialization { get; set; }
        public override string Greetings()
        {
            return "Hello from QAEmployee";
        }
    }
}
