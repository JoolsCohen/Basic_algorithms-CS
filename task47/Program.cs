// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();
Console.WriteLine("Вводим кол-во строчек:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим кол-во столбиков:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
  double[,] matrix = new double[rows, columns];
  Random rnd = new Random();
  for (var i = 0; i < matrix.GetLength(0); i++)
  {
    for (var j = 0; j < matrix.GetLength(1); j++)
    {
      double num = rnd.NextDouble() * (max - min) + min;
      matrix[i, j] = Math.Round(num, 1);
      //matrix[i, j] = Math.Round(rnd.NextDouble() * rnd.Next(min, max), 1); // альтернатива
    }
  }
  return matrix;
}

void PrintMatrix(double[,] matrix)
{
  for (var i = 0; i < matrix.GetLength(0); i++)
  {
    Console.Write("|");
    for (var j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j], 5} ");
    }
    Console.WriteLine("|");
  }
}

double[,] array2d = CreateMatrixRndDouble(m, n, 1, 10);
PrintMatrix(array2d);