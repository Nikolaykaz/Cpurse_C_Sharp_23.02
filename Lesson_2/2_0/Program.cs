// Напишите программу, которая принимает на вход трехзначное число 
// и на выход показывает последниюю цифру этого числа.

// Реализация с функцией

int TakeNum(int num)
{
    Console.WriteLine(num);
    return num % 10;
}

int result = TakeNum(new Random().Next(100, 100));
Console.WriteLine(result);

//Реализация без функции

//int num = new Random().Next(100, 1000);
//Console.WriteLine(num);
//Console.WriteLine(num % 10);
