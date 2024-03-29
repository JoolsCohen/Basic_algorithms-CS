﻿// 19.Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//------------ПЕРВОЕ РАБОЧЕЕ РЕШЕНИЕ (БЕЗ ПРОВЕРКИ НА ОТРИЦАТЕЛЬНОСТЬ ЧИСЕЛ)-------------------------------------------------------------------------

// Console.WriteLine("Введи пять циферок: ");
// string num = Console.ReadLine();

// int size = num.Length;

// Palindrome(num);

// void Palindrome(string number)
// {
//   if (size == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3]) Console.WriteLine($"Да, это {number} - Палиндром");
//     else Console.WriteLine($"Нет, это {number} - не палиндром");
// }
// else Console.WriteLine($"А это {number} что за динозавр? Написано же - ПЯТЬ циферок");    
// }

//------------ВТОРОЕ РАБОЧЕЕ РЕШЕНИЕ (С ПРОВЕРКОЙ НА ОТРИЦАТЕЛЬНОСТЬ ЧИСЕЛ)-------------------------------------------------------------------------
Console.Clear();
Console.WriteLine("Вводим пять циферок: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0) num = num * -1;
if (num < 10000 || num > 100000)
{
  Console.WriteLine($"А это что за динозавр? Написано же - ПЯТЬ циферок");
}
else
{
  Palindrome(num);
  void Palindrome(int number)
  {
    if ((num / 10000 == num % 10) && ((num / 1000) % 10 == (num % 100) / 10)) Console.WriteLine($"Да, это - палиндром");
    else Console.WriteLine($"Нет, это - не палиндром");
  }
}

//(num/10000 == num%10) - сраниваем 1 и 5 цифры
//(num/1000)%10 == (num%100)/10) - сравниваем 2 и 4 цифры