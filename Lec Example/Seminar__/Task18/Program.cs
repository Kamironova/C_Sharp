// Задача 18. Напишите программу, которая по заданному номеру четверти,
// показывавет диапазо возможных координат точек в этой чветрверти(x,y)


Console.Clear();

System.Console.WriteLine("Введите номер четрвети --> ");
int q = Convert.ToInt32(Console.ReadLine());
if (q == 1) Console.WriteLine("x > 0 && y > 0");
else if (q == 2) Console.WriteLine("x < 0 && y > 0");
else if (q == 3) Console.WriteLine("x < 0 && y < 0");
else if (q == 4) Console.WriteLine("x > 0 && y < 0 ");
else if (q > 4) System.Console.WriteLine("Введите число от 1 до 4");
