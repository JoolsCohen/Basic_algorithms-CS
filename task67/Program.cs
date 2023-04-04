// Напишите программу, которая будет принимать на вход число и возвращать
// сумму его цифр.
// 453 -> 12
//  45 -> 9


Console.Clear();
Console.WriteLine("Вводим первое число:");
int n = Convert.ToInt32(Console.ReadLine());


int SumDigits(int num)
{
    if (num > 0) return 
    SumDigits(num / 10) + num % 10;
    else return 0;
}

 Console.WriteLine($"Сумма цифр в числе: {SumDigits(n)}");
 Console.WriteLine();