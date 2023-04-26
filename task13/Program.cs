// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

// 32679 -> 6

Console.Write("введите число: ");
int a = int.Parse(Console.ReadLine());

string GetThirdDigit(int r)
{
    string b = Convert.ToString(r);
    Console.WriteLine($"{b[2]}");
    return b;
}
if (a>=100)
{
    GetThirdDigit(a);
}
else
{
    Console.Write("Третьей цифры нет");
}