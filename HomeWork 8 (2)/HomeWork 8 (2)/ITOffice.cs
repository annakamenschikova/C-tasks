using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_8__2_
{
    class ITOffice
    {
        List<Employee> _employees;
        public List<Employee> Employees
        {
            get
            {
                return _employees;
            }
        }
        public ITOffice()
        {
            _employees = new List<Employee>();
        }
        
    }
}
