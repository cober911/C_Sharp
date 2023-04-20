/* Задайте значение N. Напишите программу, которая вываедет все натуральные числа в промежутке от 1 до N.
N = 5->"1,2,3,4,5"
N = 6->"1,2,3,4,5,6" */

Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

string Recurs(int n)
{
    if (n == 0) return string.Empty;
    return n + " " + Recurs(n - 1);
}

Console.Write($"[{Recurs(n)}]");
