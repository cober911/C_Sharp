/* Не использу рекурсию, выведите N чисел Фибоначи, первые два числа фибоначи: 0  и 1. 
Если N = 5 -> 0 1 1 2 3 
Если N = 3 -> 0 1 1 */

int GetNumber()
{
    Console.WriteLine("Введите десятичное число: ");
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void Fibonachi(int number)
{
    double[] fib = new double[number];
    fib[0] = 0;
    fib[1] = 1;
    Console.Write($"{fib[0]} {fib[1]} ");
    int i = 2;
    while (i <= number - 1)
    {
        fib[i] = fib[i - 2] + fib[i - 1];
        Console.Write($"{fib[i]} ");
        i++;
    }
}
int num = GetNumber();
Fibonachi(num);

