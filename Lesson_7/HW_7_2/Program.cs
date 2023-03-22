// Задача 2. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

void Print(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

void Exam(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int row_user = int.Parse(Console.ReadLine()!);
    int column_user = int.Parse(Console.ReadLine()!);
    if (row_user > row || row_user < 1 || column_user > column || column_user < 1)
        Console.WriteLine("Такого элемента нет!");
    else Console.WriteLine($"Вот это значение по этим координатам: {arr[row_user - 1, column_user - 1]}");
}

int row_num = int.Parse(Console.ReadLine()!);
int column_num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);
Exam(mass);


