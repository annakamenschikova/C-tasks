using System;

namespace HomeWork4__max_min_element_
{
    /*Задание- 1. Создать два произвольных массива, подсчитать максимальное и минимальное значение их элементов. Вывести на экран. 

2. Поменять в каждом массиве максимальные и минимальные значения местами*/

    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 7, 20, -10, 0, 81, 1 };
            int[] array2 = { 0, -5, 99, -99 };

            ChangeValues(array1); ///передаем массив в метод
            ChangeValues(array2);
        }

        static void ChangeValues(int[] array) ///единая инструкция для всех массивов 
        {
            int maxValue = array[0];
            int maxIndex = 0;

            int minValue = array[0];
            int minIndex = 0;

            for (int i = 0; i<array.Length; i++)
            {
                int j = array[i];
                if (j > maxValue)
                {
                    maxValue = j;
                    maxIndex = i;
                }
                
                if (j < minValue)
                {
                    minValue = j;
                    minIndex = i;
                    
                }
                
            }
            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);

            array[maxIndex] = minValue;
            array[minIndex] = maxValue;
          }
        
    }
}