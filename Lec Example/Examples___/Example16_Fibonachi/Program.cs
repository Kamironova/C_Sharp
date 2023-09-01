// Рекурсия на примере последовательности фибоначи.
// Фибоначи - каждое следующее число равно сумме двух предыдущих

// Формула вычисления посследовательности Фибоначи:

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)  - формула

double Fibonacci(int n)
{
    if(n == 1 || n == 2)
    {
        return 1;
    }
    else
    {
        return Fibonacci(n-1) + Fibonacci(n-2);
    }
}

for (int i = 1; i < 50; i++)
{
    System.Console.WriteLine($"f{i} = {Fibonacci(i)}");
}
