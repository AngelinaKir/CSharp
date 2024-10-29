using System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя два вещественных числа
        Console.Write("Введите первое вещественное число: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе вещественное число: ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Выполняем деление и выводим результат с точностью до 3 знаков после запятой
        if (b != 0)
        {
            double result = a / b;
            Console.WriteLine($"{a:F3} / {b:F3} = {result:F3}");
        }
        else
        {
            Console.WriteLine("Ошибка: деление на ноль невозможно.");
        }
    }
}