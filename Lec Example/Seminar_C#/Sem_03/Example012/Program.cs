//напишите программу, которая принимает на вход координаты точки (x,y),  
// причем х не равно 0 и y не равно 0 и выдает номер четверти плоскости 
// в которой находится эта точка

Console.Clear();

System.Console.Write("x --> ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.Write("y --> ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) System.Console.WriteLine(" 1 quarter");
else if (x < 0 && y > 0) System.Console.WriteLine(" 2 quarter");
else if (x < 0 && y < 0) System.Console.WriteLine(" 3 quarter");
else if (x > 0 && y < 0) System.Console.WriteLine(" 4 quarter");
else System.Console.WriteLine("Точка находится на координатной оси");