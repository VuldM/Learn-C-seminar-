// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите свое число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1)
{
    Console.WriteLine("Введите пожалуйста натуральное число:");
    number = Convert.ToInt32(Console.ReadLine());
}
int count = number;

while (count > 1)
{
    Console.Write(count + " ");
    count -= 2;
}
