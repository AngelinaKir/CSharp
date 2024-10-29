using System; 

class Program
{
    static void Main() 
    {
        Console.WriteLine("введите х"); // Вывод сообщения для ввода значения x
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine("введите y"); // Вывод сообщения для ввода значения y
        float y = float.Parse(Console.ReadLine());

        // Проверка условия: если сумма квадратов x и y меньше или равна 4 и сумма модулей x и y равна 2
        if (x * x + y * y <= 4 && Math.Abs(x) + Math.Abs(y) == 2)
            Console.WriteLine("принадлежит"); 
        else
            Console.WriteLine("не принадлежит"); 
    }
}