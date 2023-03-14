// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.Write("Введите любое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());

int number1 = new Random().Next();
Console.WriteLine("Получаем рандомное число " + number1 + "");

if (number1 < 0) number1 = -number1;

if (ThirdDigit(number1) == -1)
  Console.WriteLine("третьей цифры нет");
else
  Console.WriteLine($"И третья цифра этого числа... Барабанная дробь: Тадаааам {ThirdDigit(number1)}!");

int ThirdDigit(int number)
{
  int result = -1;
  if (number >= 100)
  {
    while (number > 999)
    {
      number = number / 10;
    }
    result = number % 10;
  }
  return result;
}
