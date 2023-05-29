// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


int[] GetArr(int m)
{
    int[] a= new int[m];
    for (int i=0; i<a.Length; i++)
    {
        Console.WriteLine ($"Enter {i} element of massive");
        a[i] = int.Parse(Console.ReadLine());

    }
 
    for (int j=0; j<a.Length; j++)
    {
        Console.Write($"{a[j]}, ");
    }
    return a;
}
 
void PositiveNumbers(int[] a)
{
    int sum = 0;
    foreach(int el in a)
    {
        if(el>0)
            sum++;
    }
    Console.WriteLine();
    Console.Write($"Number of Positive elements in massive = {sum} ");

}

Console.Write("Enter number of massive elements: ");
int m = int.Parse(Console.ReadLine());

int[] arr = GetArr(m);
PositiveNumbers(arr);