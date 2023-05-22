// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 4, 76, 3 -> [1, 2, 5, 7, 19,4,76,3]
//6, 1, 33, 43, 12, 3 ,2, 9 -> [6, 1, 33,43,12,3,2,9]

void PrintArr(int n)
{
    int[] a= new int[n];
    for (int i=0; i<a.Length; i++)
    {
        Console.WriteLine ($"Enter {i} element of massive");
        a[i] = int.Parse(Console.ReadLine());

    }
 
    for (int j=0; j<a.Length; j++)
    {
        Console.Write($"{a[j]}, ");
    }

}

int lengthArr=8;
PrintArr(lengthArr);