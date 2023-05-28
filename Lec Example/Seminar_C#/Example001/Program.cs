// Напишите программу которая на вход принимает число и выдает его квадрат. 
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

System.Console.WriteLine("Введите целое число -> ");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
System.Console.WriteLine("Квадрат числа --> " + result);

// Дополнительный оператор ветвления

if (num > 0)
{
    System.Console.WriteLine("Вы ввели положительное число");

}
else if (num == 0)
    System.Console.WriteLine("Вы ввели Ноль");
else
    System.Console.WriteLine("Вы ввели отрицательное число ");