using System;
using System.Collections.Generic;
using System.Text;

namespace ITOffice
{
    class BAEmployee : Employee
    {
        public string UMLEditor { get; set; }
        public override string Greetings()
        {
            return "Hello from BAEmployee";
        }
    }
}
