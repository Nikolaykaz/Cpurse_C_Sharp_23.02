// Задача 4.2 Напишите программу, которая принимает на вход число N и
// выдает произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int CompositionNum(int num)
{
    int multiply = 1;
    for (int i = 1; num >= i; i++)
        multiply *= i;

    return multiply;
}
int A = int.Parse(Console.ReadLine()!);
int result = CompositionNum(A);
Console.WriteLine(result);