// Напишите программу, которая на вход принимает два числа 
// и проверяет, является ли первое квадратом второго
Например:
// a=25, b=5 -> Да
// a=2, b = 10 -> Нет
// 9, -3 -> Да
// -3, 9 -> Нет


Console.Clear();

System.Console.WriteLine("Enter First Number -> ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter Second Number -> ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == (b*b))
{
    System.Console.WriteLine($"Ура {a} квадрат {b}");
}
else 
{
    System.Console.WriteLine("Не квадрат");
}


// Второй вариант

// Console.WriteLine("Enter first nuber: ");
// string? str = Console.ReadLine();
// int firstNumber = int.Parse(str);

// Console.WriteLine("Enter second nuber: ");
// str = Console.ReadLine();
// int secondNumber = int.Parse(str);

// if ((Math.Pow(secondNumber, 2)) == firstNumber)  // эта команда возводит в квадрат
// {
//     Console.WriteLine("Второе число является квадратом первого");
// }
// else
// { 
//     Console.WriteLine("Второе число не является квадратом первого");
//}