// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
// Console.Write("введите первое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
int number = new Random().Next(100, 1000);
Console.WriteLine("Получаем рандомное трехзначное число "+number+"");
if (number < 0) number = -number;
int finalResult = ShowSecondDigit(number);
int ShowSecondDigit(int num)
{
  int firstDigit = num / 10;
  int secondDigit = firstDigit % 10;
  int result = secondDigit;
  return result;
}
Console.WriteLine("Вторая цифра этого числа "+finalResult+"");