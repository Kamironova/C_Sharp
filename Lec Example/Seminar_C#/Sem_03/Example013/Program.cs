// Задача 18. Напишите программу, которая по заданному номеру четверти,
// показывавет диапазо возможных координат точек в этой чветрверти(x,y)


// void Koord(int q)
// {
//     if (q == 1) result = "x > 0 && y > 0");
//     else if (q == 2) result = "x < 0 && y > 0");
//     else if (q == 3) result = "x < 0 && y < 0");
//     else if (q == 4) result = "x > 0 && y < 0 ");
//     else if (q > 4) System.Console.WriteLine("Введите число от 1 до 4");
// };


string Koord2(int q)
{
    string result = string.Empty;
    if (q == 1) result = "x > 0 && y > 0";
    else if (q == 2) result = "x < 0 && y > 0";
    else if (q == 3) result = "x < 0 && y < 0";
    else if (q == 4) result = "x > 0 && y < 0 ";
    else if (q > 4) result = "Введите число от 1 до 4";
    return result;
}


Console.Clear();

System.Console.WriteLine("Введите номер четрвети --> ");
int q = Convert.ToInt32(Console.ReadLine());

//Koord(q);
Koord2(q);
System.Console.WriteLine($"{Koord2(q)}");



// if (q == 1)
// {  
//     result = "x > 0 && y > 0");
// }
// else if (q == 2)
// {
//     result = "x < 0 && y > 0");
// }
// else if (q == 3)
// {
//     result = "x < 0 && y < 0");
// }
// else if (q == 4)
// {
//     result = "x > 0 && y < 0 ");
// }
// else if (q >4)
// {
//     System.Console.WriteLine("Введите число от 1 до 4");
// }
