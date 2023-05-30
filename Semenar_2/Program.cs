
/*
Random rand = new Random(); // Число выбирается рондобно
int randNambers = rand.Next(10, 100); // 10 - 99
int a = randNambers % 10;
int b = randNambers / 10;

if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}
*/
/*
void genHambers(int[] arr) // Функция которая генирирует цифру в нутри масива
{
    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(10, 100);
    }
}

int[] arr = new int[10];

genHambers(arr);

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
    int a = arr[i] % 10;
    int b = arr[i] / 10;
    if (a > b)
    {
    Console.WriteLine($"Наибольшая цыфра числа {arr[i]} = " + a);
    }
    else
    {
    Console.WriteLine($"Наибольшая цыфра числа {arr[i]} = " + b);
    }
}
*/

/*
Random rand = new Random();
int randNambers =rand.Next(100, 1000);
Console.WriteLine(randNambers);

int a = randNambers / 100;
int b = randNambers % 10;

int pol = 10 * a + b;

Console.Write(pol);
*/

/*
Console.Write("Видите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Видите второе число: ");
int b = int.Parse(Console.ReadLine());

if (b % a == 0)
{
    Console.WriteLine("Кратное");
}
else
{
    Console.WriteLine(b % a);
}
*/
