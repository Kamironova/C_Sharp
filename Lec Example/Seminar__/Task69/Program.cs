// Напишите программу, которая на вход принимает два числа n и B, 
// и возводит число А в целую степень B с помощью рекурсии.


int ProdNum(int n, int m)
{

    if (m == 1)
    {
        return n;
    }
    else
    {
        return n * ProdNum(n, m-1);
    }
}




Console.Clear();

System.Console.Write("A --> ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.Write("B --> ");
int m = Convert.ToInt32(Console.ReadLine());

int result = ProdNum(n, m);
System.Console.WriteLine(result);
