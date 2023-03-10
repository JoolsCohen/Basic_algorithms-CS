// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Веведите первое число: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Веведите второе число: ");
int numB = Convert.ToInt32(Console.ReadLine());

int result = Multiplicity(numA, numB);

if(result == 0)
{
    Console.WriteLine("Тут все кратно.");
}
else
{
    Console.WriteLine($"Нифигааа, остаток {result}");
}

int Multiplicity(int number1, int number2)
{
    return number1 % number2;    
}

int ReadConsole()
{
    var str = Console.ReadLine();
    int number = Convert.ToInt32(str);

    return number;
}