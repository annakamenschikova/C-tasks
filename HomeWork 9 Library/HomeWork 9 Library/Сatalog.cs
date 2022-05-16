using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HomeWork_9_Library
{
    class Catalog
    {
        public List<Book> Books { get; }
        public Catalog()

        {
            Books = new List<Book>();
        }

        public void SortByBookname()
        {
            Console.WriteLine("--Sorting #1");
            var sortingbybookname = Books.OrderBy(x => x.BookName);
            foreach (var book in sortingbybookname)
            {
                Console.WriteLine($"{book.BookName}");
            }

        }
        public void SortByAuthors()
        {
            Console.WriteLine("--Sorting #2");
            var sortingbyauthors = Books.SelectMany(x => x.Authors).Distinct();
            foreach (var book in sortingbyauthors)
            {
                Console.WriteLine($"{book.FirstName} {book.LastName}");
            }
        }
        public void SortByAuthor(string firstname, string lastname, int publishdt)
        {
            Console.WriteLine("--Sorting #3");
            var sortbyauthor = Books.Where(x => x.Authors.Any(x=>x.FirstName == firstname && x.LastName == lastname)).Where(x => x.PublishDate > publishdt);
            foreach (var book in sortbyauthor)
            {
                Console.WriteLine($"{book.BookName} - {book.PublishDate}");
            }
        }
        public void SortByDOB()
        {
            Console.WriteLine("--Sorting #4");
            var sortbydob = Books.SelectMany(x => x.Authors).OrderBy(x=> x.DateOfBirthday).Distinct();
            foreach (var book in sortbydob)
            {
                Console.WriteLine($"{book.DateOfBirthday} - {book.FirstName} {book.LastName}");
            }
        }
    }
    
}
