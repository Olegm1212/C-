// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return Math.Abs(a);
}

void DigitsSum(int n)
{
    int digsum=0, i;
    for (i=n; i>0; i=i/10)
    {
        digsum=digsum+i%10;
    }
    Console.WriteLine (digsum);
}

int n = Prompt("Введите число: ");
DigitsSum(n);