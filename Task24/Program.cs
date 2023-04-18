// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите целое положительное чиислоЖ ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = SumNumber(number);
int SumNumber(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        checked
        {
            sum += i;
        }
    }
    return sum;
}
Console.WriteLine($"сумму чисел от 1 до {number} = {sumNumber}.");


// Console.WriteLine("Введите целое положительное число:");
// long number = Convert.ToInt64(Console.ReadLine());

// long sumNumbers = SumNumbers(number);
// Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");

// long SumNumbers(long num) // int num = number
// {
//     long sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         checked
//         {
//             sum += i; // sum = sum + i;
//         }
//     }
//     return sum;
// }