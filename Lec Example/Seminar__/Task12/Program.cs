// Задача 12. Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли вроторое число кратным первому. 
// Если число 2 не кратно числу 1, то выводить остаток от деления
// 34, 5 --> не кратно, остаток 4
// 16, 4 --> кратно;

Console.Clear();

System.Console.WriteLine("Введите два числа --> ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());

int result = numA % numB;

if (result == 0)
{
    System.Console.WriteLine($"Число {numB} кратно {numA} ");
}

else 
{
    System.Console.WriteLine($"Числа {numB} и {numA} не кратны, процент от остатка {result}");
}
