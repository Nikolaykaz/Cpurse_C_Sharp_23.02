// Напишите программу, которая на выход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка). 
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);
if (a % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
Console.WriteLine("Число не четное");
}