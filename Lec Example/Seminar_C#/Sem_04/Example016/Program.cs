// Задача 24. Напишите программу, которая принимает
// на вход число (А) и выдает сумму сисел от 1 до А.
// 7 --> 28
// 4 --> 10
// 8 --> 36

// !!! далее 2 варианта решения через фуекцию void и через возвращающую

int Sum(int a)
{
    int result = 0;
    for (int i = 1; i <= a; i++)
    {
        result+=i;  // result = result + i
    }
    return result;
}

void Sum2(int a)
{
    int result = 0;
    for (int i = 1; i <= a; i++)
    {
        result += i;
    }
    System.Console.WriteLine($"{a} --> {result}");
}

 
Console.Clear();

System.Console.WriteLine("Enter --> ");
int a = int.Parse(Console.ReadLine()!);

//System.Console.WriteLine($"{a} --> {Sum(a)}");
Sum2(a);