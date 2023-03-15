// Проблема в неявном преобразовании переменной. double в int


// Сняли показания пользователя о массиве.
Console.Write("Сколько элементов будет в массиве? ");
double num = int.Parse(Console.ReadLine()!);
Console.Write("Какой будет диапазон чисел, каждого элемента массива? (Пример. От: 5 До: 30) ");
Console.Write("От: ");
double min = int.Parse(Console.ReadLine()!);
Console.Write("До: ");
double max = int.Parse(Console.ReadLine()!);

// Описали, какой будет массив, сколько элементов, какой рандом каждого элемента.   
double[] mass = Massive(num, min, max);

// Выводим наш массив. 
Output(mass);
// Находим разницу между максимальным и минимальным элементом массива.
double diff = FindDifference(mass);
// Выводим разницу между мин-макс.
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {diff}");

// Заполнение массива по входным данным.
double[] Massive(double num, double min, double max)
{
    double[] numbers = new double[num];
    for (int i = 0; i < num; i++)
    {
        numbers[i] = new Random().NextDouble(min, max);
        Console.WriteLine(numbers[i]);
    }
    return numbers;
}

// Вывод массива.
void Output(double[] numbers)
{
    double num = numbers.Length; // Количество элементов в массиве.
    for (int i = 0; i < num; i++)
        Console.Write($"{numbers[i]} ");
}

// Вычисление разницы между миним. и макс. значением элементов массива.
double FindDifference(double[] array)
{
    double max = array[0]; // Предполагаем, что первый элемент является максимальным
    double min = array[0]; // Предполагаем, что первый элемент является минимальным

    // Находим максимальный и минимальный элементы массива
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    // Вычисляем разницу между максимальным и минимальным элементом массива
    double diff = max - min;
    // Возвращаем разницу между максимальным и минимальным элементом массива
    return diff;
}