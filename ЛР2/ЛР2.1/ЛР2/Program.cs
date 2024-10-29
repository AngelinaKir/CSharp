//using System;
//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите значение x: ");
//        double x = Convert.ToDouble(Console.ReadLine());

//        if (x > 1)
//        {
//            double y = Math.Log(x - 1);
//            Console.WriteLine($"Значение функции y = ln(x-1) при x = {x} равно {y}");
//        }
//        else
//        {
//            Console.WriteLine("Ошибка: значение x должно быть больше 1.");
//        }
//    }
//}



Console.WriteLine("введите х");
float x = float.Parse(Console.ReadLine());
Console.WriteLine("введите y");
float y = float.Parse(Console.ReadLine());

if (x * x + y * y < 4 && Math.Abs(x) + Math.Abs(y) > 2)
    Console.WriteLine("Внутри");
else
    if (x * x + y * y > 4 || Math.Abs(x) + Math.Abs(y) < 2) {
    Console.WriteLine("Не принадлежит");
}
else
{
    Console.WriteLine("На границе");
}
        