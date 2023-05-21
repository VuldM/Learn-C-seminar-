// Задача 56: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillArray2d(int rows, int colums, int min, int max)
{
    int[,] arr2d = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < arr2d.GetLength(0); i++)
    {
        for (int j = 0; j < arr2d.GetLength(1); j++)
        {
            arr2d[i, j] = rnd.Next(min, max + 1);
        }

    }
    return arr2d;
}
void PrintArray2d(int[,] arr2d)
{
    for (int i = 0; i < arr2d.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr2d.GetLength(1); j++)
        {
            Console.Write($"{arr2d[i, j],2} ");
        }
        Console.WriteLine("|");
    }
}
int[] MinSumElementRows(int[,] arr2d)
{
    int size = arr2d.GetLength(0);
    int[] indexSumMinRows = new int[size];
    for (int i = 0; i < arr2d.GetLength(0); i++)
    {
        int sumMax = 0;
        for (int j = 0; j < arr2d.GetLength(1); j++)
        {
            sumMax = sumMax + arr2d[i, j];
        }
        indexSumMinRows[i] = sumMax;
    }
    return indexSumMinRows;
}

int IndexMin(int[] arr)
{
    int indexMin = 0;
    int min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            indexMin = i;
        }
    }
    return indexMin;
}

int[,] array2d = FillArray2d(4, 4, 1, 9);
PrintArray2d(array2d);
int[] minSumElementRows = MinSumElementRows(array2d);
int indexMin = IndexMin(minSumElementRows);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {indexMin + 1} строка");