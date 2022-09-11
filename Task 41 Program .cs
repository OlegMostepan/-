
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//            Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// ВАРИАНТ НОМЕР 1 РЕШЕНИЯ ЧЕРЕЗ СОРТИРОВКУ

int  NumbersEnterAndSort( int  size)
{
   int num = 0;
   int count = 0; 
   for (int i = 0; i < size; i++)
   { 
    Console.Write("Введите любые числа в том числе отрицательные " ); 
    
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


// ВАРИАНТ НОМЕР 2 РЕШЕНИЯ ЧЕРЕЗ МАССИВ

int ArrayEnterAndSort(int length)
{


int [ ] array = new int [length];

for ( int i = 0; i< array.Length; i++)
{
    Console.Write("Введите любые числа\t");
    array[i] = int.Parse(Console.ReadLine());
}
int count = 0;
for ( int i = 0; i< array.Length; i++)

if ( array[i] > 0)
{
  count++;
}
Console.WriteLine($"Введено чисел в кол-ве {count} > 0");
return length;
} 

Console.Write("Введите положительное число от 3 до 5 включительно\t");
int Amount = int.Parse(Console.ReadLine());
int Result = ArrayEnterAndSort(Amount);


