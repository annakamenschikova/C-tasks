using System;

namespace HomeWork5__class_Book_
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book { Title = "Pride and Prejudice", Pages = 411, ID = "123abc" };
            Book book2 = new Book { Title = "1984", Pages = 215, ID = "234bcd" };
            Book book3 = new Book { Title = "Hamlet", Pages = 100, ID = "345cde" };
            Book book4 = new Book { Title = "Anna Karenina", Pages = 396, ID = "456def" };
            Book book5 = new Book { Title = "The Odyssey", Pages = 456, ID = "567efg" };

            Book [] books = { book1, book2, book3, book4, book5 };

            foreach (Book item in books)
            {
                Console.WriteLine("Title - {0}, pages - {1}, ID - {2}", item.Title, item.Pages, item.ID);
            }

        }
       
    
    
    
    
    
    
    }


 




}
