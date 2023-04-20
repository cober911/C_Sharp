/*Напишите программу, которая принимает на вход 
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
выдаёт номер четверти плоскости, в которой 
находится эта точка.  
x=34; y=-30 -> 4   
x=2; y=4-> 1  
x=-34; y=-30 -> 3 */


int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int QuterTest(int x, int y);
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    if (x > 0 && y < 0)
    {
        return 2;
    }
    if (x < 0 && y < 0)
    {
        return 3;
    }
    if (x < 0 && y > 0)
    {
        return 4;
    }
    return -1;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

ReadData("Введите координату X не равную 0: ");

int coordX = ReadData("Введите координату X не равную 0: ");
int coordX = ReadData("Введите координату Y не равную 0: ");