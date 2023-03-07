// Задача 1. Напишите программу, которая принимает на вход координаты точки (x и y), 
// причем x не равно 0 и y не равно 0 и выдет номер четверни плоскости, 
// в которой находится эта точка. 

void Quarters(int x, int y)
{
    if (x == 0 || y == 0) // "||" логическое "или"
        Console.WriteLine("Введены неверные значения, x или y = 0");
    else if (x > 0 && y > 0) // "&&" амперсант, логическое "и"
        Console.WriteLine("Координаты в I четверти");
    else if (x < 0 && y > 0) 
        Console.WriteLine("Координаты в II четверти");
    else if (x < 0 && y < 0) 
        Console.WriteLine("Координаты в III четверти");
    else if (x > 0 && y < 0) 
        Console.WriteLine("Координаты в IV четверти");
}
// Quarters(1, -1); // таким образом вводим в функцию явные значения

// Тут вводим данные более наглядно
Console.Write("Введите x= ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите y= ");
int y = int.Parse(Console.ReadLine()!);
Quarters(x, y); // Вводим значения x и y