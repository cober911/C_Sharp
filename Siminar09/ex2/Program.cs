/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


Console.Write("Введите чилсло M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите чилсло N: ");
int n = int.Parse(Console.ReadLine()!);
int RecursSumm(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    return (m + RecursSumm(m + 1, n));
}
Console.WriteLine(RecursSumm(m, n));