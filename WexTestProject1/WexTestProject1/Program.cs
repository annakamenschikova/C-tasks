using System;

namespace WexTestProject1
{//Задача- вывести в консоль максимальные и минимальные допустимые значения для типов данных byte,
 //short, int, long, float, double, uint, ulong. 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            int minByte = byte.MinValue;
            int maxByte = byte.MaxValue;
            int minShort = short.MinValue;
            int maxShort = short.MaxValue;
            long minLong = long.MinValue;
            long maxLong = long.MaxValue;
            float minFloat = float.MinValue;
            float maxFloat = float.MaxValue;
            double minDouble = double.MinValue;
            double maxDouble = double.MaxValue;
            uint maxUint = uint.MaxValue;
            uint minUint = uint.MinValue;
            ulong maxUlong = ulong.MaxValue;
            ulong minUlong = ulong.MinValue;


            Console.WriteLine("Min/Max values of int are {0}/{1}", minInt, maxInt);
            Console.WriteLine("Min/Max values of byte are {0}/{1}", minByte, maxByte);
            Console.WriteLine("Min/Max values of short are {0}/{1}", minShort, maxShort);
            Console.WriteLine("Min/Max values of long are {0}/{1}", minLong, maxLong);
            Console.WriteLine("Min/Max values of float are {0}/{1}", minFloat, maxFloat);
            Console.WriteLine("Min/Max values of double are {0}/{1}", minDouble, maxDouble);
            Console.WriteLine("Min/Max values of uint are {0}/{1}", minUint, maxUint);
            Console.WriteLine("Min/Max values of ulong are {0}/{1}", minUlong, maxUlong);

        }
    }
}
