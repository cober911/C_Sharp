//Программа которая на вход принимает число и выдает его квадрат(число кмноженное само на себя)
string numberStr=Console.ReadLine();
int number=int.Parse(numberStr); //стринж в интеджер конверт

int result = number * number;

Console.WriteLine($"Число {number}, Квадрат: {result}"); // Интерполирование тоесть вместо знаков +
