//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


int Prompt(string message)
{
   Console.Write(message);
   string value = Console.ReadLine();
   int number = Convert.ToInt32(value);
   return number;
}

void RaiseToPower()
{

    int a = Prompt ("Enter number: ");
    int b = Prompt ("Enter number: ");
    if (a<0 || b<0)
    {
          Console.Write("Ennter 0 or positive numbers");   
    }
    int[] arr = {a, b};
    int power=1;
    int j=arr[1];
  
    
    
        for(int i = 1; i < j; i++)
        {
            power=power*arr[0];
        }
        Console.WriteLine ($"{a} raise to the power of {b} = {power}");
}



//int a = Prompt ("Enter number");
//int b = Prompt ("Enter number");
//int[] a1 = {a, b};
//a1 = new int [2] {a, b};
RaiseToPower();