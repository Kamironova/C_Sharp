// Задача 28. Напишите программу, которая принимает на вход число N
// и выдает произведение числе от 1 до N ( факториал )
// 4 --> 24
// 5 --> 120

int Fact(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result = i * result;
    }
    return result;
}




Console.Clear();

System.Console.WriteLine("Enter --> ");
int n = Convert.ToInt32(Console.ReadLine()!);

System.Console.WriteLine($"{n} --> {Fact(n)}");