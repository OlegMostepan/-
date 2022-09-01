//  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит
//             число A в натуральную степень B.

//  3, 5 -> 243 (3⁵)

//  2, 4 -> 16

static int RaiseNumberTo3rdPower(int NumberA, int NumberB)
{
   int i = 0;
   int ProductOfNumbersA = 1;
   while ( i < NumberB)
   {
      ProductOfNumbersA = ProductOfNumbersA * NumberA;  
      i++;
   }
   Console.WriteLine($"число {NumberA} в степени {NumberB} = {ProductOfNumbersA}");
   return ProductOfNumbersA;
}
  

Console.Write("Введите число А = ");
int NumberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B = ");
int NumberB = int.Parse(Console.ReadLine());  
{
   RaiseNumberTo3rdPower(NumberA, NumberB);
}