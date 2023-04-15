// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите введите номер четверти");
int number = Convert.ToInt32(Console.ReadLine());


string range = Range(number);

Console.WriteLine(range == null ? "Не корректный ввод" : range);

string Range(int num)
{
    if (num == 1) return "x больше 0, y меньше 0";
    if (num == 2) return "x меньше 0, y больше 0";
    if (num == 3) return "x меньше 0, y меньше 0";
    if (num == 4) return "x больше 0, y меншье 0";
    return null;
}

// double d = Math.Round(Math.Sqrt(5), 2);
// double d = Math.Sqrt(5);

// double d1 = 5.09987654;
// double d1Round = Math.Round(d1, 2, MidpointRounding.ToZero);
// Console.WriteLine(d1Round);