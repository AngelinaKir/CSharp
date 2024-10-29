using System;

namespace Тесты
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Введите число: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int x))
                {
                    Console.WriteLine(DO(x));
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите корректное число.");
                }
            }
        }

        static int DO(int a)
        {
            if (a % 2 != 0)
            {
                return 0;
            }
            else
            {
                return a / 2;
            }
        }
    }
}