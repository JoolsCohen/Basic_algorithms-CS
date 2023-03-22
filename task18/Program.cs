// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).
Console.Clear();
Console.WriteLine("Введите номер четверти");
int quarterNum = Convert.ToInt32(Console.ReadLine());

string quarter = RangeCoord(quarterNum);
Console.WriteLine(quarter);

string RangeCoord (int quarter)
{
if (quarter == 1) return "x > 0, y > 0";
if (quarter == 2) return "x < 0, y > 0";
if (quarter == 3) return "x < 0, y < 0";
if (quarter == 4) return "x > 0, y < 0";
return "Введена некорректно четверть";
}