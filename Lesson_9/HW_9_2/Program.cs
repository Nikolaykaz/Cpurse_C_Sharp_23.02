// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

int m = 1; // значение M
int n = 15; // значение N
int sum = Sum(m, n);
// Console.WriteLine($"Сумма чисел от {m} до {n} равна {sum}");
Console.WriteLine("Сумма чисел от {0} до {1} равна {2}", m, n, sum);

int Sum(int m, int n)
{
  if (m == n)
  {
    return m;
  }
  else
  {
    return m + Sum(m + 1, n);
  }
}
