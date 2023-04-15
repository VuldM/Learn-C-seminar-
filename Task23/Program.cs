// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void TabSquare(int num)
{
    int count = 1;
    while (count <= num)
    {       
        int  count3 = (int)Math.Pow(count, 3);  // преобразовывает double  в int.  int  count3 = Convert.ToInt32(Math.Pow(count, 3))- преобразовывает string в int
        Console.WriteLine($" {count, 3} {count3, 3}");
        count++;
    }    
}
Console.WriteLine("Введите число");
int digit = Convert.ToInt32(Console.ReadLine());
TabSquare(digit);