using System;

class Program
{
    static void Main()
    {
        // Запрашиваем у пользователя число
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = (number / 10) + (number % 10);

        // Вычисляем сумму цифр числ и Проверяем, кратно ли число трём
        string result = (((number / 10) + (number % 10)) % 3 == 0) ? $"Число {number} кратно трём." : $"Число {number} не кратно трём.";
        Console.WriteLine(result);
    }
}