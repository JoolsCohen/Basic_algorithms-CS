// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] array3D = Create3DArray(2, 2, 2, 10, 100);

Print3DArray(array3D);

int[,,] Create3DArray(int x, int y, int z, int min, int max)
{
  int[,,] arr = new int[x, y, z];
  Random rnd = new Random();
  if (x * y * z < 99)
  {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
        for (int k = 0; k < arr.GetLength(2); k++)
        {
          int next = 0;
          while (true)
          {
            next = rnd.Next(min, max);
            if (!unicumInArr(arr, next))
              break;
          }
          arr[i, j, k] = next;
        }
      }
    }
  }
  else
  {
    Console.WriteLine("Слишком большой массив для уникальных двухзначных чисел");
  }
  return arr;
}

bool unicumInArr(int[,,] arr, int num)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        if (arr[i, j, k] == num) return true;
      }
    }
  }
  return false;
}

void Print3DArray(int[,,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      for (int k = 0; k < arr.GetLength(2); k++)
      {
        Console.WriteLine($"{arr[i, j, k]} ({i}, {j}, {k})");
      }
    }
  }
}

