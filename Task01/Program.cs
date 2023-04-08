// Напишите программу, которая на вход принимает два 
// числа и проверяет, является ли первое число квадатом втогого.
// a = 25, b = 5 -> yes
// a = 2, b = 10 -> no
// a = 9, b = -> -3 yes 
// a = -3, b = 9 - > no
Console.WriteLine("Введите целое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB * numberB)
{
    console.WriteLine("yes");
}
else
{
    Console.WriteLine("No");
}
