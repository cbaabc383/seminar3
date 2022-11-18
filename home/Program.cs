// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

/*
void Palindrome (int num)
{
    int first = num % 10;
    int second = num / 10 % 10;
    int fourth = num / 1000 % 10;
    int fifth = num / 10000;

    //Console.WriteLine ($"first = {first}");
    //Console.WriteLine ($"second = {second}");
    //Console.WriteLine ($"fourth = {fourth}");
    //Console.WriteLine ($"fifth = {fifth}");


    if (first == fifth && second == fourth)
        Console.WriteLine ($"Number {num} is PALINDROME");
    else
        Console.WriteLine ($"Number {num} is NOT palindrome");
    }
Console.WriteLine ("Input your number:");
int UserNum = Convert.ToInt32 (Console.ReadLine());

if (UserNum > 9999 && UserNum < 100000)
    Palindrome (UserNum);
else
    Console.Write ("Input is not correct");
*/



/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
double LongLine(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int x = x2 - x1;
    int y = y2 - y1;
    int z = z2 - z1;

    double lenghtAB = Math.Round(Math.Sqrt(x * x + y * y + z * z), 3);
    return lenghtAB;
}
Console.WriteLine("Input X coordinat of A:");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinat of A:");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z coordinat of A:");
int zA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input X coordinat of B:");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Y coordinat of B:");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input Z coordinat of B:");
int zB = Convert.ToInt32(Console.ReadLine());

double dist = LongLine(xA, yA, zA, xB, yB, zB);
Console.WriteLine ($"Distance AB is: {dist:f2}");
*/



//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void Cube (int num)
{
    int current = 1;
    while (current <= num)
    {
        int res = current * current * current;
        Console.Write ($"{res}, ");
        current ++;
    }
Console.WriteLine ($"\b\b.");
}
Console.WriteLine ("Input number:");
int number = Convert.ToInt32 (Console.ReadLine());

if (number >=1)
{

    Console.Write($"{number} -> ");
    Cube (number);
}
else Console.WriteLine ("Impossible number");