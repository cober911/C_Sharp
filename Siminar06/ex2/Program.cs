/* Напишите программу которая принимает на вход три числа и проверяет 
может ли существовать треугольник со сторонами такой длины. 
Теорема: Каждая сторона треугольника меньше суммы двух его сторон.*/

Console.WriteLine("Введите три числа: ");
int[] chisla = new int[3];
for (int i = 0; i < chisla.Length; i++)
{
    chisla[i] = int.Parse(Console.ReadLine());
}

int a = chisla[0];
int b = chisla[1];
int c = chisla[2];



    if (a < (b + c) && b < (a + c) && c < (a + b))
    {
        Console.WriteLine("Треугольнику быть");
    }
    else Console.WriteLine("Стороны заданы не верно");







