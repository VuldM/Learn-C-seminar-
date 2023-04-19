// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

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
    for (int i = 0; i < arra.Length-1; i++)
    {
      Console.Write($"{arra[i]}, ");  
         
    }           
     Console.Write($"{arra[i]} ");  
     Console.Write(" -> ["); 
    for (int i = 0; i < arra.Length-1; i++)
    {
       Console.Write($"{arra[i]}, ");  
        
    }
       Console.Write($"{arra[i]}"); 
     Console.WriteLine($"]"); 
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);