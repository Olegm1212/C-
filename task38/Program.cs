// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76



double[] GetArray(int size)
{
    double[] a = new double[size];
    for (int i = 0; i < size; i++)
    {
        a[i] = new Random().NextDouble();
        Console.Write($"{a[i]} ");
    }
    return (a);
}

void DifferenceMaxMin(double[] arr)
{
    int i = 0;
    double max = arr[i], min = arr[i+1];
    foreach(double el in arr)
    {

        if(el < min)
        {
            min = el;
        }
        else if(el > max)
        {
            max = el;
        }
    }
    Console.WriteLine();
    Console.Write($" Difference between Max and Min = {max-min}");
}


double[] array = GetArray(4);
DifferenceMaxMin(array);