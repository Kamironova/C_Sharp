// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NaturalNumberForSum(int m, int n)
{
    
    if (m <= n)
    {  
        System.Console.Write($"{m} ");
        return m + NaturalNumberForSum(m + 1, n);
    }
    else
    {
        return 0;
    }

}


Console.Clear();

System.Console.Write("M --> ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("N -- > ");
int n = Convert.ToInt32(Console.ReadLine());

int result = NaturalNumberForSum(m,n);
System.Console.WriteLine($"--> {result}");
