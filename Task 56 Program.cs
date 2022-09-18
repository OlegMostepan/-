// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int SumNumbersinRow(int [,] array)
{
    int sum = 0;
    int MinSum = 0;
    int index = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {    
        for (int j = 0; j < array.GetLength(1); j++)   
        {
            sum = sum + array[i,j]; 

        } 
        Console.Write($"{sum} [строка {i+1}]" +"\t");
        if (i==0) 
        {
            MinSum = sum;
        }
        if (sum < MinSum)
        {
            MinSum = sum;
            index = i+1;
        }
        sum = 0;
    }
    Console.WriteLine($"--> Сумма чисел в каждой строке и номер строки");
    Console.WriteLine($"Строка номер {index} c наименьшей суммой чисел {MinSum}");
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
int ResultSum = SumNumbersinRow(ResultArray);

