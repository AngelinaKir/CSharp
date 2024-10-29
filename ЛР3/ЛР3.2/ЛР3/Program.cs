using System;

class Program
{
    static void Main()
    {
        int n = 4; // Максимальное значение в первой строке

        for (int i = n; i >= 0; i--)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(j + "\t");
            }
            Console.WriteLine();
        }
    }
}