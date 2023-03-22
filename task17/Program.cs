﻿// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка
Console.Clear();
Console.WriteLine("Введите координаты точки");
Console.Write("x:");
int xC = Convert.ToInt32(Console.ReadLine());
Console.Write("y:");
int yC = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xC, yC);
string result = quarter > 0 
              ? $"Указ координаты равны четверти -> {quarter}" 
              :"Иначе все введены некорект. координаты";
Console.WriteLine(result);

int Quarter(int x, int y)
{
  if(x > 0 && y > 0) return 1;
  if(x < 0 && y > 0) return 2;
  if(x < 0 && y < 0) return 3;
  if(x > 0 && y < 0) return 4;
  return 0;
}