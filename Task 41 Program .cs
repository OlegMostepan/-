
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//            Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int  NumbersEnterAndSort( int  size)
{
   int num = 0;
   int count = 0; 
   for (int i = 0; i < size; i++)
   { 
    Console.Write("Введите любые числа в том числе отрицательные (i = {0}): ", i); 
    
    num = int.Parse(Console.ReadLine());
    
        if (num > 0 )
        {
            count= count+1;
    
        } 
            Console.WriteLine();
   }
    Console.WriteLine($"Введено {count} чисел > 0");  
   
   return num;
}



Console.WriteLine("Введите количетво чисел которое будите вводить");
int Number = int.Parse(Console.ReadLine());
int result = NumbersEnterAndSort(Number);


