// Задача 12. Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли вроторое число кратным первому. 
// Если число 2 не кратно числу 1, то выводить остаток от деления
// 34, 5 --> не кратно, остаток 4
// 16, 4 --> кратно;

Console.Clear();

System.Console.WriteLine("Введите первое число --> ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число -->");
int b = Convert.ToInt32(Console.ReadLine());

int result = a % b;

if (result == 0)
{
    System.Console.WriteLine($"{a},{b} --> кратно");
}
else
{

    System.Console.WriteLine($"{a}, {b} --> не кратно, остаток от деления {result}");
}