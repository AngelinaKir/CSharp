using System;

class Program
{
    static void Main()
    {
        // Ввод значений a, b и h с клавиатуры
        Console.Write("Введите значение a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение шага h: ");
        double h = Convert.ToDouble(Console.ReadLine());

        // Построение таблицы значений функции
        Console.WriteLine(" x\t y");
        for (double x = a; x <= b; x += h)
        {
            double y = f(x, a, b);
            Console.WriteLine($"{x:F2}\t {y:F2}");
        }
    }

    static double f(double x, double a, double b)
    {
        // Определение функции y = f(x) в зависимости от условий
        if (x * x - 5 * x < 0)
        {
            return a + b;
        }
        else if (x * x - 5 * x < 10)
        {
            return a - b;
        }
        else
        {
            return a * b;
        }
    }
}