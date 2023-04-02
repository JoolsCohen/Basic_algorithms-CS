// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

//какая то херня, которую мы не проходили

int[,,] threeDArray = Create3DArray(2, 2, 2, 10, 100);

Print3DArray(threeDArray);

int[,,] Create3DArray(int x, int y, int z, int min, int max)
{
  int[,,] arr = new int[x, y, z];
  Random rnd = new Random();

  for (int i = 0; i < arr.GetLength(0); i++) //длинна
  {
    for (int j = 0; j < arr.GetLength(1); j++) //высота
    {
      for (int k = 0; k < arr.GetLength(2); k++) //ширина
      {
        int next = 0;
        while (true)
        {
          next = rnd.Next(min, max);
          if (!Contains(arr, next))
            break;
        }
        arr[i, j, k] = next;
      }
    }
  }
  return arr;
}

bool Contains(int[,,] arr, int num)
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
