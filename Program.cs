using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(0,101);
            int sumEnumeration = 0;
            int enumeration = 0;

            Console.WriteLine("Случайное число - " + number);
            Console.WriteLine("Все положительные числа <= {0}, кратные 3 или 5:", number);
            while (enumeration <= number)
            {
                enumeration++;
                if (enumeration%3 == 0 || enumeration%5 == 0)
                {
                    sumEnumeration += enumeration;
                    Console.WriteLine(enumeration);
                }
            }
            Console.Write("Cумма всех положительных чисел <= number, кратные 3 или 5:\t" + sumEnumeration);
        }
    }
}
