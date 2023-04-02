﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Clear();
Console.WriteLine("Вводим кол-во строчек:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим кол-во столбиков:");
int n = Convert.ToInt32(Console.ReadLine());
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

int[,] ChangeOrderElementsRows(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int k = j + 1; k < matrix.GetLength(1); k++)
      {
        if (matrix[i, k] > matrix[i, j])
        {
          int temp = matrix[i, k];
          matrix[i, k] = matrix[i, j];
          matrix[i, j] = temp;
        }
      }
    }
  }
  return matrix;
}

int[,] array2D = CreateMatrixRndInt(m, n, 0, 10);

PrintMatrix(array2D);

Console.WriteLine();

int[,] changeArray2D = ChangeOrderElementsRows(array2D);

PrintMatrix(changeArray2D);