// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> Akkerman(m,n) = 9

 int Akkerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        if(m > 0 && n == 0)
        {
            return Akkerman(m - 1, 1);
        }
        if(m > 0 && n > 0)
        {
        return Akkerman(m - 1, Akkerman(m, n - 1));
        }
        return m;
    }

    
void PrintArray (int result, int M, int N)
{   
    Console.Write($"Akkerman({M},{N}) = {result}"); 
} 

 Console.WriteLine("Введите любое положительное число ");
int M= int.Parse(Console.ReadLine());
Console.WriteLine("Введите любое положительное число ");
int N= int.Parse(Console.ReadLine());
int result = Akkerman(M,N);
PrintArray(result, M, N);
  