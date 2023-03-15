// Задача 3. Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементом массива.
// [3, 7, 22, 2, 78] -> 76


double[] array = Massive();

double diff = FindDifference(array);

Output(array);

// Вывод массива.
void Output(double[] array)
{
    double num = array.Length; // Количество элементов в массиве.
    for (int i = 0; i < num; i++)
        Console.Write($"{array[i]} ");
}

Console.WriteLine($"Разница между макс. и мин. элементом массива = {diff}");

double[] Massive()
{
    // Создаем массив из 5 вещественных чисел
    double[] array = new double[5];

    // Заполняем массив случайными числами
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble() * 100; // Генерируем случайное вещественное число от 0 до 100
    }

    // Возвращаем созданный массив
    return array;
}

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