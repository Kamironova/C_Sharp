// Задача 10. Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

System.Console.WriteLine("Введите трехзначное число --> ");
int a = Convert.ToInt32(Console.ReadLine());

int b = a % 100 / 10;


System.Console.WriteLine(b);