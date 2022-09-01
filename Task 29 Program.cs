// Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных 
//            случайнми числами из [a, b) и выводит их на экран.

//  5, 0, 20 -> [1, 2, 5, 7, 19]
//  3, 1, 35 -> [6, 1, 33]

static int ArrayFilling( int ArrayLength, int NumberA, int NumberB)
{   
    Random rand = new Random();
    int [] array = new int [ArrayLength];   
    int count = 0;
    int i = 0;

    while (count < ArrayLength)
    {
       array [i] =rand.Next(NumberA, NumberB);
       count++;  
       Console.Write(array[i] + "\t");
    }
    return array[i];
    
}   
   
    Console.Write("Введите длину массива " + "\t");
    int ArrayLength = int.Parse(Console.ReadLine());
    Console.Write("Введите число диапазона массива от  " + "\t");
    int NumberA = int.Parse(Console.ReadLine());
    Console.Write("Введите число диапазона массива до  " + "\t");
    int NumberB = int.Parse(Console.ReadLine());

    {
       ArrayFilling(ArrayLength, NumberA, NumberB);
    }
    