// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

System.Console.WriteLine("--> ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100)
{
    while (num/ 1000 > 0)
    {
        num /= 10;
    }
    int result = num % 10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Нет");
}
