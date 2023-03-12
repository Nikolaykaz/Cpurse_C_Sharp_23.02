// Задача 4.1 Напишите цикл, который принимает на вход
// два числа (А и В) и возводит число А в натуральную степень В.
// 3,5 -> 234 (3 в 5 степени) 3*3*3*3*3
// 2,4 -> 16 (2 в 4 степени) 2*2*2*2

Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
double result = Power(A, B);
Console.WriteLine(result);

double Power(int A, int B)
{
    double num = 1;
    for (int i = 1; i <= B; i++)
    {
        num = num * A;
    }
    return num;
}




// int result = A;
// for (int i = 1; B > i; i++)
// {
//     result = result * A; 
// }
// Console.WriteLine(result);

