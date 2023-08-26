﻿// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int NumberSum(int number)
{
    int sum = 0;
    int num = 0;

    while (number > 0)
    {
        num = number % 10;
        sum = sum + num;
        number = number/ 10;
    }
    return sum;
}

Console.Clear();

System.Console.WriteLine("--> ");
int userNumber = Convert.ToInt32(Console.ReadLine());



System.Console.WriteLine($"Сумма цифр числа {userNumber} --> {NumberSum(userNumber)}");