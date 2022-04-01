using System;

namespace HomeWork2
{
    //Создать массив размером 10 элементов, заполнить его квадратами индексов (в цикле), и вывести его содержимое на экран
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int index = 0; index < array.Length; index++)
            {
                array[index] = index * index;         
            
            }

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }       
                 
            
            
       
        }
    }
}
