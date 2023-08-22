// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

System.Console.WriteLine("Введите трехзначное число --> ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 100 && number < 1000)
{
    int numA = number % 100 / 10;
    System.Console.WriteLine(numA);
}
else
{
    System.Console.WriteLine("Ошибка, введите трехзнвачное число");
}