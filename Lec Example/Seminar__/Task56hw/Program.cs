// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetRandom2DArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void PrintArray(int[,] array)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        System.Console.Write($"[{i + 1}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"[{i + 1}]\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[] SumRowsArray(int[,] arr)
{   

    int[] sumRow = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sumRow[i] += arr[i, j];
        }
        System.Console.Write($"{sumRow[i]} ");
    }
    System.Console.WriteLine();
    return sumRow;
}

void PrintMinSum(int[] array)
{
    int min = array[0];
    int row = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if(min>array[i])
        {
            min = array[i];
            row = i;
        }
    }
    System.Console.WriteLine($"Наименьшая сумма в {row} строке равна {min}");
}

Console.Clear();

System.Console.Write("Enter row --> ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter column --> ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = GetRandom2DArray(m, n);
PrintArray(firstArray);

//SumRowsArray(firstArray);
PrintMinSum(SumRowsArray(firstArray));
