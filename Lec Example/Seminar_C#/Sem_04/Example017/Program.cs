// Задача 26. Напишите программу, которая принимает на вход число и
// и выдает колличество цифр в числе (определяет разрядность)
// 456 --> 3
// 78 --> 2
// 89126 --> 5

int Num(int x)
{
    int count = 0;
    while (x != 0)
    {
        x = x/ 10;
        count++;
    }
    return count;

}



Console.Clear();

System.Console.WriteLine("Enter --> ");
int x = Convert.ToInt32(Console.ReadLine()!);

if (x==0)
{
    System.Console.WriteLine($"{x} --> 1");
}
else 
{
    System.Console.WriteLine($"{x}  --> {Num(x)}"); 
}