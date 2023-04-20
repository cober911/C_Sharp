/* Напишите программу которая на вход принимает число
и выдает кол-во цифр в числе. 
456-> 3
78-> 2
89126-> 5 */

// int GetNumber(string msg)
// {
//     int result = 0;
//     bool correctInput = false;

//     while (!correctInput)
//     {
//         Console.WriteLine(msg);
//         correctInput = int.TryParse(Console.ReadLine(), out result);
//         if (!correctInput)
//             Console.WriteLine("Вы ввели не корректное число");
//         Console.WriteLine();
//     }
//     return result;
// }

// int GetSumm(int number)
// {
// int sum = 0;
//     for(int i = 0; i< length; i++)
//     {

//     }
//     return sum;
// }

// int number=GetNumber("Введите число: ");
// int sum=GetSumm(number);
// Console.WriteLine($"Кол-во цифр в числе: {number} равно {sum}");

Console.WriteLine("Введите число");
string number = Console.ReadLine();
int count = 0;
for (int i = 0; i < number.Length; i++)
{
    if (int.TryParse(number[i].ToString(), out int result))
        count++;
}
Console.WriteLine(count);