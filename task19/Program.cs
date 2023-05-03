//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


int GetFiveDigitNumber()
{
    Console.Write("Please, enter a 5 digit number: ");
    int rand = int.Parse(Console.ReadLine());
    return rand;
    
}


void CheckPalindrom(int r)
{
int n, i;
int sum = 0;
for ( i = r; i > 0 ; i = i/10 )
{
    n = i%10;
    sum = sum*10 + n;
}
if (r == sum)
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}
}


int rand = GetFiveDigitNumber();
if (rand < 9999 || rand > 100000)
    {
         Console.Write("It is not a 5 digit number" + rand);
    }
else
    {
        CheckPalindrom(rand);   
    }






