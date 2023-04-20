/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов
 и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
ввод элеменетов через консоль (через запятую. использовать метод string.Split()) */

Console.Write("Введите элементы массива: ");
int[] arr = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
var result = string.Join(", ", arr);
Console.Write($"[{result}]");



