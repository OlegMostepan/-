// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
//            число и на выходе показывает вторую цифру этого числа.

//  456 -> 5
//  782 -> 8
//  918 -> 

Console.WriteLine("Введите число ");
int Number = int.Parse(Console.ReadLine());
if (Number > 99 & Number < 1000 || Number < -99 & Number > -1000)
{
    Console.WriteLine(Number / 10 % 10);
}
else
{
    Console.WriteLine("Не верные данные.Введите число от 100 / -100 до 999 / -999");
}