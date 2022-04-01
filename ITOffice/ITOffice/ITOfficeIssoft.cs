using System;
using System.Collections.Generic;
using System.Text;

namespace ITOffice
{
    class ITOfficeIssoft
    {
        List<Employee> _employees;
        public List<Employee> Employees
        {
            get
            {
                return _employees;
            }
        }
        public ITOfficeIssoft()
        {
            _employees = new List<Employee>();
        }
          
    }
}
