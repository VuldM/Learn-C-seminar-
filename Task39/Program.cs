// Задача 39: Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
int[] CreateArray(int sze)//  Если массив создается в методе то его надо вернуть оператором ретурн
{
    int[] arr = new int[sze];
    Random rnd = new Random(); //var rnd = new Random()ж или так
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}

void PrintArray(int[] arra) // Если в методе ничего не создается, то можно использовать войд метод
{
    int i = 0;
    for (i = 0; i < arra.Length - 1; i++)
    {
        Console.Write($"{arra[i]}, ");

    }
    Console.Write($"{arra[i]} ");
    Console.Write(" -> [");
    for (i = 0; i < arra.Length - 1; i++)
    {
        Console.Write($"{arra[i]}, ");

    }
    Console.Write($"{arra[i]}");
    Console.WriteLine($"]");
}

void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1];
        arr[arr.Length - 1 - i] = temp;

    }
}


Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
ReverseArray(array);
PrintArray(array);