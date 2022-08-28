using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int beginRandomValue = 0;
            int endRandomValue = 101;
            int number = random.Next(beginRandomValue, endRandomValue);
            int sumEnumeration = 0;
            int enumeration;
            int multipleValue1 = 3;
            int multipleValue2 = 5;


            Console.WriteLine("Случайное число - " + number);
            Console.WriteLine("Все положительные числа <= {0}, кратные {1} или {2}:", number, multipleValue1, multipleValue2);

            for (enumeration = 0; enumeration <= number; enumeration++)
            {               
                if (enumeration % multipleValue1 == 0 || enumeration % multipleValue2 == 0)
                {
                    sumEnumeration += enumeration;
                    Console.WriteLine(enumeration);
                }
            }

            Console.Write("Cумма всех положительных чисел <= {0}, кратные {1} или {2}:\t" + sumEnumeration, number, multipleValue1, multipleValue2);
        }
    }
}
