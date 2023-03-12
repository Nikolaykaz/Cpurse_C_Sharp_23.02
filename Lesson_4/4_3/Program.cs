﻿// Задача 4.3 Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void Massive(int mas)
{
    int[] numbers = new int[mas]; // Создание целочисленного массива numbers, mas - это из скольки элементов состоит массив.
    for (int i = 0; i < mas; i++)
    {
        numbers[i] = new Random().Next(2); // Диапазон "Рандома", до какого значения, нужно увеличивать на 1.
                                              // В нашем случае это .Next(0, 2). А числа будут "Рандомить" 0 и 1.
                                              // Можно оставить Next(2), потому что все равно стартует с 0.
        Console.WriteLine(numbers[i]);
    }
}
Massive(8);