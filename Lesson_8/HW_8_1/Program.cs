// 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.

int rowNum = int.Parse(Console.ReadLine()!);
int columnNum = int.Parse(Console.ReadLine()!);
int min = int.Parse(Console.ReadLine()!);
int max = int.Parse(Console.ReadLine()!);
int[,] arr = new int[rowNum, columnNum];
FillArray(arr, min, max);
Console.WriteLine("Исходный массив:");
PrintArray(arr);
SortArray(arr);
Console.WriteLine("Отсортированный массив:");
PrintArray(arr);

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
// Пузырьковый метод сортировки.
// void SortArray(int[,] arr)
// {
//   for (int i = 0; i < arr.GetLength(0); i++)
//   {
//     for (int j = 0; j < arr.GetLength(1) - 1; j++)
//     {
//       for (int k = j + 1; k < arr.GetLength(1); k++)
//       {
//         if (arr[i, j] < arr[i, k])
//         {
//           int temp = arr[i, j];
//           arr[i, j] = arr[i, k];
//           arr[i, k] = temp;
//         }
//       }
//     }
//   }
// }

// Метод Картежей.
void SortArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1) - 1; j++)
    {
      for (int k = j + 1; k < arr.GetLength(1); k++)
      {
        if (arr[i, j] < arr[i, k])
        {
          (arr[i, j], arr[i, k]) = (arr[i, k], arr[i, j]);
        }
      }
    }
  }
}
