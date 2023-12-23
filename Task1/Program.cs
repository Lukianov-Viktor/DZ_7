// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

using System.Reflection;

Console.Write("Введите значение m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = Convert.ToInt32(Console.ReadLine());
void che(int m, int n)
{
    if (m > n)
    return;
    if (m % 2 == 0)
    {
        Console.Write($"{m},");
    }
    che(m + 1, n);
}
che(m,n);