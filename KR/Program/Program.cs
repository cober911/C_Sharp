void InputArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {   
        Console.WriteLine("Введите " + i + " элемент массива: ");
        array[i] = Convert.ToString(Console.ReadLine()!);
    }
}
void NewArray (string [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
        { 
            if (array[i].Length < 4)
                Console.Write($"{array[i]} ");  
        }
    Console.Write("]");
}


Console.WriteLine("Сколько элментов массива вы хотите ввести?");
int M = Convert.ToInt32(Console.ReadLine());
string [] array = new string[M];
InputArray(array);
Console.WriteLine();
Console.WriteLine($"Введённый массив: [{string.Join(", ", array)}]");
Console.Write("Полученный массив: ");
NewArray(array);