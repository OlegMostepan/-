// Задача 19    Напишите программу, которая принимает на вход пятизначное 
//              число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите любое число:   ");
int Number = int.Parse(Console.ReadLine()); 
int Number1 = Number;
int NewReverseNumber = 0;
while ( Number > 0 )
{
    int Remainder = Number % 10;
    NewReverseNumber = (NewReverseNumber * 10) + Remainder;
    Console.WriteLine(NewReverseNumber);
    Number = Number / 10; 
    
}
  if ( Number1 == NewReverseNumber )
{
    Console.Write ("Да, число является палиндромом");
}
  else
{
    Console.Write("Нет, число не является палиндромом");
}