// Задача 21   
// 
// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.

//  A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Ввод координат точки А
Console.WriteLine("Введите координату:Ax =  ");
int Ax = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату:Ay =  ");
int Ay = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату:Az =  ");
int Az = int.Parse(Console.ReadLine());
// Ввод координат точки B
Console.WriteLine("Введите координату:Bx =  ");
int Bx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату:By =  ");
int By = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату:Bz =  ");
int Bz = int.Parse(Console.ReadLine());

Console.WriteLine($"Расстояние между А и В = {Math.Sqrt(Math.Pow((Ax - Bx),2) + Math.Pow((Ay - By),2) + Math.Pow((Az - Bz),2)):f2}");
