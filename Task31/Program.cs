// Задача 31. 
// Задайте массив из промежутка [-9, 9]. Найдите сумму
// отрицмтельных и положительных элементов массива.
// 
// Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
// сумма положительных чисел равна 29, сумма отрицательных равна -20,

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

int SumPositivElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
    }
    return sum;
}

int SumNegativElements(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i];
    }
    return sum;
}

int[] array = CreateArrayrndInt(12, -9, 9);
Console.Write("[");
Printarray(array);
Console.WriteLine("]");
Console.WriteLine();
int sumNegativElements = SumNegativElements(array);
int sumPositivElements = SumPositivElements(array);
System.Console.WriteLine($"Сумма положительных элементов = {sumPositivElements}");
System.Console.WriteLine($"Сумма отицательных элементов = {sumNegativElements}");
Console.WriteLine();
