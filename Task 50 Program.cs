// Задача 50. Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, и возвращает 
//            индексы этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет



int [,] GetArray (int m, int n)
{
    int [,] array = new int [m,n];
    Random random = new Random();
    
        for (int i = 0; i < array.GetLength(0); i++)
        {    
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] =  random.Next(-20,20);                           
            } 
        }

    return array;     
}

int CheckArrayAndNumber(int [,] array, int num)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if  (array[i,j] == num)
            {
                Console.Write($"Число {num} c индексами i = {i} и j = {j} в массиве есть.");
            } 
            else
            {
                Console.Write($"Такого числа {num} в массиве нет.");
            }        
        }   
    }
    
    return num;
}
        
 void PrintArray (int [,] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j], 0:f2}" +"\t");
        } 
        Console.WriteLine();
    }
    
 } 


Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Введите чмсло от -20 до 20 : ");
int number = int.Parse(Console.ReadLine());

int [,] ResultArray = GetArray(rows, columns);
PrintArray(ResultArray);
int ResultArrayAndNumber = CheckArrayAndNumber(ResultArray, number);

