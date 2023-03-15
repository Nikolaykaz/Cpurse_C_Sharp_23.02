// Задача 2. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на не четных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
        numbers[i] = new Random().Next(min, max);
    return numbers;
}

// Вывод массива.
void Output(int[] numbers)
{
    int num = numbers.Length; // Количество элементов в массиве.
    for (int i = 0; i < num; i++)
        Console.Write($"{numbers[i]} ");
}

// Подсчет суммы элем. стоящих на нечет. позициях.
void EvenCount(int[] numbers)
{
    int odd = 0;
    for (int i = 1; i < numbers.Length; i += 2)
    {
        odd += numbers[i];
    }
    Console.Write($" Сумма элементов, стоящих на нечетных позициях: {odd}");
}