// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите количество чисел N, с которыми будем работать: ");
int n = int.Parse(Console.ReadLine()!);
double[] numbers = new double[n];
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите {i+1}-ое число: ");
    numbers[i] = double.Parse(Console.ReadLine()!);
}

int count = CountPositive(numbers);
Console.WriteLine($"Количество положительных чисел:  {count}");

    
int CountPositive(double[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
        {
            count++;
        }
    }
    return count;
}