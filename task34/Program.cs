// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2



int[] GetArray(int size, int minValue, int maxValue)
{
    int[] a = new int[size];
    for (int i = 0; i < size; i++)
    {
        a[i] = new Random().Next(minValue, maxValue+1);
        Console.Write($"{a[i]} ");

    }
    return a;
}

void EvenNum(int[] arr)
{
    int num=0;
    foreach(int el in arr)
    {
        if(el%2==0)
        {
            num++;
        }
    }
    Console.Write($"Number of even numbers = {num}");
}


int[] array = GetArray(4, 100, 999);
EvenNum(array);
