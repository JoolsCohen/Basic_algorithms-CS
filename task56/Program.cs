// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] SumInRow(int[,] matrix)
{
  int[] rowSum = new int[matrix.GetLength(0)];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int sumRow = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      sumRow += matrix[i, j];
    }
    rowSum[i] = sumRow;
  }
  return rowSum;
}
//нашла в инете
int GetMinSum(int[] arr)
{
  int min = arr[0];
  int result = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] < min)
    {
      min = arr[i];
      result = i;
    }
  }
  return result;
}

int[,] array2D = CreateMatrixRndInt(m, n, 0, 10);

PrintMatrix(array2D);

Console.WriteLine();

int[] rowSum = SumInRow(array2D);

int result = GetMinSum(rowSum);

Console.WriteLine($"Строка с наименьшей суммой элементов {result+1}"); //+1 для того, чтобы программа выводила ответ не по индексам, то есть не с 0, а по отсчету 1,2,3...