// Задача 7. Напишите программу, которая принимает на вход целое число
// любой разрядности и на выходе показывает третью цифру слева этого числа
// или говорит, что такой цифры нет.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4
// 3 -> нет

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