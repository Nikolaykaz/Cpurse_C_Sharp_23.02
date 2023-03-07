Console.Write("Введите пятизначное число=");
int num = int.Parse(Console.ReadLine()!);
int num1 = num;
//Console.WriteLine(num / 10000);
Console.WriteLine(num / 1000 % 10);
Console.Write(num % 100 / 10);

// if (num / 10000 == num % 10 && num1 / 1000 % 10 == num1 % 100 / 10)
//        Console.Write("Это число палиндром!");
//    else Console.Write("Это число НЕ палиндром!");
