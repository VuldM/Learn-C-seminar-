// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
    number = Convert.ToInt32(Console.ReadLine());
}
while (number < 99 || number >  1000)
{
    Console.WriteLine("Работает");
    number = number / 10;
}
    Console.WriteLine(number);
Console.WriteLine($" - > {number % 10}");
