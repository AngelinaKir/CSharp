using System;

namespace Тесты
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите кол-во членов последовательности: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Введите число: ");
                string chislo = Console.ReadLine();

                Console.WriteLine(Q(chislo));
            }

        }

        static int Q(string a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {

                int digit = int.Parse(a[i].ToString());
                if (digit % 2 == 0)
                {
                    sum = sum + digit;
                }
            }
            return sum;
        }
    }

}