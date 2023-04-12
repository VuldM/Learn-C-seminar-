// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 100 || number > 999)
{
    Console.WriteLine("Введите пожалуйста трехзначное число:");
    number = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine ("Второе число " + MiddleDigit(number));

int MiddleDigit (int num)
{
int Digit3 = num / 10;
return Digit3 % 10;
}