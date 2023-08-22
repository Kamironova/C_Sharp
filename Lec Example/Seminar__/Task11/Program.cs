// 11. Напишите программу, которая выводит случайное трёхзначное 
// число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Console.Clear();

int number = new Random().Next(100, 1000);

int numA = number / 100;
int numB = number % 10;
int result = (numA * 10) + numB;

System.Console.WriteLine($"{number} --> {result}");

//System.Console.WriteLine($"{number} --> {numA}{numB}");