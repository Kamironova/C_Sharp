// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Line (int b1, int k1, int b2, int k2)
{  
    double x = 0;
    double y = 0;
    if (b1 == b2 && k1 == k2)
    {
        System.Console.WriteLine("Прямые совпадают");
    }
    else if (b1 == b2)
    {
        System.Console.WriteLine("Параллельны");
    }
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;

    }
    System.Console.WriteLine($"{x}; {y}");
}




Console.Clear();

System.Console.WriteLine("Координаты точек --> ");
int b1 = Convert.ToInt32(Console.ReadLine());
int k1 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());

Line(b1, k1, b2, k2);