// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//               Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int [ , ,] GetArray  (int x, int y, int z)   // генерирует числа  массива
{
    Console.WriteLine($"Массив [{x},{y},{z}]");
    int [, ,] array = new int [x, y, z];
    
        Random random = new Random();
       for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int k = 0;
            while (k < array.GetLength(2))
            {
                int number = random.Next(10,100);
                if (Findnumber(array, number)) continue;
                {
                array[i, j, k] = number;
                k++;
                }
            }
        }
    }
    return array;
}

 
 bool Findnumber(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number) 
                {
                    return true ;
                }
            }
        }
    }
    return false;
}



void PrintArray (int [, ,] array)
{   
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {    
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k})"+"\t");
            }Console.WriteLine(); 
        }   
        
    }
    Console.WriteLine();
   
 } 



Console.Write("Введите количество строк X массива: ");
int rowsX = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов Y массива: ");
int columnsY = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк Z массива: ");
int rowsZ = int.Parse(Console.ReadLine());

int [, ,]  ResultArray = GetArray(rowsX, columnsY, rowsZ);
PrintArray(ResultArray);
