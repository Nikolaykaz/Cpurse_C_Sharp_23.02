// Напишите крограмму которая, принимает на вход число (N)
// и выдает таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

int num = int.Parse(Console.ReadLine()!);

void Div(int n)
{
    int i = 1;
    while(n >= i)
    {
        Console.WriteLine(Math.Pow(i, 2));
        i++;
    }
}
Div(num);