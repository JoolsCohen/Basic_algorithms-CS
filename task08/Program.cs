//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
if (num == 1) Console.WriteLine("Нет в "+num+" четных чисел, давай по новой!");
while (i <= num)
{
  if (i % 2 == 0)
  {
    Console.Write(i + ", ");
  }
  i++;
}
