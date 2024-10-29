namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сообщение: ");
            string str = deleteRepeatWords(Console.ReadLine());//ввод сообщения пользователем и передача его в метод

            Console.WriteLine(str); // вывод результата

        }

        // метод, возвращающий строку без повторяющихся слов
        static string deleteRepeatWords(string str)
        {
            var words = str.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries); // разбиение строки на слова
            string stroka = "";

            foreach (var word in words) 
            { 

                if (!stroka.Contains(word.ToLower())) // проверка: не содержит ли строка подстроку word
                    stroka += word+" "; //добавление слова в строку 
            }

            return stroka;
        }

    }
}
