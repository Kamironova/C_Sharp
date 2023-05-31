// Задание 4. Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

System.Console.WriteLine("Введите первое число --> ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число --> ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите третье число --> ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
        {
            Console.WriteLine($"Max = {a}");
            
        }

        
    else
    {
        Console.WriteLine($"Max = {c}");
    }
}
else
{
    if (b > c)
    {
        Console.WriteLine($"Max = {b}");
    }
    else
    {
        
        Console.WriteLine($"Max = {c}");
    }
}