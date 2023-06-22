﻿// Задача 32. Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write($"[{item}] ");
    }
    System.Console.WriteLine();
}

void Change(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            array[i] *= -1;
            System.Console.Write($"[{array[i]}]" );
        }
        else
        {
            System.Console.Write($"[{array[i]}]" );
        }
        
    }
    System.Console.WriteLine();
}


Console.Clear();
int[] array = new int[4];
FillArray(array);
PrintArray(array);
Change(array);