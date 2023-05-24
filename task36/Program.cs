// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] a = new int[size];
    for (int i = 0; i < size; i++)
    {
        a[i] = new Random().Next(minValue, maxValue+1);
        Console.Write($"{a[i]} ");

    }
    return (a);
}

void OddElSum(int[] arr)
{
    int sum = 0;
    int i = 0;
    foreach(int el in arr)
    {

        if(i%2 == 1)
        {
           sum=sum+el;
        }
        i++;
    }
    Console.Write($"Sum of odd elements = {sum}");
}


int[] array = GetArray(4, -100, 100);
OddElSum(array);