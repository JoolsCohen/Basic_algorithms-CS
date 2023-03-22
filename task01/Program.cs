// 1. Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
Console.Clear();
Console.Write("введите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

if(numA == numB * numB)
{
  Console.WriteLine("Да");
}
else
{
  Console.WriteLine("Нет");
}