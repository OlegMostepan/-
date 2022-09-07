// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//            Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int RandomNumbersinArray (int Length)
{
    int [] array = new int [Length];
    int Evencount= 0;

    for (int x = 0; x < Length; x++)
    {
    array [x] = new Random().Next(99, 1000);
    Console.Write(array[x] + " ");

        if (array[x] % 2 == 0)
        Evencount++;
    } 
    Console.WriteLine();
    Console.WriteLine($"Чётных чисел в массиве = {Evencount}");   
    return Length;    
    
}   

Console.Write("Введите длину массива: ");
int Number = int.Parse(Console.ReadLine());
int Array = RandomNumbersinArray (Number);


