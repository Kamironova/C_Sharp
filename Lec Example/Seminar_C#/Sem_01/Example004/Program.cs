// Напищите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа а промежутке от -N до N.
// Например:
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"


Console.Clear();
System.Console.WriteLine("Введите число -> ");
int a = Convert.ToInt32(Console.ReadLine());

int i = -1 * a;

while (i <= a)
{
    System.Console.Write(i + " ");
    i++;
}
