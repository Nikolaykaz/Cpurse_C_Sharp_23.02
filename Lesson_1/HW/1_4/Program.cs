// Напишите программу, которая на вход принимает число (N), а на выходе показыает
// все четные числа от 1 до N.
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);
int i = 2;
if (a % 2 == 0)
{
     a = a;
}
else 
{
    a = a - 1;
}
while (i <= a)
{
    Console.Write($"{i} ");
    i = i + 2;
}