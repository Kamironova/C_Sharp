// Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр.

Console.Clear();

int SumNumber(int number)
{
    if (number > 0)
    {
        return number % 10 + SumNumber(number/10);
    }
    else 
    {
        return 0;
    }
}

System.Console.Write("Enter number --> ");
int num = Convert.ToInt32(Console.ReadLine());


int result = SumNumber(num);
System.Console.WriteLine(result);
