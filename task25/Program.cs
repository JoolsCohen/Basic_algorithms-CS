// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите натуральное число A: ");
double A = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
double B = Convert.ToInt64(Console.ReadLine());
double num = A;

Degree(A, B);

void Degree(double a, double b)
{
   if (b >= 0)
   {
    int num = (int)Math.Pow(a, b);
    Console.WriteLine(A + " в степени " + B + " равно: " + num);
   }
  if (b < 0)
  {
    double y = 1.0 / Math.Pow(a, -b);
    Console.WriteLine(A + " в степени " + B + " равно: " + y);
  }
}