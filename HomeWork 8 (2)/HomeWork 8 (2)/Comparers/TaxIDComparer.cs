using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_8__2_.Comparers
{
    class TaxIDComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.TaxID > y.TaxID)
            {
                return 1;
            }
            else if (x.TaxID == y.TaxID)
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
