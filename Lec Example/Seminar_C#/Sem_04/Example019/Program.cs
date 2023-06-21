﻿// Задача 30. Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и еденицами в случайном порядке
// [1, 0, 1, 1, 0, 1, 0, 0]



void FillArray(int[] collection)     // метод для генерации случайных чисел
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] col)    // метод для печати сгенерированных случайных чисел
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]},");
        position++;
    }
}



Console.Clear();

int[] array = new int[8];

FillArray(array);
PrintArray(array);

