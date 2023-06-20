// Задача 19. Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
//Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Pall(int[] array)
// {
//     if (array[0] == array[4] && array[1] == array[3])
//     {
//         System.Console.WriteLine($"Число является палиндромом");
//     }
//     else
//     {
//         System.Console.WriteLine($"число не является палиндромом");
//     }
// }


// НЕ ПОЛУЧАЕТСЯ РЕШИТЬ НЕ ПОНИМАЮ ЧТО НЕ ТАК


Console.Clear();

System.Console.WriteLine("Введите пятизначное число --> ");
int x = Convert.ToInt32(Console.ReadLine()!);

int[] array = { x };

//int index = array.Length;
if (array[0] == array[3] && array[1] == array[3])
{
    System.Console.WriteLine($"Число является палиндромом");
}
else
{
    System.Console.WriteLine($"число не является палиндромом");
}

//Pall(array);



