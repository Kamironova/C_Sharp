// Изучаем рекурсию на примере факториала

// 1! = 1
// 0! = 1


Console.Clear();


double Factorial(int n)
{
    if (n == 1) 
    {
        return 1;
    }
    else 
    {
        return n * Factorial(n-1);  // метод вызвал сам себя
    }
}
//System.Console.WriteLine(Factorial(3)); //1*2*3 = 6

// Ниже вычисление факториала для больших чисел с циклом for

for (int i = 1; i < 40; i++)
{
    System.Console.WriteLine($"{i}! = {Factorial(i)}");
}