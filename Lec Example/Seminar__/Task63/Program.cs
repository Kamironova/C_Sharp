// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N. C помощью РЕКУРСИИ

Console.Clear();

void NaturalNumbers(int n, int start = 1)
{
    if (start <= n)
    {
        System.Console.Write($"{start} ");
        NaturalNumbers(n, start + 1);
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Enter number N --> ");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(n);