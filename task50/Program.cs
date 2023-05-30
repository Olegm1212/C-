// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//[1,7] -> такого числа в массиве нет

Console.Write("Enter position in the row: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter position in the column: ");
int column = int.Parse(Console.ReadLine()!);


int rows = 3;
int columns = 4;

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
ElementPosition(array, row, column);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
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

void ElementPosition(int[,] arr, int r, int c)
{
    if(r < arr.GetLength(0) && c < arr.GetLength(1))
    {
        Console.Write($"Element on position [{r}, {c}] is: {arr[r, c]}");
    }
    else
    {
        Console.Write($"[{r}, {c}] -> There is no element with such position");
    }

}
