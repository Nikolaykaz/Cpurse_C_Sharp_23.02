// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу кубов чисел от 1 до N.
// 3 -> 1,8,27
// 5 -> 1,8,27,64,125
void Squares(int n)
{
    double[] nums = new double[n]; // Создание массива n элементов массива и типом данных double. Он заполняется нулями.
    int index = 0;
    Console.Write($"{n} -> ");
    while (index < n)
    {
        nums[index] = Math.Pow((index + 1), 3); // Запись в ячейку index значения index + 1 в кубе.
        Console.Write($"{nums[index]}, ");
        index += 1;
    }
    Console.WriteLine();
}
Squares(int.Parse(Console.ReadLine()!));