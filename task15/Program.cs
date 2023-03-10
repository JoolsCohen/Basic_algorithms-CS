// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
//------------------------------------------
// 1 РЕШЕНИЕ (НАИПРОСТЕЙШЕЕ, НО БЕЗ МЕТОДОВ)
// Console.Write("введите номер дня недели: ");
// int day = Convert.ToInt32(Console.ReadLine());
// if (day == 1)
// {
//   Console.Write("Понедельник");
// }
// else if (day == 2)
// {
//   Console.Write("Вторник");
// }
// else if (day == 3)
// {
//   Console.Write("Среда");
// }
// else if (day == 4)
// {
//   Console.Write("Четверг");
// }
// else if (day == 5)
// {
//   Console.Write("Пятница");
// }
// else if (day == 6)
// {
//   Console.Write("Суббота");
// }
// else if (day == 7)
// {
//   Console.Write("Воскресенье");
// }
// else
// {
//   Console.Write("Куда загнули? У нас всего семь дней в неделе!");
// }

// if (day < 6) Console.WriteLine($" - рабочий день! Кышь назад, на галеры!"); 
// if (day > 5 && day < 8) Console.WriteLine($"! Бухаем!"); 
//------------------------------------------
// 2 РЕШЕНИЕ (ЛЕГКОЕ, НО НЕПОЛНОЕ)
// Console.WriteLine("Введите номер дня недели: ");
// int day = int.Parse(Console.ReadLine()!);
// bool isDayOff(int day)
// {
//   return day >= 1 && day <= 5;
// }
// Console.WriteLine(isDayOff(day) ? "Не выходной" : "Выходной");
//------------------------------------------
// 3 РЕШЕНИЕ (ОПТИМАЛЬНОЕ)
Console.Write("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine());
if (num >= 1 && num <= 5)
{
  Console.Write(" Нет, это не выходной");
}
else if (num >= 6 && num <= 7)
{
  Console.Write(" Да, это выходной");
}
else Console.Write(" Не существует такого дня недели");