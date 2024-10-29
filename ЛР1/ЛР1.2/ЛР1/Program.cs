using System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя длины катетов
        Console.Write("Введите длину первого катета: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите длину второго катета: ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Вычисляем гипотенузу
        double c = Math.Sqrt(a * a + b * b);

        // Вычисляем периметр
        double perimeter = a + b + c;

        // Выводим результат
        Console.WriteLine($"Периметр прямоугольного треугольника: {perimeter:F3}");
    }
}