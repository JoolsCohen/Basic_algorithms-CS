// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Задайте два натуральных числа:");
Console.WriteLine("Вводим число А:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим число B:");
int n = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num1, int num2)
{
  if (num1 <= num2) return num1 + SumDigits(num1 + 1, num2);
  else return 0;
}
if (m == n)
{
    Console.WriteLine("Числа равны ");
    return;
}
bool NegNumChecking(int num1, int num2)
{
  return (num1 < 0 || num2 < 0);
}
if (NegNumChecking(m, n))
{
  Console.WriteLine("Отрицательные числа не являются натуральными!");
  return;
}
int sumNum = 0;
if (m <= n) sumNum = SumDigits(m, n);
if (m > n) sumNum = SumDigits(n, m);

Console.WriteLine($"Cумма натуральных элементов в промежутке от заданных чисел равна: {sumNum}");