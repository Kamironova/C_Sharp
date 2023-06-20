// Звдача 21. Напишите программу, которая принимае на вход координаты
// двух точек в 2D пространстве.
// Например:
// A(3,6); B(2,1) --> 5,09
// A(7,5); B(1,-1) --> 7,21

Console.Clear();

System.Console.WriteLine("Введите координату x1 --> ");
double x1 = double.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите координату x2 --> ");
double x2 = double.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите координату y1 --> ");
double y1 = double.Parse(Console.ReadLine()!);

System.Console.WriteLine("Введите координату y2 --> ");
double y2 = double.Parse(Console.ReadLine()!);

double dist = Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1)));
System.Console.WriteLine(dist);