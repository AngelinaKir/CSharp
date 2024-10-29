using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите день недели: ");
        string dayOfWeek = Console.ReadLine().ToLower();

        string schedule;

        switch (dayOfWeek)
        {
            case "понедельник":
                schedule = "Приём с 9:00 до 13:00";
                break;
            case "вторник":
                schedule = "Приём с 10:00 до 14:00";
                break;
            case "среда":
                schedule = "Приём с 9:00 до 13:00";
                break;
            case "четверг":
                schedule = "Приём с 10:00 до 14:00";
                break;
            case "пятница":
                schedule = "Приём с 9:00 до 12:00";
                break;
            case "суббота":
                schedule = "Приём с 10:00 до 12:00";
                break;
            case "воскресенье":
                schedule = "Выходной";
                break;
            default:
                schedule = "Некорректный день недели";
                break;
        }

        Console.WriteLine($"Расписание на {dayOfWeek}: {schedule}");
    }
}