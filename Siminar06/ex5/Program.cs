/* Напишите программу которая будет создавать копию заданного массива с помощью
поэлементного копироавания */

int GetNumber()
{
    Console.WriteLine("Введите длину массива: ");
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

Random rnd = new Random();
int[] InitArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
    {
        array[i] = rnd.Next(0, 10);
        Console.Write(array[i] + " ");
    }
    return array;
}

void GetArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
        Console.Write(newArray[i] + " ");
    }

}

int get = GetNumber();
int[] array = InitArray(get);
Console.WriteLine();
GetArray(array);
