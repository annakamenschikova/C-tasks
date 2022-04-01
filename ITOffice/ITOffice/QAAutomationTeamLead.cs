using System;
using System.Collections.Generic;
using System.Text;

namespace ITOffice
{
    class QAAutomationTeamLead : QAAutomationEmployee, ITaskAssigner, ICodeReviewer, ICodeWriter
    {
        public override string Greetings()
        {
            return "Hello from QAAutomationTeamLead";
        }
        public string AssignTask()
        {
            return "Task is assigned by QAAutomationTeamLead";
        }

        public string ReviewCode()
        {
            return "Code review is done by QAAutomationTeamLead";
        }
        public string WriteCode()
        {
            return "Code written by QAAutomationTeamLead";
        }
    }
}
