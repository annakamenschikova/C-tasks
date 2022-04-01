using System;
using System.Collections.Generic;
using System.Text;

namespace ITOffice
{
    class PMEmployee : Employee, ITaskAssigner
    {
        public override string Greetings()
        {
            return "Hello from PMEmployee";
        }
        public string AssignTask()
        {
            return "Task is assigned by PMEmployee";
        }
    }
}
