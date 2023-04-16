// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да
bool Palindrome(int num)
{
        int num5 = num % 10;
        int num1 = num / 10000;
        int num4 = num / 10 % 10;
        int num2 = num / 1000 %10;
     // Console.WriteLine($"{num1}, {num2}, {num4}, {num5}");
     return num1 == num5 && num2 == num4;
}


 Console.WriteLine("Введите пятизначное число");
 int number = Convert.ToInt32(Console.ReadLine());
 
 if(number / 10000 > 0 && number / 10000 < 10)
  {     
     bool Rez = Palindrome(number);
Console.WriteLine(Rez ? "Да" : "Нет");
  }
  else
  {

 Console.WriteLine("Ваше число не пятизначное");
  }
   //Console.WriteLine($"{number/10000} {number/10000}");


