// Напишите программу, которая по заданному номеру четверти показывает диапазон
// возможных координат точек в этой четверти (х и у).

void Coordinates(int num)

{
    if (num == 1) 
        Console.WriteLine("х > 0 и y > 0 ");
    else if (num == 2)
        Console.WriteLine("х < 0 и y > 0 ");
    else if (num == 3)
        Console.WriteLine("х < 0 и y < 0 ");
    else if (num == 4)
        Console.WriteLine("х > 0 и y < 0 ");
    else
        Console.WriteLine("Неверное значение четверти!");
}

Console.Write("Введите четверть=");
int num = int.Parse(Console.ReadLine()!);
Coordinates(num);
