// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



int [,] GetArray  (int x, int y)   
{
    Console.WriteLine($"Массив [{x},{y}]");
    int [,] array = new int [x, y];
    int n = 1;
    
    for (int variable = 0 ; variable < x - 2 ; variable++ )
    {
        for (int j = variable ; j < y - variable  ; j++)
        {
            array[0 + variable, j ] = n + variable;
            n++;
        }n--;
        for (int i = 0 + variable ; i < y - variable ; i++)
        {
            array[i, y - variable -1 ] = n + variable ;
            n++;
        }n--;
        for (int j = y - variable - 1; j >= 0 + variable ; j--)
        {
            array[(x - 1 - variable),j] = n + variable; 
            n++;
        }n--;
        for (int i = x - 1 - variable; i >= 1 + variable; i--)
        {
            array[i,0 + variable] = n + variable;
            n++;
        }n--;
        
    }
    return array;
}

void PrintArray (int [,] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {   
            if (array[i,j] < 10) 
            {
                Console.Write(String.Format("{0:00}" +"\t", array[i,j]));
            }  
            else
            {
                Console.Write($"{array[i, j]}" + "\t"); 
            }  
                
        }Console.WriteLine();
        
    }
    Console.WriteLine();
   
 } 
 


Console.Write("Введите количество строк X массива: ");
int rowsX = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов Y массива: ");
int columnsY = int.Parse(Console.ReadLine());

int [,]  ResultArray = GetArray(rowsX, columnsY);
PrintArray(ResultArray);
