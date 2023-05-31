// Задание 10 Принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Random rand = new Random();
int randNambers = rand.Next(100, 1000);
Console.WriteLine(randNambers);

int rezu = ((randNambers / 10) % 10);

Console.WriteLine(rezu);
*/

// Задание 13 Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Random rand = new Random();
int randNambers = rand.Next(10, 1000);
Console.WriteLine(randNambers);

 

if ((randNambers / 10 > 0) && (randNambers / 100 == 0)) 
{
    Console.WriteLine("Не имеет третей цыфры");
}
else
{
    int a = randNambers % 10;
    Console.WriteLine(a);
}
*/

//Задание 15 второй вариант: Принимает любой день недели и выдает выходной это день или будний
/*
Console.WriteLine("Напишите любой день недели ");
string naim = Console.ReadLine();

if (naim == "Понедельник") Console.WriteLine($"{naim} работать еще целую неделю");
if (naim == "Вторник") Console.WriteLine($"{naim} до выходных еще далеко");
if (naim == "Среда") Console.WriteLine($"{naim} уже устал от работы");   
if (naim == "Четверг") Console.WriteLine($"{naim} опять на работу");
if (naim == "Пятница") Console.WriteLine($"{naim} уже нет сил работать");
if (naim == "Суббота") Console.WriteLine($"{naim} ура выходные !");
if (naim == "Воскресенье") Console.WriteLine($"{naim} отсыпаюсь после субботы");
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.WriteLine("Напишите число от 1 до 7 ");
int a = int.Parse(Console.ReadLine()); 

if (a < 6 && a < 7)
{
    Console.WriteLine($"{a} день недели будний день");
}
else
{
    Console.WriteLine($"{a} ура выходной день !");
}
*/