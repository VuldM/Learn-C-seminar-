// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите число: ");
int number0 = Convert.ToInt32(Console.ReadLine()); // приглашение ко вводу проверочного числа

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine()); // приглашение ко вводу первого кратного
Console.Write("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine()); // приглашение ко вводу второго кратного

bool result = MultipleTwoDigits(number0, number1, number2); //булева операция да, нет
Console.WriteLine(result ? "да" : "нет"); // означает что в rezult запишется "да"(знак ?) если выражение истинно, или "нет"(знак :) если ложно.

// Создание метода MultipleTwoDigits с тремя значениями
bool MultipleTwoDigits(int num0, int num1, int num2)
{
   return num0 % num1==0 && num0 % num2==0; // означает: возвратить "да" если оба выражения верны и "нет" если хотябы одно или оба не верны.
}// && логичесое И
