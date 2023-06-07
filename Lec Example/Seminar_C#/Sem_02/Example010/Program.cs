// Задача 14. Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.
// 14 --> нет
// 46 --> нет
// 161 --> да

Console.Clear();

System.Console.WriteLine("Введите число --> ");
int x = int.Parse(Console.ReadLine()!);

if (x % 7 == 0 && x % 23 == 0)
{
    System.Console.WriteLine($"{x} --> да");
}
else
{
    System.Console.WriteLine($"{x} --> нет");
}