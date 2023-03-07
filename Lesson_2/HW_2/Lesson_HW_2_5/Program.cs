// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели и проверяет, является ли этот день выходным.

void Weekend(int num)
{
    string text = "No";
    if (num == 7 || num == 6) text = "Weekend"; // "||" это логическое "или"
    else if (num < 6 && num > 0) text = "Workday"; // "&&" это логическое "и"
    Console.WriteLine($"{num} -> {text}");
}

Weekend(int.Parse(Console.ReadLine()!));
