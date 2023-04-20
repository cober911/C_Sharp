/* Задайте двухмерный массив размером m x n, каждый элемент в массиве находится по формуле:
A=m+n. Выведите полученный массив на экран.
M = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5 */

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;

        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = GetNumber("Введите число M: ");
int n = GetNumber("Введите число N: ");
int[,] matrix = InitMatrix(m, n);

Console.WriteLine("Марица:");
PrintMatrix(matrix);