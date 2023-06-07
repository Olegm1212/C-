﻿/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int m = Promt("Enter natural number M: ");
int n = Promt("Enter natural number N: ");

int akk = AkkermanFunction(m, n);
Console.Write($"Resuit is: {akk}");

int Promt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return Math.Abs(a);
}

int AkkermanFunction(int m, int n)
{
    if(m==0)
    return n+1;
    else if(n==0 && m!=0)
    return AkkermanFunction(m-1, 1);
    else
    {
     return AkkermanFunction(m-1, AkkermanFunction(m, n-1));
    }
}
