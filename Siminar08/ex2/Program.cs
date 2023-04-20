/* Задайте двумерный массивюНапишите программу, которая заменяет строки на столбцы.
В случае, если это не возможно, программа должна вывести сообщение для пользователя. */

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

Random rnd = new Random();

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
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

int[,] ReplaceStrings(int[,] matrix)
{
    int[,] matrixReplaced = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrixReplaced.GetLength(0); i++)
    {
        for (int j = 0; j < matrixReplaced.GetLength(1); j++)
        {
            matrixReplaced[i,j]=matrix[j,i];
        }
    }
    return matrixReplaced;   
}
int m = GetNumber("Введите число M: ");
int n = GetNumber("Введите число N: ");
int[,] matrix = InitMatrix(m, n);
Console.WriteLine("Матрица: ");
PrintMatrix(matrix);
Console.WriteLine();
int[,] result = ReplaceStrings(matrix);
PrintMatrix(result);