// Напишите программу, которая будет выдавать название дня
// недели по заданному номеру
// Например:
// 3. -> Среда;
// 5. -> Пятница.


Console.Clear();

System.Console.WriteLine("Введите число --> ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    System.Console.WriteLine("Понедельник");
}
else if (number == 2)
{
    System.Console.WriteLine("Вторник");
}
else if (number == 3)
{
    System.Console.WriteLine("Среда");
}
else if (number == 4)
{
    System.Console.WriteLine("Четверг");
}
else if (number == 5)
{
    System.Console.WriteLine("Пятница");
}
else if (number == 6)
{
    System.Console.WriteLine("Суббота");
}
else if (number == 7)
{
    System.Console.WriteLine("Воскресенье");
}
else
{
    System.Console.WriteLine("Введите число от 1 до 7");
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