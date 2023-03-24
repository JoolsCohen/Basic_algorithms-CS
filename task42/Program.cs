// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
//-----------------------------ПЕРВОЕ РЕШЕНИЕ--------------------------------------------
Console.Write("Введите десятичное число: ");

bool isParsed = int.TryParse(Console.ReadLine(), out int number); 

int digits = GetNumberOfDigits(number);

int[] array = GetArray(digits);

PrintArray(array);



if(!isParsed)                                     
{                                                 
    Console.WriteLine("Неверное число");
    return;
}

int GetNumberOfDigits(int number)               
{                                                   
  int digits = 0;                                  
    while (number > 0)
  {
    number /= 2;
    digits ++;
  }
 return digits;
}

int[] GetArray(int digits)          
{
    int length = digits;      
    int[] array = new int[length];        
    for (int i = length-1; i >= 0 ; i--)   
    {
        array[i] = number % 2;             
        number = number / 2;
    }
    return array;
}


 void PrintArray(int[] array)              
{
       Console.WriteLine(@"Двоичное число [{0}]", string.Join("", array)); 
}                                        

/* Решение через строку
string GetBinom(int number)
{
  string binar = string.Empty; // вводим пустую строку, в которую будем заносить
                               // двоичный код
  while(number != 0)
  {
    binar = number % 2 + binar; // В НАЧАЛО СТРОКИ СКЛАДЫВАЕМ ОСТАТОК ОТ ДЕЛЕНИЯ НА 2!!!
    number /= 2;                // если будем складывать в конец, то получим строку перевернутую
  }
  return binar;
}
*/
//-----------------------------ВТОРОЕ РЕШЕНИЕ--------------------------------------------
Console.Clear();

int decimal1 = 2;
int result = DecToBinInt(decimal1);

Console.WriteLine(result);

string DecToBinString(int decimalNumber)
{
    if (decimalNumber == 0 || decimalNumber == 1)
    {
        return decimalNumber.ToString();
    } 

    string dec = string.Empty;
    while (decimalNumber > 0)
    {
        dec = decimalNumber % 2 + dec;
        decimalNumber /= 2;                
    }
    return dec;
}

int DecToBinInt(int decimalNumber)
{
    if (decimalNumber == 0 || decimalNumber == 1)
    {
        return decimalNumber;
    } 

    int dec = 0;
    int i = 1;
    while (decimalNumber > 0)
    {
        dec = dec + decimalNumber % 2 * i;        
        decimalNumber /= 2; 
        i *= 10;              
    }
    return dec;
}