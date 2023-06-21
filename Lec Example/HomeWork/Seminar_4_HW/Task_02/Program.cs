// Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

//  DONE!!

int SumNum(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /= 10;

    }
    return sum;
}

Console.Clear();

System.Console.WriteLine("Введите число --> ");
int num = int.Parse(Console.ReadLine()!);


System.Console.WriteLine($"{num} --> {SumNum(num)}");