// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число для возведения в степень");
Console.Write("A: ");
int multiplier = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень числа в которую надо его возвести");
Console.Write("B: ");
int degree = Convert.ToInt32(Console.ReadLine());

if (degree > 0)
{
    int rezult = DegreeNumber(multiplier, degree);
Console.Write($"{multiplier}, {degree} -> {rezult}");
}
else
{
    Console.WriteLine("Число В не является натуральным");
}

int DegreeNumber(int numA, int numB)
{     
    int num = numA;
    for (int i = 1; i < numB; i++)
    {
          num = num * numA;
    }
    return num;
}
