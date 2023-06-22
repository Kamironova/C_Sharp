//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// Math.Pow юзать нельзя.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// DONE !!!!!!

// Вариант с циклом while

// int Pow(int a, int b)
// {
//     int i = 1;
//     int result = 1;

//     while (i <= b)
//     {
//         result = result * a;
//         i++;
//     }
//     return result;

// }


// Вариант с циклом for

int Pow2(int a, int b)
{
    int result = 1;

    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    return result;
}


Console.Clear();

System.Console.WriteLine("Введите число A --> ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число B --> ");
int b = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine($"{a} в степени {b} --> {Pow2(a,b)}");

