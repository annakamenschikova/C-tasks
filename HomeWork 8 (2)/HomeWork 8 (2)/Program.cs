using System;
using System.Collections.Generic;
using HomeWork_8__2;
using HomeWork_8__2_.Comparers;

/*Задача для всех- отсортируйте и выведите в консоль сотрудников по:

1. Имени
2. TaxID
3. Общей длине имени и фамилии
4* Умению ассанить таски- ITaskAssigner сначала (их допольнительно отсортировать по фамилии), потом все остальные*/


namespace HomeWork_8__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            ITOffice issoft = new ITOffice();
            issoft.Employees.Add(new DevEmployee("3", "23456", 2, "C#"));
            issoft.Employees.Add(new DevTeamLead("1", "345", 1, "Java"));
            issoft.Employees.Add(new DevEmployee("2", "4567", 4, "C++"));
            issoft.Employees.Add(new DevTeamLead("4", "5", 3, "Python"));



            Console.WriteLine("--First Name sorting");
            issoft.Employees.Sort(new FirstNameComparer());
            foreach (Employee employee1 in issoft.Employees)
            {
                Console.WriteLine(employee1.ToString());
            }

            Console.WriteLine("--Tax ID sorting");
            issoft.Employees.Sort(new TaxIDComparer());
            foreach (Employee employee2 in issoft.Employees)
            {
                Console.WriteLine(employee2.ToString());
            }

            Console.WriteLine("--Full Name length sorting");
            issoft.Employees.Sort(new FullNameLengthComparer());
            foreach (Employee employee3 in issoft.Employees)
            {
                Console.WriteLine(employee3.ToString());
            }

            Console.WriteLine("--Assigne tasks sorting");
            issoft.Employees.Sort(new TaskAssignerComparer());
            foreach (Employee employee4 in issoft.Employees)
            {
                Console.WriteLine(employee4.ToString());
               
            }



        }
    }
}



