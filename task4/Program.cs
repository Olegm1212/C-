//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("введите число 1: ");
int a = int.Parse(Console.ReadLine());

Console.Write("введите число 2: ");
int b = int.Parse(Console.ReadLine());

Console.Write("введите число 3: ");
int c = int.Parse(Console.ReadLine());

if ((a>b) && (a>c))
{
    Console.WriteLine("max = " + a);
}
else if (c>b)
{
    Console.WriteLine("max = " + c);
    
}
else
{
    Console.WriteLine("max = " + b);
}
