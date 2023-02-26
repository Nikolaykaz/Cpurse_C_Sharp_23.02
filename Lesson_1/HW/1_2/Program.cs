// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих.
Console.WriteLine("Введите три числа:");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);
if (a > b && a > c)
{
   Console.Write($"Максимальное {a}");
} 
else if (b > c)
    {
    Console.Write($"Максимальное {b}");
    }
else 
{
Console.Write($"Максимальное {c}");
}