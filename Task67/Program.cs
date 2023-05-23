// int FactorialRec(int n)
// {
//     if (n == 1) return 1;
//     return n * FactorialRec(n - 1);
// }

// Console.WriteLine(FactorialRec(10)); // 3628800

// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNumbers(number));

int SumNumbers(int n)
{
    if (n == 0) return 0;
    return n % 10 + SumNumbers(n / 10);
}   // return num == 0 ? 0 : num % 10 + SumDigits(num / 10);