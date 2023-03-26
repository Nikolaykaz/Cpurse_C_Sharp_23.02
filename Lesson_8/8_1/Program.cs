// 1. Задайте двумерный массив. Напишите программу, которая поменяет
// местами первую и последнюю строку массива.

void ReplaceIndex(int[,] array)
{
int ArrayRow = array.GetLength(0);
int ArrayColumn = array.GetLength(1);

for (int j = 0; j < ArrayColumn; j++)
{
(array[0,j] , array[ArrayRow - 1 ,j]) = (array[ArrayRow - 1, j], array[0,j]);
}
}
