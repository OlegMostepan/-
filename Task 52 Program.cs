// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int [,] GetArray (int m, int n) 
{
    int [,] array = new int [m,n];
    Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {    
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] =  random.Next(9); 
            } 
        }
    return array;     
}

int ColumnsNumbersAvrg(int [,] array)
{
    int sum = 0;
    double average = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {    
        for (int j = 0; j < array.GetLength(0); j++)       
        {
            sum  = sum + array[j,i]; // если j, i то  сумма чисел в столбце, если i,j то сумма чисел в строке
            average = Convert.ToDouble(sum) / Convert.ToDouble(array.GetLength(0));     
        }
        Console.Write($"{average,0:f1}" +"\t");
        sum = 0; 
    }
    Console.WriteLine($"--> Среднее арифметическое каждого столбца");
    return sum;
}
        
 void PrintArray (int [,] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}" +"\t");
        } 
        Console.WriteLine();
    }
    Console.WriteLine();
 } 


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());


int [,] ResultArray = GetArray(rows, columns);
PrintArray(ResultArray);
int ResultAverager = ColumnsNumbersAvrg(ResultArray);
