// 1. Напишите программу, которая выводит случайное число
//    из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.WriteLine("Hello, World!");

int MaxNum(int num)
{
    Console.WriteLine(num);
    int num1 = num/10;
    int num2 = num % 10;
    if (num1 > num2) return num1;
    return num2;
}
int result = MaxNum(new Random().Next(100, 1000));
Console.WriteLine(result);