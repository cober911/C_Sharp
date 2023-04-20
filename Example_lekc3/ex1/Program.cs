void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int g = 0; g < matr.GetLength(1); g++)
        {
            Console.Write($"{matr[i, g]} ");
        }
        Console.WriteLine();
    }
}

void FillAray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int g = 0; g < matr.GetLength(1); g++)
        {
            matr[i,g]= new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3, 4];
FillAray(matrix);
PrintArray(matrix);