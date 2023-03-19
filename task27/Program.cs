// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());

int sumDigit = SumDigit(num);

int SumDigit(int a)
{
  int sum = 0;
  while (a > 0)
  {
    int num = a % 10;
    a = a / 10;
    sum = sum + num;
  }
  return sum;
}
Console.WriteLine("сумма всех цифр в числе" + num + " равна: " + sumDigit);