/* Принимает на вход число N и выдает
произведение чисел от 1 до N.
4->24
5->120 */

int GetNumber(string msg)
{
    int result = 0;
    bool correctInput = false;

    while (!correctInput)
    {
        Console.WriteLine(msg);
        correctInput = int.TryParse(Console.ReadLine(), out result);
        if (result < 1)
            correctInput = false;
        if (!correctInput)
            Console.WriteLine("Вы ввели не корректное число");
        Console.WriteLine();
    }
    return result;
}

int GetMultiple(int number)
{
    int mult = 1;
    for (int i = 1; i <= number; i++)
    {
        mult = mult*i;
    }
    return mult;
}

int number = GetNumber("Введите число: ");
int mult = GetMultiple(number);
Console.WriteLine($"Произведение чисел от 1 до: {number} равно {mult}");