// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.Write("Введите число: ");           
     
string? strNum1 = Console.ReadLine();

int Num1 = Convert.ToInt32(strNum1);         

if (Num1 < 100 || Num1 > 999)

System.Console.WriteLine("Неверное число");

else
{
int res = (Num1 / 10) % 10;

System.Console.WriteLine(res);
}


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Введите число: ");

int Value;
if (!int.TryParse(Console.ReadLine(), out Value))
{
    System.Console.WriteLine("Вы ввели не числовое значение!");
    return;
}

int ValueAbs = Math.Abs(Value);  

if (ValueAbs < 100)
{
    System.Console.WriteLine("Третьей цифры нет.");
    return;
}

while (ValueAbs > 999)
{
    if (ValueAbs > 999) ValueAbs /= 10;
}

System.Console.WriteLine($"Третья цифра в числе - {ValueAbs % 10}");


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Дни недели");

System.Console.Write("Какой по счету день недели? ");

int DayOfWeek;

if (! int.TryParse(Console.ReadLine(), out DayOfWeek))
{
  System.Console.WriteLine("Вы ввели не числовое значение!");
  return;
}

switch (DayOfWeek)
{
    case 1:
    System.Console.WriteLine("Сегодня понедельник, рабочий день(((");
    break;
    case 2:
    System.Console.WriteLine("Сегодня вторник, рабочий день(((");
    break;
    case 3:
    System.Console.WriteLine("Сегодня среда, рабочий день(((");
    break;
    case 4:                                                              
    System.Console.WriteLine("Сегодня четверг, рабочий день(((");
    break;
    case 5:
    System.Console.WriteLine("Сегодня пятница, рабочий день(((");
    break;
    case 6:
    System.Console.WriteLine("Сегодня суббота, выходные!");
    break;
    case 7:
    System.Console.WriteLine("Сегодня воскресенье, выходные!");
    break;
    default:
    System.Console.WriteLine("Нет такого дня недели!");
    break;
}
