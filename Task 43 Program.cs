// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//            уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Ввод значений  b1, k1, b2 и k2 пользователем .


double FindXandY(double b1, double k1, double b2, double k2)
{
// Вычесляем значения x & y
double x = 0;
double y = 0;

if (k1 != k2 && (b1 != b2 | b1 == b2))
{
x = (b2 - b1) / (k1 - k2);

y = k1 * x + b1;

Console.Write($" x = {x:f1} y = {y:f1}");   
}

if (k1 == k2 && b1 == b2)
{       
    Console.Write("Прямые совпадают т.к k1 = k2 и b1 = b2");
}

if  (k1 == k2 && b1 != b2)
{
Console.Write("Прямые паралельны т.к k1 = k2 и b1 не равно b2");
}
return x; 
}


Console.Write("Введите координату:b1 =  ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату:k1 =  ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите координату:b2 =  ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите координату:k2 =  ");
double k2 = double.Parse(Console.ReadLine());

double Result = FindXandY(b1, k1, b2, k2); 