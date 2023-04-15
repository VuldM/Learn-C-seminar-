// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Diagonal (int xA, int yA, int zA, int xB, int yB, int zB)
{
    int delX = xB - xA;
    int delY = yB - yA;
    int delZ = zB - zA;
    double diag = Math.Sqrt(Math.Pow(delX, 2) + Math.Pow(delY, 2) + Math.Pow(delZ, 2));
    return diag;
}

Console.WriteLine("Введите координаты точки А");
Console.Write("X: ");
int xACoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yACoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zACoordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки В");
Console.Write("X: ");
int xBCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yBCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zBCoordinate = Convert.ToInt32(Console.ReadLine());
 
double diagonal = Diagonal(xACoordinate, yACoordinate, zACoordinate, xBCoordinate, yBCoordinate, zBCoordinate);
double diagonalRound = Math.Round(diagonal, 2, MidpointRounding.ToZero);

Console.WriteLine(diagonalRound);
