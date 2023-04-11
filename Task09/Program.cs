// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

//             Обычный код
// int number = new Random().Next(10, 100);// 99 + 1
// Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");
// int firstDigit = number / 10;
// int secondDigit = number  % 10;

// if(firstDigit > secondDigit)
// {
// Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// }
// else
// {
//   Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");  
// }

// int maxDigit = firstDigit>secondDigit ? firstDigit : secondDigit;

//  Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int number = new Random().Next(10, 100);   //  Генератор случайого числа от 10 до 99
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}"); // Вывод этого числв терминал
int maxDigit = MaxDigit(number); // Присваивание значения метода(функции) MaxDigit переменной maxDigit
 Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}"); // ВЫвод значения в теримнал

//            С использование Методов(функций)
 int MaxDigit (int num) // метод MaxDigit возвращает наибольшую цифру в числе 
{ // тело метода
int firstDigit = num / 10;
int secondDigit = num  % 10;
int maxDigit = firstDigit>secondDigit ? firstDigit : secondDigit;
return maxDigit;
 } // тело метода
