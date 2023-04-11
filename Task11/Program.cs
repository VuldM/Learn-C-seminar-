// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100-999 -> {number}");

int DeleteMiddle (int num)
{
int firstDigit = num / 100;
int secondDigit = num % 10;
int newNumber = firstDigit*10+secondDigit ;
return newNumber;
}
Console.WriteLine ("Двузначное число " + DeleteMiddle(number));
//    Это другой вариант 
// int numberB = DeleteMiddle (number);
// Console.WriteLine ($"Двузначное число -> {numberB}");

