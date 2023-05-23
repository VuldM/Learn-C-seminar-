// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите целое положительное число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое положительное число");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNaturalNumber(int numM, int numN)
{
    if (numM < numN) return numM + SumNaturalNumber(numM + 1, numN);
    else if (numM > numN) return numM + SumNaturalNumber(numM - 1, numN);
    return numM;
}
if (numberM < 0 || numberN < 0) Console.WriteLine("Вы ввели не натуральное число");
else if (numberM == numberN) Console.WriteLine("Это тоже самое число");
else Console.Write(SumNaturalNumber(numberM, numberN));