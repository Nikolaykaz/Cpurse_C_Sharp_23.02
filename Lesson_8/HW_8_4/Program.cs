// 4. Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен
// наименьший элемент массива.
// Способ. находим миним. фиксируем его позиции индексы, сверяем их, если натыкаемся
// то, пропускаем перезаписываем массив.

int rowNum = int.Parse(Console.ReadLine()!);
int columnNum = int.Parse(Console.ReadLine()!);
int min = int.Parse(Console.ReadLine()!);
int max = int.Parse(Console.ReadLine()!);
int[,] arr = new int[rowNum, columnNum];

FillArray(arr, min, max);
Console.WriteLine("Исходный массив:");
PrintArray(arr);
MinElement(arr);


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

void MinElement(int[,] arr)
{
  int min = arr[0, 0];
  int minRowIndex = 0;
  int minColumnIndex = 0;

  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      if (arr[i, j] < min)
      {
        min = arr[i, j];
        minRowIndex = i;
        minColumnIndex = j;
      }
    }
  }

  int[,] newArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];

  for (int i = 0, m = 0; i < arr.GetLength(0); i++)
  {
    if (i == minRowIndex)
    {
      continue;
    }

    for (int j = 0, n = 0; j < arr.GetLength(1); j++)
    {
      if (j == minColumnIndex)
      {
        continue;
      }

      newArr[m, n] = arr[i, j];
      n++;
    }

    m++;
  }

  Console.WriteLine("Новый массив:");
  PrintArray(newArr);
}
