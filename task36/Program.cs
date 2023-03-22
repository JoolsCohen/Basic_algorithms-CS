// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
  int[] arr = new int[size];
  Random rnd = new Random();

  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = rnd.Next(min, max + 1);
  }
  return arr;
}

void PrintArray(int[] arr)
{
  Console.WriteLine("[{0}]", string.Join(", ", arr));
}

int SumDigits(int[] arr)
{
  int sum = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (i % 2 != 0)
    {
      sum = arr[i] + sum;
    }
  }
  return sum;
}

int[] array = CreateArrayRndInt(10, -10, 10);

PrintArray(array);

int amt = SumDigits(array);

Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях = {amt}.");