﻿// Ввести число и программа выдасть этому числу значение названия дня недели.
// 1 это Понедельник "Monday", 2 это Вторник.... и т.д.
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine()!);
if( a == 1)
{
    Console.WriteLine("Monday");
}
else if(a == 2)
{
    Console.WriteLine("Tuesday");
}
else if(a == 3)
{
    Console.WriteLine("Wednesday");
}
else if(a == 4)
{
    Console.WriteLine("Thursday");
}
else if(a == 5)
{
    Console.WriteLine("Friday");
}
else if(a == 6)
{
    Console.WriteLine("Saturday");
}
else if(a == 7)
{
    Console.WriteLine("Sunday");
}
else
{
   Console.WriteLine("Error"); 
}