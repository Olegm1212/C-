/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.Write("Enter number of rows: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Enter number of columns: ");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Array1");
int[,] array1 = GetArray(rows, columns, 0, 10);
PrintArray(array1);

Console.WriteLine($"Array2");
int[,] array2 = GetArray(rows, columns, 0, 10);
PrintArray(array2);

Console.WriteLine("Result of multiplication is:");
MultpleMassives(array1, array2);

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

void MultpleMassives(int[,] arr1, int[,] arr2)
{
    int[,] resArr = new int[arr1.GetLength(0), arr1.GetLength(1)];
    int mult;
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            mult=arr1[i,j]*arr2[i,j];
            resArr[i,j]=mult;
            Console.Write($"{resArr[i,j]} ");
        }
        Console.WriteLine();
    }
    //Console.WriteLine($"Minimal sum in row: {resArr}");
}