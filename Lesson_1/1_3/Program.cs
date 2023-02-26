// Напишите программу, которая на вход принмает одно число (N), 
// а на выходе показыает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);
int b = -a;
while (b <= a)
{
    Console.Write($"{b} ");
    b = b + 1;
}
