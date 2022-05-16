using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_9_Library
{
    class Book
    {
        public string BookName { get; set; }
        public int PublishDate { get; set; }
        public int BookID { get; set; }
        public List<Author> Authors { get; set; }

        public Book(string bookname, List<Author> authors, int publishdt, int id)
        {
            BookName = bookname;
            PublishDate = publishdt;
            BookID = id;
            Authors = authors;
        }
        
    }
}
