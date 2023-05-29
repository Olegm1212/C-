// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int inputData(string message)
{
    Console.WriteLine(message);
    int n = int.Parse(Console.ReadLine());

    return n;
}

void FindPoint(double k1, double k2, double b1, double b2)
{
    double x = (b2-b1)/(k1-k2);
    double y = k1 * x + b1;
    Console.Write($"{x}, {y}");
}

double b1 = inputData("Enter b1");
double k1 = inputData("Enter k1");
double b2 = inputData("Enter b2");
double k2 = inputData("Enter k2");


FindPoint(k1, k2, b1, b2);
