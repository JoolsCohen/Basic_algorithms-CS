// Решение в группах задач: 20 мин
// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
Console.Clear();
Console.Write("введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
  int numLast = num % 10;
  Console.WriteLine(numLast);
}
else
{
  Console.WriteLine("введите ТРЁХзначное число");
}
