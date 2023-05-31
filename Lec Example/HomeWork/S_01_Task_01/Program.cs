// Напишите программу которая на вход принимает два числа
// и выдает какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

System.Console.WriteLine("Введите первое число --> ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число --> ");
int b = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (a > b) 
{
    System.Console.WriteLine($"Max --> {a}");
}
else System.Console.WriteLine($"Max --> {b}");