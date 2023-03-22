// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

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

void EvenNums(int[] arr)
{
  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0) count++;
  }
  Console.WriteLine($"Количество четных чисел в массиве: {count}.");
}

int [] array = CreateArrayRndInt(10, 100, 999);
PrintArray(array);
EvenNums(array);