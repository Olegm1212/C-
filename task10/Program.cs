//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int GetThreeDigitNumber()
{
    int rand = new Random().Next(100, 1000);
    Console.WriteLine(rand);
    return rand;
}

string GetSecondDigit(int r)
{
    string b = Convert.ToString(r);
    Console.WriteLine($"{b[1]}");
    return b;
}

int rand = GetThreeDigitNumber();

GetSecondDigit(rand);