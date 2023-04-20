/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Write("Введите чилсло M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите чилсло N: ");
int n = int.Parse(Console.ReadLine()!);
int recursion(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return recursion(m - 1, 1);
    }
    else
    {
        return recursion(m - 1, recursion(m, n - 1));
    }
}
Console.WriteLine($" A({m}, {n}) = {recursion(m, n)}");