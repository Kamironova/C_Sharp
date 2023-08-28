// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу квадратов от 1 до N


Console.Clear();

System.Console.Write("Введите число --> ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    num = num * (-1);
}

for (int i = 1; i <= num; i++)
{
    int result = i * i;
    System.Console.Write($" {result}");
}
System.Console.WriteLine();
