using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_8__2_.Comparers
{
    class TaskAssignerComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if ((x is ITaskAssigner) & !(y is ITaskAssigner))
            {
                return -1;
            }
            else if (!(x is ITaskAssigner) & (y is ITaskAssigner))
            {
                return 1;
            }
            else if ((x is ITaskAssigner) & (y is ITaskAssigner))
            {
                return string.Compare(x.LastName, y.LastName);
                {
                    if (x.LastName[0] > y.LastName[0])
                    {
                        return 1;
                    }
                    else if (x.LastName[0] == y.LastName[0])
                    {
                        return 0;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            else return 0;


        }
}
}
