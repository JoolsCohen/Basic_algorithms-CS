// Напишите программу, которая на принимает вход три числа и выдает максимально из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 79 -> 22

Console.Write("введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max < b)
{
  max = b;
}

if (max < c)
{
  max = c;
}
Console.Write($"Максимальное число {max}");