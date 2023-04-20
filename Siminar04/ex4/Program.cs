/* Напишите программу которая выводит массив из 8 элементов,
заполненый нулями и единицами в случайном порядке. 
[1,0,1,1,0,1,0,0] */

Console.WriteLine("Введите размерность массива: ");
int demension = int.Parse(Console.ReadLine());
Random rnd= new Random(); // Переменная с рандомным значением.
int [] mass = new int[demension];

for (int i = 0; i < demension; i++)
{
    mass[i] = rnd.Next(0,2); //Массив из рандомных чисеол от 0 до 1.
}

var result = string.Join(", ", mass);
Console.WriteLine(result);

