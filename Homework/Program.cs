//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное число

/*
Console.Write("Видите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Видите второе число: ");
int seondNumbers = Convert.ToInt32(Console.ReadLine());

if (firstNumber > seondNumbers)
{
    Console.WriteLine(firstNumber);
}

else
{
    Console.WriteLine(seondNumbers);
}
*/

//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Видите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Видите второе число: ");
int seondNumbers = Convert.ToInt32(Console.ReadLine());

Console.Write("Видите третее число: ");
int thirdNumbers = Convert.ToInt32(Console.ReadLine());

int maxNamber = firstNumber;


if (firstNumber > maxNamber) maxNamber = firstNumber;
if (seondNumbers > maxNamber) maxNamber = seondNumbers;
if (thirdNumbers > maxNamber) maxNamber = thirdNumbers;
      Console.WriteLine(maxNamber);

*/
 

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Введите число: ");
int numbers = Convert.ToInt32(Console.ReadLine());

if (numbers%2 == 0)
{
    Console.Write("Число: " + numbers + " является четным числом ");
}
else
{
    Console.Write("Число: " + numbers + " не четное число ");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int numbers = 0;
int numbersN = 1;
Console.Write("Введите число: ");
numbers = Convert.ToInt32(Console.ReadLine());

while (numbersN <= numbers)
{
    
    if (numbersN%2 == 0)
    {
        Console.WriteLine(numbersN);
    }  
    numbersN++;  
}

