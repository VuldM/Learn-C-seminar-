// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double round = Math.Round(arr[i], 1);
        if (i < arr.Length - 1) Console.Write($"{round}, ");
        else Console.Write($"{round}");
    }
}
double MaxNumber(double[] arr)
{
    double max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}
double MinNumber(double[] arr)
{
    double min = MaxNumber(arr);
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}
double DifferenceNumbers(double max, double min)
{
    double diff = max - min;
    return diff;
}

double[] array = CreateArrayRndInt(5, 1, 99);
// double maxNumber = Math.Round(MaxNumber(array), 1);
// double minNumber = Math.Round(MinNumber(array), 1);
// double diffNumber = Math.Round(MaxNumber(array), 1) - Math.Round(MinNumber(array), 1);
double differenceNumber = DifferenceNumbers(MaxNumber(array), MinNumber(array));
Console.Write("[");
PrintArray(array);
Console.Write("] -> ");
differenceNumber = Math.Round(differenceNumber, 1);
Console.WriteLine(differenceNumber);
//Console.Write($"  / {maxNumber}, {minNumber} разность {diffNumber}");

