using System;
using System.Collections.Generic;
using System.Text;

namespace ITOffice
{
    class QATeamLead:QAEmployee, ITaskAssigner
    {
        public override string Greetings()
        {
            return "Hello from QATeamLead";
        }
        public string AssignTask()
        {
            return "Task is assigned by QATeamLead";
        }
    }
}
