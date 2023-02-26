// Задача 1. Напишите программу, которая на вход принимает два числа
// а выдает, какое число больше, а какое меньшее.
Console.WriteLine("Введите два числа:");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
    Console.Write($"Число {a} > {b}");
}
else if (a < b)
{
    Console.Write($"Число {a} < {b}");   
}
else if (a == b)
{
    Console.Write($"Число {a} = {b}");
}  