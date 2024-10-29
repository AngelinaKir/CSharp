//зад1.1
//Console.Write("Введите кол-во элементов массива: ");
//int n = int.Parse(Console.ReadLine());

//int[] array = new int[n];

//Random rnd = new Random();

//Console.WriteLine("Массив: ");

//for (int i = 0; i < n; i++)
//{
//    array[i] = rnd.Next(-9, 10);
//}

//for (int i = 0; i < n; i++)
//{
//    Console.Write(array[i] + " ");
//}

//Console.WriteLine();

//int min = array[0];
//int minindex = 0;


//for (int i = 0; i < n; i++)
//{
//    if (array[i] < min)
//    {
//        min = array[i];
//        minindex = i;
//    }
//}

//Console.WriteLine("Минимальный элемент в массиве: " + min);

//int max = array[0];
//int maxindex = 0;

//for (int i = 0; i < n; i++)
//{
//    if (array[i] > max)
//    {
//        max = array[i];
//        maxindex = i;
//    }
//}

//Console.WriteLine("Максимальный элемент в массиве: " + max);

//int temp = array[minindex];
//array[minindex] = array[maxindex];
//array[maxindex] = temp;

//Console.WriteLine("Массив с поменяным макс и мин элементом: ");

//for (int i = 0; i < n; i++)
//{
//    Console.Write(array[i] + " ");
//}

//Console.WriteLine();




//зад 1.2
Console.Write("Кол-во элементов: ");
int kol = int.Parse(Console.ReadLine());

int[] array = new int[kol];

Random rnd = new Random();

for (int i = 0; i < kol; i++)
{
    array[i] = rnd.Next(-9, 10);
}

Console.WriteLine("Исходный массив:");
foreach (var item in array)
{
    Console.Write(item + "  ");
}
Console.WriteLine();

// Вставка нуля после каждого отрицательного элемента
var modifiedList = new List<int>();
foreach (var item in array)
{
    modifiedList.Add(item);
    if (item < 0)
    {
        modifiedList.Add(0);
    }
}
int[] modifiedArray = modifiedList.ToArray();

Console.WriteLine("\nМассив после вставки нулей:");
foreach (var item in modifiedArray)
{
    Console.Write(item + "  ");
}
Console.WriteLine();

// Проверка изменения местоположения минимального элемента
int MinIndex = Array.IndexOf(array, array.Min());
int newMinIndex = Array.IndexOf(modifiedArray, modifiedArray.Min());
bool isMinIndexChanged = MinIndex != newMinIndex;

Console.WriteLine($"\nМестоположение минимального элемента изменилось: {isMinIndexChanged}");

// Нахождение суммы четных и произведения нечетных элементов
int Sum = modifiedArray.Where(x => x % 2 == 0).Sum();
int oddProduct = modifiedArray.Where(x => x % 2 != 0).Aggregate(1, (prod, next) => prod * next);

Console.WriteLine($"Сумма четных элементов: {Sum}");
Console.WriteLine($"Произведение нечетных элементов: {oddProduct}");


//зад2
//Console.Write("Введите k: ");
//int k = int.Parse(Console.ReadLine());

//Console.WriteLine();

//int[,] matrix = new int[k, k];

//Random rnd = new Random();

//for (int i = 0; i < k; i++)
//{
//    for (int j = 0; j < k; j++)
//    {
//        matrix[i, j] = rnd.Next(0, 10);
//    }
//}
//Console.WriteLine("Матрица: ");

//for (int i = 0; i < k; i++)
//{
//    for (int j = 0; j < k; j++)
//    {
//        Console.Write(matrix[i, j] + "  ");
//    }
//    Console.WriteLine();
//}

//Console.WriteLine();

//for (int i = 0; i < k; i++)
//{
//    int sum = 0;
//    for (int j = 0; j < k; j++)
//    {
//        sum += matrix[i, j];
//        if (i == j)
//        {

//            matrix[i, j] = sum - matrix[i, j];
//        }
//    }
//}

//Console.WriteLine("Матрица после изменения: ");

//for (int i = 0; i < k; i++)
//{
//    Console.WriteLine();
//    for (int j = 0; j < k; j++)
//    {
//        Console.Write(matrix[i, j] + "  ");

//    }
//}