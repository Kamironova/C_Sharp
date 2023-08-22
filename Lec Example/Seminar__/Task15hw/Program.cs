// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

System.Console.Write("--> ");
int week = Convert.ToInt32(Console.ReadLine());

if (week <8 && week >=1)
{
    if (week == 6 || week == 7)
    {
        System.Console.WriteLine("Ура, выходной!");
    }
    else
    {
        System.Console.WriteLine("Будний день");

    }
}
else
{
    System.Console.WriteLine("Ошибка, введите число от 1 до 7");
}