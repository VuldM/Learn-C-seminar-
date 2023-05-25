// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите первое целое положительное число m");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое положительное число n");
int numberN = Convert.ToInt32(Console.ReadLine());

int AskFunction(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return AskFunction(n - 1, 1);
    return AskFunction(n - 1, AskFunction(n, m - 1));

}


if (numberM < 0 || numberN < 0) Console.WriteLine("Вы ввели не натуральное число");
else
{
    Console.Write($"m = {numberM}, n = {numberN} -> A({numberM}, {numberN}) = ");
    Console.Write(AskFunction(numberM, numberN));
}