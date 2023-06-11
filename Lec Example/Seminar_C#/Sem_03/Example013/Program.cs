// Задача 18. Напишите программу, которая по заданному номеру четверти,
// показывавет диапазо возможных координат точек в этой чветрверти(x,y)
void Koord(int q)
{
    if (q == 1) System.Console.WriteLine($"{q} находится в диапазоне: x > 0 && y > 0");
    else if (q == 2) System.Console.WriteLine($"{q} находится в диапазоне: x < 0 && y > 0");
    else if (q == 3) System.Console.WriteLine($"{q} находится в диапазоне: x < 0 && y < 0");
    else if (q == 4) System.Console.WriteLine($"{q} Находится в диапазоне: x > 0 && y < 0 ");
    else if (q > 4) System.Console.WriteLine("Введите число от 1 до 4");
};




Console.Clear();

System.Console.WriteLine("Введите номер четрвети --> ");
int q = Convert.ToInt32(Console.ReadLine());

Koord(q);

// if (q == 1)
// {  
//     System.Console.WriteLine($"{q} находится в диапазоне: x > 0 && y > 0");
// }
// else if (q == 2)
// {
//     System.Console.WriteLine($"{q} находится в диапазоне: x < 0 && y > 0");
// }
// else if (q == 3)
// {
//     System.Console.WriteLine($"{q} находится в диапазоне: x < 0 && y < 0");
// }
// else if (q == 4)
// {
//     System.Console.WriteLine($"{q} Находится в диапазоне: x > 0 && y < 0 ");
// }
// else if (q >4)
// {
//     System.Console.WriteLine("Введите число от 1 до 4");
// }


// if (x > 0 && y > 0) System.Console.WriteLine(" 1 quarter");
// else if (x < 0 && y > 0) System.Console.WriteLine(" 2 quarter");
// else if (x < 0 && y < 0) System.Console.WriteLine(" 3 quarter");
// else if (x > 0 && y < 0) System.Console.WriteLine(" 4 quarter");
// else System.Console.WriteLine("Точка находится на координатной оси")