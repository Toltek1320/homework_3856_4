// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int Ex(int numA, int numB)

{
  int result = 1;
  for(int i = 1; i <= numB; i++)
  {
    result = result * numA;
  }
  return result;
}

int ex = Ex(numA, numB);
Console.WriteLine("Ответ: " + ex);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num)
{
    
    int counter = Convert.ToString(num).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = num - num % 10;
      result = result + (num - advance);
      num = num / 10;
    }
    return result;   
}

int sumNumber = SumNumber(num);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] array = new int[8]; // Создали новый массив из восьми элементов
Console.Write("[");

for (int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(0, 100); // Положили в массив случайные числа от 0 до 100
    Console.Write($" {Method (i)} ");
}
Console.Write("]");

int Method (int a)
{
    return array[a];
}

// Задача 29: Решение альтернативное (Заполнение массива значениями из строки)

Console.Write("Введите ряд чисел, разделенных запятой: ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для обозначения конца строки

// функция удаления пробелов из строки 
string RemovingSpaces (string series)
{
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}

//  функция  проверки на правильность ввода 
void СheckNumber2 (int  series)
{

    if (series == '0'||series == '1'||series == '2'
    ||series == '3'||series == '4'||series == '5'||series == '6'
    ||series == '7'||series == '8'||series == '9'||series == ','
    ||series == '-')
    {
    }
    else 
    {
        Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");
    }
}

// функция  создания и заполнения массива из строки
int[] ArrayOfNumbers(string seriesNew)
{ 

   int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

   int j =0;

   for (int i = 0; i < seriesNew.Length; i++)
   {
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length)
    {
      seriesNew1 += seriesNew[i];
      СheckNumber2(seriesNew[i]);
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
    if (i < seriesNew.Length-1)
    {
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
    }
    j++;
    }
    return arrayOfNumbers;
}

// функция  вывода массива на печать 
void PrintArry(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while(index < count)
    {
    Console.Write(coll[index]);
    index++;
    if (index < count)
    {
      Console.Write(", ");
    }
    }
    Console.Write("]");
} 


string seriesNew = RemovingSpaces(seriesOfNumbers);

int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);

PrintArry(arrayOfNumbers);
