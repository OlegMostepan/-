// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
        }Console.WriteLine("Исходный массив");
    return array;     
}

int[, ] DescendingRowNums(int [, ] array)
{
    int temp = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {    
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int y = 0; y < array.GetLength(1) - 1 - j; y++)
            {          
                if (array [i,y] < array [i,y+1]) // если поставить знак <, то числа сортируются в строках по убыванию, если >, то по возрастанию.
                {
                    temp = array [i, y]; 
                    array [i,y] = array [i, y + 1];
                    array [i, y+1] = temp;
                }
            }
        }
    } Console.WriteLine("В массиве числа в строках отсортированны по убыванию");
    return array;
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
int [,] ResuilFinal = DescendingRowNums(ResultArray);
PrintArray(ResuilFinal);