// Задача 4.0. НАпишите программу, которая принимает на вход число (А) и 
// выдает сумму чисел от 1 до А. Используем цикл For.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumNum(int num)
{
    int all_sum = 0;
    for (int i = 1; i <= num; i++)
        all_sum += i;

    return all_sum;
}
int A = int.Parse(Console.ReadLine()!);
int result = SumNum(A);
Console.WriteLine(result);