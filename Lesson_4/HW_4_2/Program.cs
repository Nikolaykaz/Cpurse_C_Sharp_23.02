// Задача 4.2 Напишите программу, которая принимает на вход число
// и выдает сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Number(int num)
 {
    int result = 0;
     for (int i = 1; num > 0; i++)
    {   
     result = result + (num % 10);
     num = num / 10;
    }
    return result;
 }

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int result = Number(num);
Console.WriteLine(result);