/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
1 строка
*/

Console.Write("Enter number of rows: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter number of columns: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
MinSumRow(array);

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

void MinSumRow(int[,] array)
{
    int rowMin=0;
    for (int i = 0; i < array.GetLength(0)-1; i++)
    {
        int sum0=0;
        int sum1=0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum0=sum0+array[i,j];
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum1=sum1+array[i+1,j];
        }
        if(sum1 < sum0)
        rowMin=i+1;
        else
        rowMin=i;
    }
    Console.WriteLine($"Minimal sum in row: {rowMin}");
}