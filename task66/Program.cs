/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int m = Promt("Enter natural number M: ");
int n = Promt("Enter natural number N bigger than M: ");

if(m>=n)
Console.WriteLine("Enter number N bigger than M: ");
else
{
int s = 0;
int sum = NaturalNumbers(m, n);
Console.Write($"Sum of numbers between {m} and {n} is: {sum}");
}

int Promt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return Math.Abs(a);
}

int NaturalNumbers(int m, int n)
{
    if(n<m)
    return 0;
    else
    {
     return n + NaturalNumbers(m, n-1);
    }
}
