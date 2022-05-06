using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace HomeWork_8__2_
{
    class DevEmployee : Employee//, IComparable<DevEmployee>
    {
        public string ProgrammingLanguage { get; set; }

        public DevEmployee(string fname, string lname, int taxid, string language) : base(fname, lname, taxid)
        {
            ProgrammingLanguage = language;
        }
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + TaxID + " " + ProgrammingLanguage;
        }

        /*public int CompareTo(DevEmployee other)
        {
            if (this.FirstName[0] > other.FirstName[0])
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }*/
    }
}