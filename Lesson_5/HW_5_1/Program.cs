// Задача 1. Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет поличество четных чисел в массиве.
// [345, 897, 568 234] -> 2

// Сняли показания пользователя о массиве.
Console.Write("Сколько элементов будет в массиве? ");
int num = int.Parse(Console.ReadLine()!);
Console.Write("Какой будет диапазон чисел, каждого элемента массива? (Пример. От: 5 До: 30) ");
Console.Write("От: ");
int min = int.Parse(Console.ReadLine()!);
Console.Write("До: ");
int max = int.Parse(Console.ReadLine()!);

// Описали, какой будет массив, сколько элементов, какой рандом каждого элемента.   
int[] mass = Massive(num, min, max);
Output(mass);
EvenCount(mass);

// Заполнение массива по входным данным.
int[] Massive(int num, int min, int max)
{
    int[] numbers = new int[num];
    for (int i = 0; i < num; i++)
        numbers[i] = new Random().Next(min, max); // Диапазон "Рандома", до какого значения, нужно увеличивать на 1.
                                                  // В нашем случае это .Next(0, 2). А числа будут "Рандомить" 0 и 1.
                                                  // Можно оставить Next(2), потому что все равно стартует с 0.
    return numbers;
}

// Вывод массива.
void Output(int[] numbers)
{
    int num = numbers.Length; // Количество элементов в массиве.
    for (int i = 0; i < num; i++)
        Console.Write($"{numbers[i]} ");
}

// Подсчет четных чисел в массиве.
void EvenCount(int[] numbers)
{
    int even = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            even++;
        }
    }
    Console.Write($" Четных чисел в массиве: {even}");
}