// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

System.Console.WriteLine("Введите пятизначное число --> ");
int number = Convert.ToInt32(Console.ReadLine());

while (number > 0)
{
    int num1 = number % 10;
    System.Console.WriteLine(num1);
}