// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите пятизначное число=");
int num = int.Parse(Console.ReadLine()!);
int num1 = num;
Palindrome(num);

void Palindrome(int num)
{
    if (num / 10000 == num % 10 || num1 / 1000 % 10 == num1 % 10 / 10)
        Console.Write("Это число палиндром!");
    else Console.Write("Это число НЕ палиндром!");
}
