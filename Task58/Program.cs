// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
        Console.WriteLine(" |");
    }
}
bool AgreedMatrix(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) == matrixB.GetLength(0)) return true;
    else return false;
}


int[,] MultiplyMatrix(int[,] arr2dA, int[,] arr2dB)
{

    int[,] arr2dC = new int[arr2dA.GetLength(0), arr2dB.GetLength(1)];
    for (int i = 0; i < arr2dC.GetLength(0); i++)
    {
        for (int j = 0; j < arr2dC.GetLength(1); j++)
        {
            for (int n = 0; n < arr2dB.GetLength(0); n++)
            {
                arr2dC[i, j] = arr2dC[i, j] + arr2dA[i, n] * arr2dB[n, j];
            }
        }
    }
    return arr2dC;

}

int[,] matrixA = FillArray2d(2, 2, 2, 5);
Console.WriteLine("Матрица А: ");
PrintArray2d(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица В: ");
int[,] matrixB = FillArray2d(2, 2, 2, 5);
PrintArray2d(matrixB);
Console.WriteLine();
if (AgreedMatrix(matrixA, matrixB))
{
    int[,] multiplyMatrix = MultiplyMatrix(matrixA, matrixB);
    Console.WriteLine("Результирующая матрица С: ");
    PrintArray2d(multiplyMatrix);
}
else
{
    Console.WriteLine("Матрицы не согласовны, умножение не возможно!");
}
Console.WriteLine();












