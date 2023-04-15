// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

void TableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count,3}  {count * count,4}");
        count += 1;
    }
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
TableSquare(number);
