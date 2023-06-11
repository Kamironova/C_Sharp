//напишите программу, которая принимает на вход координаты точки (x,y),  
// причем х не равно 0 и y не равно 0 и выдает номер четверти плоскости 
// в которой находится эта точка

void CheckKoord(int x, int y)
{
    if (x > 0 && y > 0) System.Console.WriteLine(" 1 quarter");
    else if (x < 0 && y > 0) System.Console.WriteLine(" 2 quarter");
    else if (x < 0 && y < 0) System.Console.WriteLine(" 3 quarter");
    else if (x > 0 && y < 0) System.Console.WriteLine(" 4 quarter");
    else System.Console.WriteLine("Точка находится на координатной оси");
}

// Или функция, которая возвращает:

int CheckKoord2(int x, int y) // возвращает значение
{
    int result = 0;
    if (x > 0 && y > 0)
        result = 1;
    else if (x < 0 && y > 0)
        result = 2;
    else if (x < 0 && y < 0)
        result = 3;
    else if (x > 0 && y < 0)
        result = 4;
    return result;
}




Console.Clear();

System.Console.Write("x --> ");
int x = Convert.ToInt32(Console.ReadLine());

System.Console.Write("y --> ");
int y = Convert.ToInt32(Console.ReadLine());

//CheckKoord(x, y);
System.Console.WriteLine($"Это четверть №{CheckKoord2(x,y)}");

// if (x > 0 && y > 0) System.Console.WriteLine(" 1 quarter");
// else if (x < 0 && y > 0) System.Console.WriteLine(" 2 quarter");
// else if (x < 0 && y < 0) System.Console.WriteLine(" 3 quarter");
// else if (x > 0 && y < 0) System.Console.WriteLine(" 4 quarter");
// else System.Console.WriteLine("Точка находится на координатной оси");