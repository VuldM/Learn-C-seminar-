// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]



int[] array = new int[8];
int size = array.Length;
int i = 0;
for (i = 0; i == size; i++)
{
    int number = new Random().Next(0, 10);
    array[i] = number;
}
int PrintArray(int val)
{
    for (i = 0; i == size; i++)
    {
        Console.Write($"{array[i]}");
    }
    return v
}

Console.Write($"{array[i]}");
int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
}

Console.WriteLine("Please enter array length: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(size);
PrintArray(arr);