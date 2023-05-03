//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


int[] inputData(string message, string point)
{
    Console.WriteLine(message + point + "X: ");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine(message + point + "Y: ");
    int y = int.Parse(Console.ReadLine());
    Console.WriteLine(message + point + "Z: ");
    int z = int.Parse(Console.ReadLine());

    return new int[3]{x, y, z};
}

double FindLength(int[] pointA, int [] pointB)
{
    return Math.Sqrt(Math.Pow(pointA[0]-pointB[0], 2) + Math.Pow(pointA[1]-pointB[1], 2) + Math.Pow(pointA[2]-pointB[2], 2));
}

int[] pointA = inputData("Введите координаты точки", "A");
int[] pointB = inputData("Введите координаты точки", "B");

double len = FindLength(pointA, pointB);
Console.Write(len);
