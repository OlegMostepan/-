// Задача *  Напишите программу  которая реализует обход введенного двухмерного массива, начиная с крайнего
//           нижнего элемента против часовой стрелки
// 1 2 3 
// 4 5 6 --> 7 8 9 6 3 2 1 4 5
// 7 8 9 
//  



int[,] ArrayCounterClockwiseSort(int [,] array)
 {
// построение двухмерного массива

Console.WriteLine("Исходный двухмерный массив");
for( int i = 0; i < array.GetLength(0); i++ )
{
    for( int j = 0; j < array.GetLength(1); j++ )
    
    {
       Console.Write( array[i, j] + "\t"); 

    }
    Console.WriteLine();
}Console.WriteLine();

// выводит значение нижнего ряда за минусом крайнего правого  столбца

Console.WriteLine("Развернутый массив по спирали против часовой стрелки");
for( int i = array.GetLength(0) - 1; i < array.GetLength(0); i++ )
    for( int j = 0; j < array.GetLength(1); j++ )
{

Console.Write(array[i, j] + "\t");

}


//  выводит значение крайнего правого ряда 

for( int i = array.GetLength(0) - 2; i >= 0; i--)
     for( int j = array.GetLength(1) - 1; j < array.GetLength(1); j++)
{

 Console.Write(array[i, j] + "\t");

}

// выводит значение верхнего ряда за минусом крайнего правого столбца

for( int i = 0; i >=0; i-- )
    for( int j = array.GetLength(1)-2; j >=0; j-- )
    
{

Console.Write(array[i, j] + "\t");

}

// выводит внутренний ряд

for( int i = 1 ; i <= array.GetLength(0)-2; i++ )
    for( int j = 0; j <= array.GetLength(1)-2; j++ )
    
{

Console.Write(array[i, j] + "\t");

}
return array;
}
 


int[,] array = new int[,] 
{ { 1, 2, 3,}, 
  { 4, 5, 6,}, 
  { 7, 8, 9,} 
}; 

int [,] result = ArrayCounterClockwiseSort(array);