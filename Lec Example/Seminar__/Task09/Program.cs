// Напишите программу, которая выводит случайное число
// из отрезка [10, 99] и показывает наибольшую цифру числа.
// Валерия Шарандина 78 -> 8
// 12-> 2
// 85 -> 8

Console.Clear();

int number = new Random().Next(10, 100);

int numA = number / 10;
int numB = number % 10;

if (numA > numB)
{
    System.Console.WriteLine($"{number} --> max {numA}");
}
else
{
    System.Console.WriteLine($"{number} --> max {numB}");
}