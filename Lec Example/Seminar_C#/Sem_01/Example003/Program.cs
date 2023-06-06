// Напишите программу, которая будет выдавать название дня
// недели по заданному номеру
// Например:
// 3. -> Среда;
// 5. -> Пятница.


Console.Clear();

System.Console.WriteLine("Введите число -> ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 1)
{
    System.Console.WriteLine($"{a} -> Понедельник");
}
else if (a == 2)
{
    System.Console.WriteLine($"{a} -> Вторник");
}
else if(a == 3)
{
    System.Console.WriteLine($"{a} -> Среда");
}
else if (a == 4)
{
    System.Console.WriteLine($"{a} -> Четверг");
}
else if (a == 5)
{
    System.Console.WriteLine($"{a} -> Пятница");
}
else if (a == 6)
{
    System.Console.WriteLine($"{a} -> Суббота");
}
else if (a == 7)
{
    System.Console.WriteLine($"{a} -> Воскресенье");
}
else 
{
    System.Console.WriteLine("Не соответствует дням недели");
}

// Второй вариант

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// switch (a)  
// {
//     case 1:
//     Console.WriteLine("Понедельник");
//     break;

//     case 2:
//     Console.WriteLine("Вторник");
//     break;

//     case 3:
//     Console.WriteLine("Среда");
//     break;

//     case 4:
//     Console.WriteLine("Четверг");
//     break;

//     case 5:
//     Console.WriteLine("Пятница");
//     break;

//     case 6:
//     Console.WriteLine("Суббота");
//     break;

//     case 7:
//     Console.WriteLine("Воскресенье");
//     break;

//     default :
//     Console.WriteLine("Введите число 1-7");
//     break;
// }


// Третий вариант:

// System.Console.WriteLine("--> ");
// int a = Convert.ToInt32(Console.ReadLine());


// System.Console.WriteLine((DayOfWeek)a);