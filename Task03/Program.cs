// Напишите программму, которая будет выдавать
//  название дня недели по заданному номеру.
//  3 -> Среда
//  5-> Пятница
Console.WriteLine("Введите число одного до девяти:");
int number = Convert.ToInt32(Console.ReadLine());
if (number== 1) {
    Console.WriteLine("Понедельник");
}
if (number== 2) {
    Console.WriteLine("Вторник");
}
if (number== 4) {
    Console.WriteLine("Четверг");
}
if (number== 3) {
    Console.WriteLine("Среда");
}
if (number== 5) {
    Console.WriteLine("Пятница");
}
if (number== 6) {
    Console.WriteLine("Шестица");
}
if (number== 7) {
    Console.WriteLine("Седьмица");
}
if (number== 8) {
    Console.WriteLine("Осьмица");
}
if (number== 9) {
    Console.WriteLine("Неделя");
}
if ((number > 9)|(number < 1)) {
    Console.WriteLine("С таким числом дня недели нет");
}
