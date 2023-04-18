// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое положительное число");
int number = Convert.ToInt32(Console.ReadLine());
int proNumber = ProNumber(number);
int ProNumber(int num)
{
    int pro = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            pro *= i;
        }
    }
    return pro;
}
Console.WriteLine($"произведение чисел от 1 до {number} = {proNumber}.");