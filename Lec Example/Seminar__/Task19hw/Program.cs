// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

System.Console.WriteLine("Введите пятизначное число --> ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int newNumber = 0;

if (userNumber > 9999 && userNumber < 100000)
{
    for (int i = userNumber; i > 0; i /= 10)
    {
        newNumber = i % 10 + newNumber * 10;
    }
    if (userNumber == newNumber)
    {
        System.Console.WriteLine($"Число {userNumber} является палиндромом");
    }
    else 
    {
        System.Console.WriteLine($"Число {userNumber} не является палиндромом");
    }
}

else
{
    System.Console.WriteLine("Введите пятизначное число");
}