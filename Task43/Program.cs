// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("B1: ");
int numberB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("K1: ");
int numberK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("B2: ");
int numberB2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("K2: ");
int numberK2 = Convert.ToInt32(Console.ReadLine());

double PointX(double b1, double k1, double b2, double k2)
{
  
    double x = (b2 - b1) / (k1 - k2);

 //   Console.WriteLine($"X: {x} ");
// k1*x + b1 - y = k2 + x + b2 - y; k1*x - k2*x + b1 - y = b2 - y; k1*x - k2*x + b1 = b2 - y + y; k1*x - k2 * x = b2 - y + y - b1; k1*x - k2*x = b2 - b1
//x = b2 - b1 / k 1 - k 2
return x;
}
 
double PointY(double b1, double k1, double b2, double k2)
{
      double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
// k1*x + b1 - y = k2 + x + b2 - y; k1*x - k2*x + b1 - y = b2 - y; k1*x - k2*x + b1 = b2 - y + y; k1*x - k2 * x = b2 - y + y - b1; k1*x - k2*x = b2 - b1
//x = b2 - b1 / k 1 - k 2
return y;
}
double x = PointX(numberB1, numberK1, numberB2, numberK2);
double y = PointY(numberB1, numberK1, numberB2, numberK2);
Console.WriteLine($"b1 = {numberB1}, k1 = {numberK1}, b2 = {numberB2}, k2 = {numberK2} -> ({x}; {y})");
Console.Write("Press any key to continue...");
Console.ReadKey(true);