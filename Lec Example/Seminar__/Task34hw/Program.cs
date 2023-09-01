// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandomArray(int userArray)
{
    System.Console.Write("[ ");
    int[] array1 = new int[userArray];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(100, 1000);
        System.Console.Write($"{array1[i]} ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
    return array1;
}

void EvenCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }    
    }
    System.Console.WriteLine(count);
}


Console.Clear();

System.Console.WriteLine("Задайте кол-во элемнтов массива --> ");
int userNum = Convert.ToInt32(Console.ReadLine());


int[] array = GetRandomArray(userNum);

EvenCount(array);