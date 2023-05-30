// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();

System.Console.WriteLine("введите трехзначное число -->");
int a = Convert.ToInt32(Console.ReadLine());

int i = a % 10;

System.Console.WriteLine($"{a} --> {i}");
