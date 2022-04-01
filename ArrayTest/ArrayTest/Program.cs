using System;

namespace ArrayTest

{//Задание- создать три массива по 10 элементов, первый заполнить значениями индексов
 //элементов, второй - квадратами индексов, третий-кубами, и вывести на экран

    class Program
    {
        static void InitializeArray(int[] array, int factor)
        {
            for (int i = 0; i < array.Length; i ++)
            {
                if (factor == 1)
                {
                    array[i] = i;
                }
                else if (factor == 2)
                {
                    array[i] = i * i;
                }
                else
                {
                    array[i] = i * i * i;
                }
            } 
            
        }
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            InitializeArray(array1, 1);

            int[] array2 = new int[10];            
            InitializeArray(array2, 2);

            int[] array3 = new int[10];
            InitializeArray(array3, 3);

            foreach (int item in array1)
            {
                Console.WriteLine(item);
            }

            foreach (int item in array2)
            {
                Console.WriteLine(item);
            }

            foreach (int item in array3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
