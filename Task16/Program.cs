// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine()); // Приглашение ко вводу первого числа
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine()); // Приглашение ко вводу второго числа
bool result = IsSquare (number1,number2); // задаем переменную rezult типа булеан true - false
Console.WriteLine(result ? "да" : "нет"); // означает что в rezult запишется "да"(знак ?) если выражение истинно, или "нет"(знак :) если ложно.


// Созаем метод IsSquare
bool IsSquare (int num1, int num2)
{
    return (num1 == num2 * num2) || (num2 == num1 * num1); //  Возвращает true если одно из выражений истинно, и false если оба ложны
}