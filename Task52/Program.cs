// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //matrix.GetLength(0) = 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) = 4
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine(" |");
    }
}

double[] ColumnAverageVal(int[,] arr2d)
{
    double[] arrAverageNum = new double[arr2d.GetLength(1)];

    for (int j = 0; j < arr2d.GetLength(1); j++)
    {

        double sumColumn = 0;
        for (int i = 0; i < arr2d.GetLength(0); i++)
        {
            sumColumn = sumColumn + arr2d[i, j];
        }

        arrAverageNum[j] = sumColumn / arr2d.GetLength(0);

    }

    return arrAverageNum;
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double round = Math.Round(arr[i], 1);
        if (i < arr.Length - 1) Console.Write($"{round}; ");
        else Console.Write($"{round}");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
double[] columnAverageVal = ColumnAverageVal(array2d);

Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(columnAverageVal);