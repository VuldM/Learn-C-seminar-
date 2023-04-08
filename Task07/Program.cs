
// Напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает последнюю цифру этого числа.
//  456 -> 6
//  782 -> 2
//  918 -> 8
Console.WriteLine("Введите первое число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = -number;
}
if (number >= 100 && number <= 999)
{
    Console.WriteLine(number % 10);
}
else
{
    Console.WriteLine("Ваше число не трехзначное");
}