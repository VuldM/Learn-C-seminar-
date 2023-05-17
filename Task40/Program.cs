// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите длину стороны АВ: ");
int numberAB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны ВС: ");
int numberBC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину стороны СА: ");
int numberCA = Convert.ToInt32(Console.ReadLine());

bool triangleSearch = TriangleSearch(numberAB, numberBC, numberCA);
Console.WriteLine(triangleSearch ? "такой треугольник существует" : "такой треугольник не существует");

bool TriangleSearch(int num1, int num2, int num3)
{
    return num1 + num2 > num3 && num2 + num3 > num1 && num1 + num3 > num2;
}

Console.Write("Нажмите любую клавишу для завершения...");
Console.ReadKey(true);