﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine($"Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNums(number);

void NaturalNums(int num)
{
  if (num == 1)
  {
    Console.Write($"{num}");
    return;
  }

  bool NegNumChecking(int num)
{
  return (num < 0);
}
if (NegNumChecking(num))
{
  Console.WriteLine("Вы ввели отрицательные числа!");
  return;
}
  Console.Write($"{num}, ");
  NaturalNums(num - 1);
}