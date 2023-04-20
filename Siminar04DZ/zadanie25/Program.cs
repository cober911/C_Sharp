/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int GetNumber(string msg)
{
    int result = 0;
    bool correctInput = false;

    while (!correctInput)
    {
        Console.Write(msg);
        correctInput = int.TryParse(Console.ReadLine(), out result);
        if (!correctInput)
            Console.WriteLine("Вы ввели не корректное число");
    }
    return result;
}

int MatPow(int number1, int number2)
{
    int result = 1;
    for (int i = 0; i < number2; i++)
    {
        result *= number1;
    }
    return result;
}

int number1 = GetNumber("Введите первое число: ");
int number2 = GetNumber("Введите второе число: ");
int result = MatPow(number1, number2);
Console.WriteLine($"Степень числа {number1} -> {result}");