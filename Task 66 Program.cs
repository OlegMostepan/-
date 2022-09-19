
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Sum (int M, int N)
{
    if (M < N) 
    {
    return M + Sum(++M,N);
    }
    return M;   
}

void PrintArray (int sum)
{   
    Console.Write($"Сумма чисел = {sum}"); 
} 

Console.WriteLine("Введите любое положительное число ");
int M= int.Parse(Console.ReadLine());
Console.WriteLine("Введите любое положительное число ");
int N= int.Parse(Console.ReadLine());
int sum = Sum(M,N);
PrintArray(sum);