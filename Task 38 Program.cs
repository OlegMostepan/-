// Задача 38: Задайте массив вещественных чисел. 
//            Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int MaxMin( int Length)
{
   double[] array = new double[Length];
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
    array [i] = random.NextDouble()*100;
    Console.Write("{0, 6:F2}", array[i]);
    }
    double max = array.Max();
    double min = array.Min();
    double result = max - min;
    Console.WriteLine();
    Console.WriteLine("Max = {0, 0:F2}", array.Max());
    Console.WriteLine("Min = {0, 0:F2}", array.Min());  
    Console.WriteLine("Разница = {0, 0:F2}", result); 
    return Length;
}

Console.Write("Введите длину массива: ");
int Number = int.Parse(Console.ReadLine());
double result = MaxMin(Number);
