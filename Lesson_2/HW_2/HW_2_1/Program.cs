// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// Решение с функцией

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num = (num / 10) % 10;
}

int result = TakeNum(new Random().Next(100, 1000));
Console.WriteLine(result);

// Решение без функции
//int num = new Random().Next(100, 1000);
//Console.WriteLine(num);
//Console.WriteLine(num = (num / 10) % 10);
