using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            StringBuilder str = new StringBuilder(Console.ReadLine());

            Console.Write("Результат: ");
            Console.WriteLine(DeleteSubstring(str));
        }

        // метод, удаляющий подстроку из строки
        static StringBuilder DeleteSubstring(StringBuilder sb)
        {
            int Length = 0;// длина подстроки
            string subString = ""; //подстрока


            for (int i = 0; i < sb.Length; i++)
            {
                char ch = sb[i]; // символ подстроки
                int j = i;
                int length = 0;

                while (j < sb.Length && ch == sb[j])
                {
                    j++;
                    length++;
                }

                if ( length > Length ) {
                    Length = length;
                    subString = sb.ToString(i, Length); // выделение подстроки из текста 
                }
                

                i = j - 1; // пропускаем прошедшие символы
            }
            
            if (subString.Length > 1 ) sb.Replace(subString, ""); // удалени подстроки


            return sb;
        }



    }
}
