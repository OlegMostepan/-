// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


double [,] GetArray (int m, int n)
{
    double [,] array = new double [m,n];
    Random random = new Random();
    
        for (int i = 0; i < array.GetLength(0); i++)
        {    
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] =  Convert.ToDouble(random.Next(-10,10)) + random.NextDouble();                           
            } 
        }

    return array;     
}


 void PrintArray (double [,] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j], 0:f1}" +"\t");
        } 
        Console.WriteLine();
    }
    
 } 

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
double [,] Result = GetArray(rows, columns);
PrintArray(Result);