using HomeWork_8__2_;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_8__2
{
    class DevTeamLead : DevEmployee, ITaskAssigner
    {
  
        public string AssignTask()
        {
            return "Task is assigned by DevTeamLead";
        }
        public DevTeamLead(string fname, string lname, int taxid, string language) : base(fname, lname, taxid, language)
        {
            ProgrammingLanguage = language;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + TaxID + " " + ProgrammingLanguage + " I can assign tasks";
        }
    }
}
