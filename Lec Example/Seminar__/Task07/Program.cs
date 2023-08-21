// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();

System.Console.WriteLine("Введите трехзначное число -->");
int num = Convert.ToInt32(Console.ReadLine());

//int num2 = num %10;
//System.Console.WriteLine(num2);

if (num >99 && num <= 999 )
{
System.Console.WriteLine(num % 10);
}
else 
{
    System.Console.WriteLine("Ведите трехзначное число!");
}