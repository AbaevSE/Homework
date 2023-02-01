// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите число 1");   
string strNumber1_1 = Console.ReadLine();   
int Number1_1 = Convert.ToInt32(strNumber1_1);    

System.Console.WriteLine("Введите число 2");   
string strNumber1_2 = Console.ReadLine();   
int Number1_2 = Convert.ToInt32(strNumber1_2);    

if (Number1_1 > Number1_2)     
{
  System.Console.WriteLine("max = " + Number1_1 + ", min = " + 

Number1_2); 
}
else    
{
  System.Console.WriteLine("max = " + Number1_2 + ", min = " + 

Number1_1);
}

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//  2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3  9 -> 22

System.Console.WriteLine("Введите число 1");      
string? strSet1_1 = Console.ReadLine();           
int Set1_1 = Convert.ToInt32(strSet1_1);          

System.Console.WriteLine("Введите число 2");      
string? strSet1_2 = Console.ReadLine();           
int Set1_2 = Convert.ToInt32(strSet1_2);         

System.Console.WriteLine("Введите число 3");      
string? strSet1_3 = Console.ReadLine();           
int Set1_3 = Convert.ToInt32(strSet1_3);         

int max = Set1_1;

if  (max < Set1_2) max = Set1_2;                  
                                                      
if  (max < Set1_3) max = Set1_3;                  

System.Console.WriteLine("max = " + max);

// //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//  4 -> да
// -3 -> нет
//  7 -> нет

System.Console.WriteLine("Введите число: ");           
     
string? strNum1= Console.ReadLine();

int Num1 = Convert.ToInt32(strNum1);         

if (Num1 % 2 == 0) 

  Console.WriteLine("Введеное число является чётным");

else 
  {
    Console.WriteLine("Введеное число является нечётным");
  }

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число: ");

string? strOut1= Console.ReadLine();

int Out1 = Convert.ToInt32(strOut1); 

if (Out1 <= 1)
{
  System.Console.WriteLine("Решений нет!");
  return;
}

else
{
  int Out2 = 2;
  while (Out2 <= Out1)
  {
    System.Console.Write(Out2 + " "); 
    Out2 = Out2 + 2;
  }
}

System.Console.WriteLine();
