using System;
using System.Collections.Generic;
using System.Text;

namespace ITOffice
{
    class DevTeamLead : DevEmployee, ITaskAssigner, ICodeReviewer, ICodeWriter
    {
        public override string Greetings()
        {
            return "Hello from DevTeamLead";
        }
        public string AssignTask()
        {
            return "Task is assigned by DevTeamLead";
        }
        public string ReviewCode()
        {
            return "Code review is done by DevTeamLead";
        }
        public string WriteCode()
        {
            return "Code written by DevTeamLead";
        }
    }
}
