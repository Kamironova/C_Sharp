// Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Clear();

void NaturalNumbers(int m, int n)
{
    if (m <= n)
    {
        System.Console.Write($"{m} ");
        NaturalNumbers(m + 1, n);
    }
    System.Console.WriteLine();
}

System.Console.Write("M --> ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("N --> ");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(m, n);
