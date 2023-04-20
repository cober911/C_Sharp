/* Задайте одномерный массив из 123 случайных чисел, найдите кол-во элемпентов массива, значения которых
лежат в отрезке от 10 до 99 включительно. */

Random rnd = new Random();
int[] arr = new int[10];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next(-99, 1000);
}

string result = string.Join(", ", arr);
Console.WriteLine($"[{result}]");

int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] >= 10 && arr[i] <= 99)
    {
        count++;
    }
}
Console.WriteLine($"Количество элементов от 10 до 99: {count}");
