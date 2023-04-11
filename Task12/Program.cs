// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
//                Это мой вариант без метода: ->
// Console.WriteLine("Введите первое число:");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int numberB = Convert.ToInt32(Console.ReadLine());
// int sum = numberA % numberB;
// if (sum1 > 0) Console.WriteLine($"Ваше число не кратно, остаток {sum}");
// if (sum1 == 0) Console.WriteLine("число ктратно");

// Вариант с использованием Метода
Console.WriteLine("Введите первое число:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numberB = Convert.ToInt32(Console.ReadLine());
int rezult = Rem(numberA, numberB);
string res = (rezult == 0) ? "кратно" : $"не кратно, остаток {rezult}"; 
// это  означает: если rezult равен нулю, то(знак - ?) кратно, ести нет (знак - :) не кратно, остаток {rezult}  и это записывается в переменную res
Console.Write(res);

// Метод 
int Rem(int num1, int num2)
{
    return num1 % num2;
}
