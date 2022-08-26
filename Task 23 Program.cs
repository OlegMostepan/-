// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите любое положительное число ");
int Number = int.Parse(Console.ReadLine());
int i = 1;
Console.Write($"Кубы чисел от 1 до {Number} = ");
while ( i <= Number)
{
     
Console.Write($"{Math.Pow(i, 3):f0}, ", i++);

}
