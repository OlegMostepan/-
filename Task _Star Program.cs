// Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.


static int ChristmasTree(int Number)
{
Console.WriteLine();
    for (int i = Number; i > 0; i--)
    {
         for (int j = Number - i  ; j < Number; j++)
        {
            Console.Write(" ");                    
        }
        for (int j = 0 ; j <= Number - i; j++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
    return Number;
}
          
Console.Write("Введите число высоты ёлки  ");
int Number = int.Parse(Console.ReadLine());
{
    ChristmasTree(Number);
}



