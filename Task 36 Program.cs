// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//            Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int SumOfOddIndexes( int Length)
{
    int[] a = new int[Length];
    int sum = 0;

    for (int i = 0; i < Length; i++)
        {

        a[i] = new Random().Next(-10,10);
        Console.Write(a[i] + " ");
        if (i % 2 == 1)
        sum += a[i];
        }
        Console.WriteLine();
        Console.WriteLine($"Сумма чисел нечетных идексов в массиве = {sum}"); 
    return Length;
}

Console.Write("Введите длину массива: ");
int Number = int.Parse(Console.ReadLine());
int result = SumOfOddIndexes(Number);


