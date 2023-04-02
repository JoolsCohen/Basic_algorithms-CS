﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int n = 4;
int[,] spiralMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
{
  spiralMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(spiralMatrix);

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] / 10 <= 0)
        Console.Write($" {array[i, j]} ");

      else Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}


//------------------------------------------2 решение--------------------
int n = 4;
int[,] array = new int[n, n];

int beginI = 0; // При заполнении массива будем очерчивать прямоугольники, каждый их которых на единицу меньше с каждой стороны.
int finalI = 0; // Нам нужно знать точки начала и конца очерчиваемого прямоугольника. Это и будут точки поворота) 
int beginJ = 0; // Эти 4 точки - это точки поворота. 
int finalJ = 0; // Они равны длине стороны первого прямоугольника минус длина текущего прямоугольника.

int i = 0;
int j = 0;

PrintArray(array);

for (int k = 1; k <= n * n; k++) // Значением k заполняем массив
{
  array[i, j] = k;
  if (i == beginI && j < n - finalJ - 1)
  {
    j++; // Если у нас верхняя сторона прямоугольника и мы не достигли правой стороны, то двигаемся вправо: j++
  }
  else
  {
    if (j == n - finalJ - 1 && i < n - finalI - 1)
    {
      i++; // Если мы на правой стороне прямоугольника и не достигли нижней стороны, то двигаемся вниз: i++
    }
    else
    {
      if (i == n - finalI - 1 && j > beginJ)
      {
        j--; // Если мы на нижней стороне прямоугольника и не достигли левой стороны, то двигаемся влево: j--
      }
      else
      {
        i--; // Иначе двигаемся вверх: i--
      }
      if ((i == beginI + 1) && (j == beginJ) && (beginJ != n - finalJ - 1)) // Проверяем, завершился ли прямоугольник и стоит ли начинать рисовать новый - меньший.
      {
        beginI++; // Увеличиваем отступы от краев первого прямоугольника.
        finalI++;
        beginJ++;
        finalJ++;
      }
    }
  }
}


void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] < 10)
      {
        Console.Write("0" + array[i, j]);
        Console.Write(" ");
      }
      else Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}