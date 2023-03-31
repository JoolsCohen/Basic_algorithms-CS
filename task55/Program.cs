// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{                          // 0       1
  int[,] matrix = new int[rows, columns];
  Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
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
      Console.Write($"{matrix[i, j],4} ");
    }
    Console.WriteLine("|");
  }
}

int[,] ChangeLinesOnColumns(int[,] matrix)
{
  int rows = matrix.GetLength(0);
  int columns = matrix.GetLength(1);
  int[,] arr2d = new int[rows, columns];
    for (int i = 0; i < arr2d.GetLength(0); i++)
    {
      for (int j = 0; j < arr2d.GetLength(1); j++)
      {
        arr2d[i,j] = matrix[j,i];
      }
    }
    return arr2d;
}
 //if (matrix.GetLength(0) == matrix.GetLength(1))
int[,] array2d = CreateMatrixRndInt(3, 3, 0, 100);
PrintMatrix(array2d);
Console.WriteLine();
int[,] result = ChangeLinesOnColumns(array2d);
PrintMatrix(result);