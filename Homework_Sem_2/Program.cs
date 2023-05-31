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

//Задание 15 Принимает любой день недели и выдает выходной это день или будний
Console.WriteLine("Напишите любой день недели ");
string naim = Console.ReadLine();

if (naim == "Понедельник") Console.WriteLine($"{naim} это будний день");
if (naim == "Вторник") Console.WriteLine($"{naim} это будний день");
if (naim == "Среда") Console.WriteLine($"{naim} это будний день");   
if (naim == "Четверг") Console.WriteLine($"{naim} это будний день");
if (naim == "Пятница") Console.WriteLine($"{naim} это будний день");
if (naim == "Суббота") Console.WriteLine($"{naim} это выходной день");
if (naim == "Воскресенье") Console.WriteLine($"{naim} это выходной день");