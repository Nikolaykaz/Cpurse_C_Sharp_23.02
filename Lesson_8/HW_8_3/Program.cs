// 3. Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
// Метод "програмистский)"...
// Или по формуле...

// Ввод данных от пользователя
Console.WriteLine("Введите кол-во строк:");
int rowNum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите кол-во столбцов:");
int columnNum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Мин.:");
int min = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите Макс.:");
int max = int.Parse(Console.ReadLine()!);

// Формирование матриц
int[,] matrix1 = new int[rowNum, columnNum]; // Соглосование матриц
int[,] matrix2 = new int[columnNum, rowNum];
FillArray(matrix1, min, max);
FillArray(matrix2, min, max);

// Перемножение матриц
int[,] result = MultiMatrix(matrix1, matrix2);

// Вывод матриц
Console.WriteLine("Матрица 1:");
PrintMatrix(matrix1);
Console.WriteLine("Матрица 2:");
PrintMatrix(matrix2);
Console.WriteLine("Результат:");
PrintMatrix(result);

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

int[,] MultiMatrix(int[,] matrixA, int[,] matrixB)
{
  int rowsA = matrixA.GetLength(0);
  int colsA = matrixA.GetLength(1);
  int rowsB = matrixB.GetLength(0);
  int colsB = matrixB.GetLength(1);

  // if (colsA != rowsB) // Проверка не нужна - матрицы согласованы
  // {
  //   Console.WriteLine("Матрицы не могут быть перемножены.");
  //   return null;
  // }

  int[,] result = new int[rowsA, colsB];

  for (int i = 0; i < rowsA; i++)
  {
    for (int j = 0; j < colsB; j++)
    {
      int sum = 0;
      for (int k = 0; k < colsA; k++)
      {
        sum += matrixA[i, k] * matrixB[k, j];
      }
      result[i, j] = sum;
    }
  }

  return result;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
  }
}