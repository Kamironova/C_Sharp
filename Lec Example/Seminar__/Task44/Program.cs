﻿// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8



void Fibonacci (int number)
{
    int[] array = new int[number];
   array[0] = 0;
   array[1] = 1;
   System.Console.Write($"{array[0]} {array[1]} ");
   for (int i = 2; i < array.Length; i++)
   {
        array[i] = array[i-1] + array[i-2];
        System.Console.Write($"{array[i]} ");
       
   }
   System.Console.WriteLine();
}

Console.Clear();

System.Console.WriteLine("--> ");
int num = Convert.ToInt32(Console.ReadLine());


Fibonacci(num);
