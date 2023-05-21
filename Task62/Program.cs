// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] SpiralFillArray2d(int rows, int columns)
{
    int[,] arr2d = new int[rows, columns];
    int count = 0;
    int row = arr2d.GetLength(0);
    int column = arr2d.GetLength(1);
    int n = 0;
    int m = 0;
    int i = 0;
    int j = 0;
    while (arr2d[i, j] < arr2d.Length)
    {
        i = n;
        while (j < column)
        {
            count++;
            if (arr2d[i, j] > arr2d.Length) return arr2d;
            arr2d[i, j] = count;
            j++;
        }
        column--;
        j--;
        i++;
        while (i < row)
        {
            count++;
            if (arr2d[i, j] > arr2d.Length) return arr2d;
            arr2d[i, j] = count;
            i++;
        }
        row--;
        i--;
        j--;
        while (j > m)
        {
            count++;
            if (arr2d[i, j] > arr2d.Length) return arr2d;
            arr2d[i, j] = count;

            j--;
        }
        while (i > m)
        {
            count++;
            if (arr2d[i, j] > arr2d.Length) return arr2d;
            arr2d[i, j] = count;

            i--;
        }
        m++;
        j++;
        n++;
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
            Console.Write($"{arr2d[i, j],3}");
        }
        Console.Write(" |");
        Console.WriteLine();
    }

}
int[,] spiralArray2d = SpiralFillArray2d(4, 4);
PrintArray2d(spiralArray2d);
