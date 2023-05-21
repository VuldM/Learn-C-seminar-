// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] FillArray2d(int rows, int columns, int min, int max)
{
    int[,] arr2d = new int[rows, columns];
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
            Console.Write($"{arr2d[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}
void SortRowsArray2d(int[,] arr2d)
{
    for (int i = 0; i < arr2d.GetLength(0); i++)
    {
        for (int j = 0; j < arr2d.GetLength(1); j++)
        {

            for (int k = 0; k < arr2d.GetLength(1) - 1; k++)
            {
                if (arr2d[i, k] < arr2d[i, k + 1])
                {
                    int temp = arr2d[i, k];
                    arr2d[i, k] = arr2d[i, k + 1];
                    arr2d[i, k + 1] = temp;
                }
            }

        }
    }
}

int[,] array2d = FillArray2d(3, 4, 1, 9);
PrintArray2d(array2d);
SortRowsArray2d(array2d);
Console.WriteLine();
PrintArray2d(array2d);
