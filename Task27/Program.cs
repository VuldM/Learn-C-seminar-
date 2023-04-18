// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int summa = SumDigit(number);
Console.WriteLine($"{number} -> {summa}");

int SumDigit(int num)
{   
    int rezult = 0;

   while(num != 0)// условие окончания цикла
   {      
    rezult = rezult + num % 10;
    num = num / 10; 
   
   }
   return rezult;
}