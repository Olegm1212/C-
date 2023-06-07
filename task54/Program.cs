﻿/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.Write("Enter number of rows: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter number of columns: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine("Result of Reverse Ordering");
ReverseOrdering(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ReverseOrdering(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)    
        {
            int temp;
            {
                for (int k = j+1; k < arr.GetLength(1); k++)
                {
                    if(arr[i, k]>arr[i,j])
                    {
                        temp = arr[i, j];
                        arr[i,j]=arr[i,k];
                        arr[i,k] = temp;
                    }
                }
            }
        Console.Write(arr[i,j]+" ");
        }
    Console.WriteLine();
    }
}