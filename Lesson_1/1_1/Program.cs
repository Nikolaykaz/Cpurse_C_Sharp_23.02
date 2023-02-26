// Напишите программу, которая на воход принимает два числа 
// и проверяет, является ли первое число квадратом второго.
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
if (a == b * b)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}