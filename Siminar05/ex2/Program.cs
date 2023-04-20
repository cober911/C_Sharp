/* Напишите программу замена элементов массива: положительные элементы замените на соответсвующие отрицательные,
и наоборот. 
[-4, -8, 8, 2]-> [4,8,-8,-2] */

int[] InitArray(int demension)
{
    int[] arr = new int[demension];
    Random rnd = new Random();
    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(-9, 10);
    }
    return arr;
}



int[] NewArray(int[] array)
{
    int[] resultArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        resultArray[i] = -array[i];
    }
    return resultArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }

    Console.WriteLine();
}

int[] array = InitArray(4);
PrintArray(array);
int[] resultArray = NewArray(array);
PrintArray(resultArray);
