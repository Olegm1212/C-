/*Задайте значения M и N. Напишите программу, которая выведет все
натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"*/

int m = Promt("Enter natural number M: ");
int n = Promt("Enter natural number N bigger than M: ");

if(m>=n)
Console.WriteLine("Enter number N bigger than M: ");
else
NaturalNumbers(m, n);

int Promt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return Math.Abs(a);
}

void NaturalNumbers(int m, int n)
{
    Console.Write($"{n-m}, ");
    if(n-m==1)
    return;
    n = n - 1;
    NaturalNumbers(m, n);
}