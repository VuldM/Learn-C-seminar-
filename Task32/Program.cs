// Задача 32
// Напишите программу замена элементов массива:
// положительные элементы замените на соответтстующие, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8,-2]

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

void InverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

int[] array = CreateArrayrndInt(4, -8, 8);
Printarray(array);
InverseArray(array);
Console.Write(" - > [");
Printarray(array);
Console.Write("]");


