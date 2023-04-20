/* Напишите программу которая будет преобразовывать десятичное число в двоичное
45->101101 3->11 2->10 */

int GetNumber()
{
    Console.WriteLine("Введите десятичное число: ");
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

string ConverIntroBinary(int number)
{
    if (number == 0)
        return "0";
    int leftover = number % 2;
    string leftoverStr = string.Empty;
    while (number != 0)
    {
        leftover = number % 2;
        number = number / 2;
        leftoverStr += leftover.ToString();
    }
    return ReverseString(leftoverStr);
}

string ReverseString(string str)
{
    char[] array = str.ToCharArray();
    Array.Reverse(array);
    return new string(array);
}

int number = GetNumber();
string binaryNumber = ConverIntroBinary(number);
Console.WriteLine($"Двоичное число: {binaryNumber}");