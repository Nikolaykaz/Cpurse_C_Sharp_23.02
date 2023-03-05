// Напишите программу, которая принимает на вход трехзначное чило
// и на выходе показывает вторую цифру этого числа.

string NumSec(int num)
{
    if ((-1000 < num && num < -100) || (num < 1000 && num > 100))
        return $"{num / 10 % 10}";
    return "Это число не трехзначное!";
}

Console.WriteLine(NumSec(int.Parse(Console.ReadLine()!)));