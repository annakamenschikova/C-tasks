using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

/*Для программы по обслуживания функционирования библиотеки создать следующие классы: Автор (имя, фамилия, дата рождения),
Книга (включающая название, дату публикации, уникальный ID, список авторов), Каталог (включающий коллекцию книг). Для класса Каталог создать методы, позволяющие:
1. Получить список всех книг, отсортированных по названию
2. Получить список всех авторов, книги которых есть в каталоге
3. Получить список всех книг конкретного автора, напечатанные после заданного года
4. Получить список всех авторов, отсортированных по году рождения*/

namespace HomeWork_9_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Author> authors = new List<Author>();
            authors.Add(new Author("Home", "Inn", 1745, 15511));
            authors.Add(new Author("Tom", "Gray", 1895, 15514));
            authors.Add(new Author("Ray", "Ford", 1800, 15512));
            authors.Add(new Author("Mark", "Linn", 1911, 15513));
            authors.Add(new Author("Curt", "Way", 1974, 15513));
            authors.Add(new Author("Kim", "Dao", 1915, 15513));

            Catalog Library = new Catalog();
            Library.Books.Add(new Book("Hetr Burn", new List<Author>() { authors[0] }, 2000, 7777771));
            Library.Books.Add(new Book("False nutt", new List<Author>() { authors[1], authors[3] }, 1980, 7777781));
            Library.Books.Add(new Book("Gray meet", new List<Author>() { authors[2]}, 1980, 7777751));
            Library.Books.Add(new Book("Haert boll", new List<Author>() { authors[3] }, 2005, 7777761));
            Library.Books.Add(new Book("Way youth", new List<Author>() { authors[4], authors[5] }, 2005, 7777761));

            Library.SortByBookname();
            Console.WriteLine("\n");

            Library.SortByAuthors();
            Console.WriteLine("\n");

            Library.SortByAuthor("Mark", "Linn", 2000);
            Console.WriteLine("\n");

            Library.SortByDOB();

                    


        }
    }
}
