using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текстовое сообщение: ");
            
            string input = Console.ReadLine();// ввод строки пользователем 

            string result = RemovePunctuation(input);

            
            Console.WriteLine("Сообщение без знаков препинания: ");
            Console.WriteLine(result); // вывод результата
        }

        static string RemovePunctuation(string message)
        {
            return Regex.Replace(message, @"[^\w\s]", string.Empty); // заменна знаков препиная на пустой символ в строке
        }
    }
}
