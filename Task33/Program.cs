// Задача 33.
// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int[] CreateArrayrndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void Printarray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

bool ExistsNumber(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }

    return false;
}

int[] array = CreateArrayrndInt(5, 1, 9);
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("[");
Printarray(array);
Console.WriteLine("]");
bool existsNumber = ExistsNumber(array, number);
Console.WriteLine(existsNumber ? "да" : "нет");