// Напишите программму, которая будет выдавать
//  название дня недели по заданному номеру.
//  3 -> Среда
//  5-> Пятница
Console.WriteLine("Введите число одного до девяти:");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine("Понедельник");
}
else if (number == 2)
{
    Console.WriteLine("Вторник");
}
else if (number == 4)
{
    Console.WriteLine("Четверг");
}
else if (number == 3)
{
    Console.WriteLine("Среда");
}
else if (number == 5)
{
    Console.WriteLine("Пятница");
}
else if (number == 6)
{
    Console.WriteLine("Шестица");
}
else if (number == 7)
{
    Console.WriteLine("Седьмица");
}
else if (number == 8)
{
    Console.WriteLine("Осьмица");
}
else if (number == 9)
{
    Console.WriteLine("Неделя");
}
else
{
    Console.WriteLine("С таким числом дня недели нет");
}

