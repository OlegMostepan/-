// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

static int GetSum( int Num)
{
   int SumOfNumbers = 0;
   while ( Num > 0 || Num < 0)
   {
      SumOfNumbers += Num % 10;
      Num = Num / 10;
   }
   return SumOfNumbers;
}
   
   Console.Write("Введите любое число:   ");
   int Number = int.Parse(Console.ReadLine()); 
   {
      GetSum(Number); 
      Console.WriteLine($"Сумма цифр в числе {Number} = " + GetSum(Number));
   }
  
