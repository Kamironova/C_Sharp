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
    int[] sumArray = new int[arr.GetLength(0)];
    int sum = 0;
    int index = 0;
    for (int k = 0; k < sumArray.Length; k++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            // sum = sum + arr[i, 0];
            // sumArray[k] = sum;
            sum = sum + arr[i, j];
            index = sum;
            sumArray[k] = index;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                // sum = sum + arr[i, j];
                // index = sum;
                // sumArray[k] = index;
            }
            //System.Console.WriteLine($"{i + 1} строка --> {sum}");
            sum = 0;
        }
        //System.Console.WriteLine($"{k + 1} строка --> {sum}");
    }

    return sumArray;
}

void MinSumRow(int[] sumArray)
{
    int min = 0;
    int row = 0;
    for (int i = 0; i < sumArray.Length; i++)
    {
        System.Console.Write($"{sumArray[i]}  ");
        // if (sumArray[i] > sumArray[i + 1])
        // {
        //     min = sumArray[i + 1];
        // }
        //System.Console.WriteLine($"Cтроки с наименьшей суммой элементов: {min}");
    }

    //System.Console.WriteLine($"Cтроки с наименьшей суммой элементов: {min}");
}

Console.Clear();

System.Console.Write("Enter row --> ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter column --> ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = GetRandom2DArray(m, n);
PrintArray(firstArray);

//SumRowsArray(firstArray);
MinSumRow(SumRowsArray(firstArray));
