// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] GetArray1  (int rows1, int columns1)   // генерирует числа 1-й массив
{
    Console.WriteLine("Массив номер 1");
    int [,] array = new int [rows1,columns1];
    Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {    
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] =  random.Next(5); 
            } 
        }
    return array;     
}

int [,] GetArray2  (int rows2, int columns2)   // генерирует числа 2-й массив
{
    Console.WriteLine("Массив номер 2");
    int [,] array = new int [rows2,columns2];
    Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {    
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] =  random.Next(5); 
            } 
        }
    return array;     
}

int [,] MatrixesMultiplc (int [,] array1, int [,] array2,int rows1, int rows2, int columns2)
{
    Console.WriteLine("Результат умножения Массива 1 на Массив 2");
    int [,] array = new  int [rows1,columns2];
    for (int i = 0; i < rows1; i++)    
    {    
        for (int j = 0; j < columns2; j++)   
        {
            array[i,j]=0;
            for (int k = 0; k < rows2; k++)   
            {                
                array[i,j] += array1[i,k] * array2[k,j]; 
            }  
        } 
        
    }   
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

void ConditionCheck(int columns1, int rows2) // Проверяет возможности умножения при условии, если число столбцов 1-го массива = числу строк 2-го массива.
{
    if (columns1 != rows2)
    {
       throw new Exception("Умножение не возможно. Не выполняется условие умножения массивов. Введите количество столбцов в 1-м массиве равного числу строк во 2-м массиве");
    }
   
}

Console.Write("Введите количество строк 1-го массива: ");
int rows1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 1-го массива: ");
int columns1 = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк 2-го массива равного числу столбцов в 1-м массиве: ");
int rows2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 2-го массива: ");
int columns2 = int.Parse(Console.ReadLine());

ConditionCheck(columns1,rows2); // проверка соблюдения условий умножения массивов

int [,] ResultArray1 = GetArray1(rows1, columns1);
PrintArray(ResultArray1);

int [,] ResultArray2 = GetArray2(rows2, columns2);
PrintArray(ResultArray2);

int [,] FinalResulrtArray3 = MatrixesMultiplc(ResultArray1, ResultArray2, rows1, rows2, columns2);
PrintArray(FinalResulrtArray3);