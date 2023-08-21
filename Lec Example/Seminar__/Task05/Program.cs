// Напищите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа а промежутке от -N до N.
// Например:
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"


Console.Clear();

System.Console.WriteLine("Введите число --> ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = number * -1; i <= number; i++)  // можно -number вместо number * -1
{
    System.Console.Write($"{i} ");
}
System.Console.WriteLine();