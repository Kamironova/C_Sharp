﻿// Задача 22. Напишите программу, которая принимает на вход число (N) и выдает 
// таблицу квадратов чисел от 1 до N
// Например:
// 5 --> 1, 4, 9, 16, 25;
// 2 --> 1, 4;

Console.Clear();

System.Console.WriteLine("Введите число --> ");
int n = Convert.ToInt32(Console.ReadLine()!);

System.Console.WriteLine($"Таблица квадратов чисел от 1 до {n} --> ");

for (int i = 1; i <= n; i++)
{
    System.Console.WriteLine(($"{i} в квадрате = {Math.Pow(i,2)}"));
} 