// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива: ");
int numberM = Convert.ToInt32(Console.ReadLine());

int[] InputNumbers(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите {i + 1} число.");
        arr[i] = Convert.ToInt32(Console.ReadLine());

    }

    return arr;
}
int SumPositive(int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum = sum + 1;
    }
    return sum;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
}

int[] inputNumbers = InputNumbers(numberM);
PrintArray(inputNumbers);
int summa = SumPositive(inputNumbers);
Console.WriteLine($" -> {summa}");
Console.Write("Нажмите любую клавишу для завершения...");
Console.ReadKey(true);
