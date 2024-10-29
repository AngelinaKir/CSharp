using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            if (IsPalindrom(Console.ReadLine())) Console.WriteLine("Слово является палиндромом");
           else Console.WriteLine("Не является палидром");

        }

        //метод, проверяющий является ли строка палиндромом, если полиндром возвращает true, иначе - false
        static bool IsPalindrom(string str)
        {

            string cleaned = str.Replace(" ", "").ToLower(); // удаление всех пробелов и приведение текста к нижнему регистру

            // Проверяем строку на палиндром
            int len = cleaned.Length; //длина строки
            for (int i = 0; i < len / 2; i++) // цикл, проходящий по строке и проверяющий символы
            {
                if (cleaned[i] != cleaned[len - 1 - i])
                {
                    return false;
                }
            }
            return true;

        }
    }
}
