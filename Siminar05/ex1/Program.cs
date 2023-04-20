/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
сумма отрицательных равна -20.
*/

// метод инициализации масиива
int[] InitArray(int demension)
{
    int[] arr = new int[demension];
    Random rnd = new Random();
    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(-9, 9);
    }
    return arr;
}

// метод который печатает массив на консоль
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }

    Console.WriteLine();
}

// // метод который получает сумму положительных элементов
// int GetSumPositive(int[] array)
// {
//     int summ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//             summ += array[i];
//     }
//     return summ;
// }
// // метод который получает сумму отрицательных чисел
// int GetSumNegative(int[] array)
// {
//     int summ = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//             summ += array[i];
//     }
//     return summ;
//}
// метод который получает сумму положительных и отриц элементов
// первый int это сумма положительных. Второй int сумма отрицательных.
(int, int) GetSumms(int[] array)
{
    int negativeSum = 0;
    int positiveSum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            positiveSum += array[i];
        else if(array[i]<0)
            negativeSum += array[i];    
    }
    return(positiveSum, negativeSum);
}

int[] arr = InitArray(12);
PrintArray(arr);
(int pos, int neg) = GetSumms(arr);
Console.WriteLine($"Сумма положительных чисел: {pos}, Сумма отрицательных чисел: {neg}");
// int positiveSumm = GetSumPositive(arr);
// int negativeSumm = GetSumNegative(arr);

// Console.WriteLine($"Сумма положительных чисел: {positiveSumm}");
// Console.WriteLine($"Сумма отрицательных чисел: {negativeSumm}");