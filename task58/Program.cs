// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
// в инете
int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{
  int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];

  for (int i = 0; i < array1.GetLength(0); i++)
  {
    for (int j = 0; j < array2.GetLength(1); j++)
    {
      newArray[i, j] = 0;

      for (int k = 0; k < array2.GetLength(0); k++)
      {
        newArray[i, j] += array1[i, k] * array2[k, j];
      }
    }
  }
  return newArray;
}


int[,] matrixA = CreateMatrixRndInt(m, n, 1, 10);

Console.WriteLine("Матрица А");

PrintMatrix(matrixA);

Console.WriteLine("Матрицв Б");

int[,] matrixB = CreateMatrixRndInt(m, n, 1, 10);

PrintMatrix(matrixB);

Console.WriteLine("Произведение матриц А и Б равно: ");

int[,] resultMatrix = MatrixMultiplication(matrixA, matrixB);

PrintMatrix(resultMatrix);