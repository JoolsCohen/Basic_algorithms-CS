// Напишите программу, которая на вход принимает два числа A и B,
//  и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243
// A = 2; B = 3 -> 8

Console.Clear();
Console.WriteLine("Вводим число А:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим число В:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Возведение числа А в целую степень B = {Degree(a, b)}");

double Degree(double a, double b)
{
    if (b < 0) return (1 / a) * Degree(a, b + 1); // a ^ (-2) = 1 / (a * a)
    if (b > 0) return a * Degree(a, b - 1);
    else return 1;
}


// int Degree(int n1, int n2)
//  {
//      if (n2 == 0) return 1;
//      else return n1 * (Degree(n1, n2-1));
//  }