// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());

int sumDigit = SumDigit(num);

int SumDigit(int a)
{
  int num = 0;
  while (a > 0)
  {
    num += a % 10;
    a = a / 10;
  }
  return num;
}
Console.WriteLine("сумма всех цифр в числе " + num + " равна: " + sumDigit);