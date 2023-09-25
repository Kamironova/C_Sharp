// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int Ackermann(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return Ackermann(n-1, 1);
    }
    else
    {
        return Ackermann(n-1, Ackermann(n, m-1));
    }
}


Console.Clear();
// System.Console.WriteLine(" M, N -->");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($" A(m,n) = {Ackermann(2,3)}");
