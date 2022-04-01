using System;
using System.Collections.Generic;
using System.Text;

namespace ITOffice
{
    class QAAutomationEmployee : Employee, ICodeWriter
    {
        public override string Greetings()
        {
            return "Hello from QAAutomationEmployee";
        }
        public string WriteCode()
        {
            return "Code written by QAAutomationEmployee";
        }
    }
}
