/* Задайте двумерный массив. Найдите элементы, у которых оба индекса четные,
и замените эти элементы на их квадраты.
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
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

int[,] NewArray(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                newMatrix[i, j] = matrix[i, j] * matrix[i, j];
            }
            else
            {
                newMatrix[i,j]=matrix[i,j];
            }
        }
    }
    return newMatrix;
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
int[,] newMatrix = NewArray(matrix);
Console.WriteLine("Матрица: ");
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(newMatrix);
