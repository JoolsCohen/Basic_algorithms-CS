﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
  int[,] matrix = new int[rows, columns];
  Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)   //rows
  {
    for (int j = 0; j < matrix.GetLength(1); j++)  //columns
    {
      matrix[i, j] = rnd.Next(min, max + 1);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j],3} ");
    }
    Console.WriteLine("|");
  }
}
double[] FindColumnsElementsAverage(int[,] matrix)
{
  double[] newarray = new double[matrix.GetLength(1)];
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
      sum += matrix[i, j];
    newarray[j] = Math.Round((sum / matrix.GetLength(0)), 1);
  }
  return newarray;
}

void PrintArray(double[] arr)
{
  Console.Write("Среднее арифметическое каждого столбца: ");
  for (int i = 0; i < arr.Length; i++)
  {
    if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
    else Console.Write($"{arr[i]}");
  }
  Console.Write(".");
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

double[] findColumnsElementsAverage = FindColumnsElementsAverage(array2d);

Console.WriteLine();
PrintArray(findColumnsElementsAverage);