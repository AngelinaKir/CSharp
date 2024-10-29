using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Введите B: ");
        int B = int.Parse(Console.ReadLine());

        Console.WriteLine("Числа, кратные трем в диапазоне от {0} до {1}:", A, B);
        for (int i = A; i <= B; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}