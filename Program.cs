﻿/* Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

 Например:
 4 -> 16 
 -3 -> 9 
 -7 -> 49 */

/*
Console.Write("Видите Число: ");
int namber = Convert.ToInt32(Console.ReadLine()); 

int result = namber * namber;

double resultPantTwo = Math.Pow(namber,2);

Console.WriteLine(" Число " + namber + " в квадрате: " + result);
Console.WriteLine(" Число " + namber + " в квадрате: " + resultPantTwo);
*/


/*1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/


Console.Write("Видите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Видите второе число: ");
int seondNumbers = Convert.ToInt32(Console.ReadLine());

if (firstNumber == seondNumbers * seondNumbers);
{
    Console.WriteLine("Число "+ firstNumber + "Является кводратом числа " + seondNumbers);
}
else
{
    Console.WriteLine("Число "+ firstNumber + "Не является кводратом числа" + seondNumbers);
}
