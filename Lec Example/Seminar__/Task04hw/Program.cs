// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

System.Console.WriteLine("Введите три числа -->");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
int numC = Convert.ToInt32(Console.ReadLine());

if (numA > numB && numA > numC)
{
    System.Console.WriteLine($"max --> {numA}");
}
else if (numB> numA && numB > numC)
{
    System.Console.WriteLine($"max --> {numB}");
}
else 
{
    System.Console.WriteLine($"max --> {numC}");
}