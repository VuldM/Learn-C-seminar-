// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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
int PositionElemet(int numRows, int numColums, int[,] arr2d)
{
    return arr2d[numRows, numColums];
}
bool CheckindBorders(int numRows, int numColums, int[,] arr2d)
{
    if (numRows >= arr2d.GetLength(0)
            || numColums >= arr2d.GetLength(1)
                      || numRows < 0
                          || numColums < 0) return false;

    return true;

}

int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
Console.WriteLine("Введите номер строки: ");
int numberRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int numberColums = Convert.ToInt32(Console.ReadLine());
bool checkindBorders = CheckindBorders(numberRows, numberColums, array2d);
if (checkindBorders == true)
{
    int positionElemet = PositionElemet(numberRows, numberColums, array2d);
    Console.WriteLine($"{numberRows}, {numberColums} -> {positionElemet}");

}
else
{
    Console.WriteLine($"{numberRows}, {numberColums} -> Такого элемента в массиве нет");
}