// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]



// int[] array = new int[8];
// int size = array.Length;
// int i = 0;
// for (i = 0; i == size; i++)
// {
//     int number = new Random().Next(0, 10);
//     array[i] = number;
// }
// int PrintArray(int val)
// {
//     for (i = 0; i == size; i++)
//     {
//         Console.Write($"{array[i]}");
//     }
//     return v
// }

// Console.Write($"{array[i]}");
int[] CreateArray(int sze)//  Если массив создается в методе то его надо вернуть оператором ретурн
{
    int[] arr = new int[sze];
    Random rnd = new Random(); //var rnd = new Random()ж или так
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 2);
    }
    return arr;
}

void PrintArray(int[] arra) // Если в методе ничего не создается, то можно использовать войд метод
{
    for (int i = 0; i < arra.Length; i++)
    {
        Console.Write($"{arra[i]} ");
    }
}

Console.WriteLine("Please enter array length: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);