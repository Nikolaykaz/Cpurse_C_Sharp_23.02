// Метод 1 - не принимают и не возвращают
//void Method1()
// {
//     Console.WriteLine("Автор...");
// }
//Method1();

// Метод 2 - ничего не возвращает, но принимает
//void Method2(string msg)
//{
//    Console.WriteLine(msg);
//}
//Method2("Текст сообщения");

// Метод 2_1 - Именованные аргументы. Какому аргументу,
// какое значение мы хотим указать. Прервать зацыкленную программу можно Ctrl + "C"

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//     Console.WriteLine(msg);
//     i++;
//     }
// }
// Method21(msg: "Текст сообщения", count: 4); // явно передали значение текст msg: "Текст" 

// Метод 3. Ничего не принимает, что то возвращает.
// Указываем тип данных, который мы ожидаем. return...

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// Метод 4. Что то принимают и что то возвращают.

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = string.Empty; // Значение resalt будет пустым string.Empty
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "qwer");
// Console.WriteLine(res);

string Method4(int count, string text)
{
    string result = string.Empty; // Значение resalt будет пустым string.Empty
    for(int i = 0;i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "qwer");
Console.WriteLine(res);

// Цикл в цикле For
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}