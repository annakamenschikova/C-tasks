using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_8__2_.Comparers
{
    class FullNameLengthComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            int xLength = x.FirstName.Length + x.LastName.Length;
            int yLength = y.FirstName.Length + y.LastName.Length;



            if (xLength > yLength)
            {
                return 1;
            }
            else if (xLength == yLength)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
