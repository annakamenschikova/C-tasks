using System;
using System.Collections.Generic;
using System.Text;

namespace ITOffice
{
    class DevEmployee : Employee, ICodeWriter
    {
        public string ProgrammingLanguage { get; set; }
        public override string Greetings()
        {
            return "Hello from DevEmployee";
        }
        public string WriteCode()
        {
            return "Code written by DevEmployee";
        }
    }
}
