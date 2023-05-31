// Написоть программу, которая принимает на вход число 
// любой разрядности и выдает его третью цифру.
// Например:
// 123456787 --> 3:
// 5678 --> 7;

Console.Clear();

System.Console.WriteLine("ВВедите любое число --> ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100)
{
    while (num / 1000 >0)
    {
        num /= 10;
    }
    int d = num %10;
    System.Console.WriteLine(d);
}
else System.Console.WriteLine("Третьей цифры нет");