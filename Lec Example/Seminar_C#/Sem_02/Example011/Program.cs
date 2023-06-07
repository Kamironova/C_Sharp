// Задача 16. Напишите программу, которая принимает на вход два
//  числа и проверяет является ли одно квадратом другого
// 5, 25 --> да
// -4, 16 --> да
// 25,5 --> да
// 8, 9 --> нет

Console.Clear();

System.Console.WriteLine("Введите первое число --> ");
int x1 = int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите второе число --> ");
int x2 = int.Parse(Console.ReadLine()!);

if (x1 % x2 == 0 || x2 % x1 == 0)
{
    System.Console.WriteLine($"{x1}, {x2} --> да");
}
else
{
    System.Console.WriteLine($"{x1}, {x2} --> нет");
}