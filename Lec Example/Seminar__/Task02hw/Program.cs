﻿// Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

System.Console.WriteLine("Введите два числа -->");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    System.Console.WriteLine($"max --> {numA}");
}
else
{
    System.Console.WriteLine($"max --> {numB}");
}