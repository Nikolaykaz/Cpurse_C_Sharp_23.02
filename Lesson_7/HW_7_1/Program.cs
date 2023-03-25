// Задача 1. Задайте двуменрный массив размером m на n,
// заполненный случайными вещественными числами.
// double number = 3.1415926;
// Console.WriteLine($"Число с округлением до сотых: {arr[i, j]:F2}");
// Console.WriteLine($" {Math.Round(arr[i, j], 2)}");
void Print(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            //Console.Write($" {arr[i, j]} ");
            Console.Write($" {arr[i, j]:F2} "); // вывел только два знака после запятой.
            //Console.WriteLine($" {Math.Round(arr[i, j], 2)}");
        Console.WriteLine();
    }
}

double[,] MassNums(int row, int column, int from, int to)
{
    double[,] arr = new double[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = Math.Round(new Random().NextDouble() * (to - from) + from, 3); // 3 знака после запятой.

    return arr;
}

int row_num = int.Parse(Console.ReadLine()!);
int column_num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

double[,] mass = MassNums(row_num, column_num, start, stop);
Print(mass);