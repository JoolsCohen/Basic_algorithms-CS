// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
//------------------------ПЕРВОЕ РЕШЕНИЕ (С СЕМИНАРА)---------------------
Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
Console.Write("[ ");
if (arraySize < 7 || arraySize > 8)
{
  Console.WriteLine($"Ошибка: введено неверное значение {arraySize}");
  return;
}

int[] arr = CreateArray(arraySize);

PrintArray(arr);

int[] CreateArray(int arrayLength)
{
  int[] newArray = new int[arrayLength];

  Random random = new Random();

  for (int i = 0; i < arrayLength; i++)
  {
    newArray[i] = random.Next(0, 11);
  }

  return newArray;
}
Console.Write("]");
void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
}

//------------------------ВТОРОЕ РЕШЕНИЕ (С ИНТЕРНЕТА)---------------------
// int [] numbers = new int[8];
// Console.Write("[");

// for (int i = 0; i < numbers.Length; i++)
//  {
//     numbers [i] = new Random().Next(0, 11);
//     Console.Write(" " + Method (i) + " ");
//  }
// Console.Write("]");

// int Method (int a)
// {
//     return numbers[a];
// }
