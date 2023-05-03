// Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125



int n = Promt("Введите число: ");
 if (n==0)
    Console.Write("0");
else
CalcCube(n);

int Promt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return Math.Abs(a);
}

void CalcCube(int n)
{
    int i = 1;
    int cube;
    while(i<=n)
{
        Console.WriteLine (cube = i*i*i);
        i++;
}
}