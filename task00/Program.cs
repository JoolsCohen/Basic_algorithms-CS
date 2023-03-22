// Напишите программу, которая 
// 1. на вход принимают число
// 2. выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// string input = Console.ReadLine();
// int num = Convert.ToInt32(input);
Console.Clear();
Console.Write("введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int square = num * num;

Console.WriteLine($"квадрат числа {num} = {square}");