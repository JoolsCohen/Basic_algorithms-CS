// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3


Console.Write("Место для ввода количества чисел: ");

bool isParsed = int.TryParse(Console.ReadLine(), out int size); // подсмотрела в инете. хз как раотает...

int[] array = CreateArray(size);

PrintArray(array);

int count = GetQuantityOfPositiveNumbers(array);

Console.WriteLine($"Положительных чисел в массиве: {count}");

if (size <= 0)
{
    Console.WriteLine("Нужно вводить только положительные числа, это те, что больше 0");
    return;
}

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введи {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


void PrintArray(int[] array)
{
    Console.WriteLine(@"[{0}]", string.Join("; ", array));
}

int GetQuantityOfPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}