// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите натуральное число A: ");
double A = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
double B = Convert.ToInt64(Console.ReadLine());

// Degree(A, B);

// void Degree(double a, double b)
// {
//    if (b >= 0)
//    {
//     int resPos = (int)Math.Pow(a, b);
//     Console.WriteLine(A + " в степени " + B + " равно: " + resPos);
//    }
//   if (b < 0)
//   {
//     double resNeg = 1.0 / Math.Pow(a, -b);
//     Console.WriteLine(A + " в степени " + B + " равно: " + resNeg);
//   }
// }
//-----------------------------Второе решение------------------------------

void Degree(double a, double b)
{
   double resPos = a;
  for (double i = 1; i < b; i++)
  {
    resPos *= a;
  }
      Console.WriteLine(A + " в степени " + B + " равно: " + resPos);
}
  if (B < 0)
  {
    double resNeg = 1.0 / Math.Pow(A, -B);
    Console.WriteLine(A + " в степени " + B + " равно: " + resNeg);
  }
  else Degree(A, B);