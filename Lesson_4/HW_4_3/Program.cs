﻿// Задача 4.3 Напишите программу, которая задает массив из (8 элементов)
// случайными числами и выводит их на экран. Оформить заполнение массива
// и вывода в виде функции.
// Две функции 1. Заполнение массива. 2. Вывод массива.

// Сняли показания пользователя о массиве.
    Console.Write("Сколько элементов будет в массиве? ");
    int num = int.Parse(Console.ReadLine()!);
    Console.Write("Какой будет диапазон чисел, каждого элемента массива? (Пример. От: 5 До: 30) ");
    Console.Write("От: ");
    int min = int.Parse(Console.ReadLine()!);
    Console.Write("До: ");
    int max = int.Parse(Console.ReadLine()!);

// Передали данные.   
int[] mass = Massive(num, min, max);
Output(mass);

// Сборка массива.
int[] Massive(int num, int min, int max) 
{  
    int[] numbers = new int[num];
    for (int i = 0; i < num; i++)
    numbers[i] = new Random().Next(min, max); // Диапазон "Рандома", до какого значения, нужно увеличивать на 1.
                                              // В нашем случае это .Next(0, 2). А числа будут "Рандомить" 0 и 1.
                                              // Можно оставить Next(2), потому что все равно стартует с 0.
    return numbers;
}

// Вывод массива.
void Output(int[] numbers)
{
    int num = numbers.Length; // Количество элементов в массиве.
    for (int i = 0; i < num; i++)
        Console.Write($"{numbers[i]},");
}