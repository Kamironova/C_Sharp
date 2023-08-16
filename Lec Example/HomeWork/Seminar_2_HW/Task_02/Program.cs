// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

System.Console.WriteLine("Введите число --> ");
int a = Convert.ToInt32(Console.ReadLine());

if (a >= 100)
{
    while (a / 1000 > 0)
    {
        a /= 10;
    }
    int b = a % 10;
    System.Console.WriteLine(b);
}
else
{
    System.Console.WriteLine("Нет");
}