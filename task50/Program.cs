// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();
Console.WriteLine("Вводим количествово строк:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вводим количествово столбцов:");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Вводим номер строки, начиная c 0:  ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Вводим номер столбца, начиная c 0:  ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
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
      Console.Write($"{matrix[i, j],3} ");
    }
    Console.WriteLine("|");
  }
}

bool FindNumByIndexes(int rows, int columns, int[,] array)
{
  if (rows < array.GetLength(0) && columns < array.GetLength(1))
  {
    return true;
  }
  else
  {
    return false;
  }
}

int[,] array2d = CreateMatrixRndInt(m, n, 0, 10);
PrintMatrix(array2d);
bool result = FindNumByIndexes(row, column, array2d);
Console.Write(result ? "Элемент массива с указанными индексоми равен " + array2d[row, column] : "Элемента массива с указанными индексоми не существует");