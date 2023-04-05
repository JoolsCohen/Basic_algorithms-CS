// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Задайте два неотрицательных числа:");
Console.WriteLine("Первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int FunctionAckermann(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return FunctionAckermann(m - 1, 1);
  else return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1));
}
bool NegNumChecking(int num1, int num2)
{
  return (num1 < 0 || num2 < 0);
}
if (NegNumChecking(m, n))
{
  Console.WriteLine("Вы ввели отрицательные числа!");
  return;
}
int functionAckermann = FunctionAckermann(m, n);
Console.Write($"Результат вычисления функции Аккермана чисел {m} и {n} = {functionAckermann} ");

// Функция Аккермана:
// A(0,n) = n+1
// A(m,0) = A(m-1,1)
// A(m,n) = A(m-1,A(m,n-1))
