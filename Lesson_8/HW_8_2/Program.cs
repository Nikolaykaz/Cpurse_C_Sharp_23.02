// 2. Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Дополнительно будет одномерный массив, в элементах которого, будут суммы строк
// прямоугольного двумерного массива. Указать номер строки с наименьшей суммой.

Console.WriteLine("Размерность прямоугольного двумерного массива:");
int dimension = int.Parse(Console.ReadLine()!);
Console.WriteLine("Мин значение эл. массива:");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Макс значение эл. массива:");
int max = int.Parse(Console.ReadLine()!);
int[,] arr = new int[dimension, dimension];
FillArray(arr, min, max);
Console.WriteLine("Исходный массив:");
PrintArray(arr);
RowSums(arr);
PrintMinSum(arr);


void FillArray(int[,] arr, int min, int max)
{
  Random rand = new Random();

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = rand.Next(min, max + 1);
    }
  }
}

void PrintArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write($"{arr[i, j],3} ");
    }
    Console.WriteLine();
  }
}

int[] RowSums(int[,] arr)
{
  int[] result = new int[arr.GetLength(0)];

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      sum += arr[i, j];
    }
    result[i] = sum;
  }

  return result;
}

void PrintMinSum(int[,] arr)
{
  int[] sums = RowSums(arr);
  int minIndex = 0;

  for (int i = 1; i < sums.Length; i++)
  {
    if (sums[i] < sums[minIndex])
    {
      minIndex = i;
    }
  }
  Console.WriteLine($"Строка {minIndex + 1} имеет наименьшую сумму: {sums[minIndex]}");
}
