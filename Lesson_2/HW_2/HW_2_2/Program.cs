// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);

if (a < 100)
{
    Console.WriteLine("Введенное число не трехзначное! ");
}
else
{
    int result = Number(a); 
    Console.Write($"Третья цифра числа: {Number(a)}");
}

int Number(int a)
{
    while (a > 999)
    {
        a /= 10;
    }       
    return a % 10;
}