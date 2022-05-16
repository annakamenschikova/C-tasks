using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_9_Library
{

    class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirthday { get; set; }

        public int AuthorID { get; set; }
        public Author(string fname, string lname, int dob, int authorid)
        {
            FirstName = fname;
            LastName = lname;
            DateOfBirthday = dob;
            AuthorID = authorid;
        }

    }
}
