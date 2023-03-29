// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.

int m = 1;  // значение M
int n = 20; // значение N

Console.WriteLine($"Чётные числа от {m} до {n}:");
PrintRecursive(m, n);

void PrintRecursive(int m, int n)
{
  if (m > n)
  {
    return;
  }

  if (m % 2 == 0)
  {
    Console.Write($"{m} ");
  }

  PrintRecursive(m + 1, n);
}
