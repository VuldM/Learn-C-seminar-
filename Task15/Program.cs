// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число дня недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());
if (dayWeek < 1 || dayWeek > 7)
{
    Console.WriteLine("Вы вышли за диапазн числового значения дня недели");
}

else
{
bool res = WeekEnd(dayWeek); //булева операция да, нет
Console.WriteLine(res  ? "да" : "нет"); 
}

bool WeekEnd(int num)
{
   return num == 6 || num == 7; 
}
