// Напишите программу, которая будет выдавать название дня недели 
// по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница
Console.WriteLine("Введите номер дня недели: ");
int numberA=int.Parse(Console.ReadLine());


if(numberA == "1"){
    Console.WriteLine("Понедельник");
}else if(numberA="2"){
    Console.WriteLine("Вторник");
}else if (numberA="3"){
    Console.WriteLine("Среда");
}else if (numberA="4"){
    Console.WriteLine("Четверг");
}else if (numberA="5"){
    Console.WriteLine("Пятница");
}else if (numberA="6"){
    Console.WriteLine("Суббота");
}else if (numberA="7"){
    Console.WriteLine("Воскресенье");
}else{
    Console.WriteLine("Такого дня недели не существует.");
}
//////////////////////////////////////////
// Console.WriteLine("Введите число:");
// int number = int.Parse(Console.ReadLine());

// switch (number)
// {
//     case 1:
//         Console.WriteLine("ПН");
//         break;
//     case 2:
//         Console.WriteLine("ВТ");
//         break;
//     case 3:
//         Console.WriteLine("СР");
//         break;
//     case 4:
//         Console.WriteLine("ЧТ");
//         break;
//     case 5:
//         Console.WriteLine("ПТ");
//         break;
//     case 6:
//         Console.WriteLine("СБ");
//         break;
//     case 7:
//         Console.WriteLine("ВС");
//         break;
//     default:
//         Console.WriteLine("Ввели чушь");
//         break;

// }
