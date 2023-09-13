// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 25 9 2 38 4 2 45 2 6 7
// Наименьший элемент - 1, на выходе получим следующий массив:
// 9 4 22 2 63 4 7

int[,] GetRandom2DArray(int m, int n)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,10);
        }
    }
    return arr;
}

void PrintArray(int[,] array)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        System.Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"[{i}]\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j] +"\t");
        }
        System.Console.WriteLine();
    }

}

int FindMin(int[,] array)
{
    int min = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] <= min)
            {
                min = array[i,j];
            }
        }
    }
    return min;
}

int[,] MinDelite(int[,] array, int min)
{  
    int[,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    for (int i = 0; i < array.GetLength(0) ; i++)
    {  
        if (array[,] != min)
        {
            for (int i1 = 0; i1 < newArray.GetLength(0) ; i1++)
            {
                newArray[i1,0] = array[i,0];
            }
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {  
            if (array[0,j] != min)
            {
                for (int j1 = 0; j1 < newArray.GetLength(1); j1++)
                {
                    newArray[0,j1] = array[0,j];
                }
            }
        }
    }
    return newArray;
}

    



Console.Clear();

System.Console.Write("Enter row --> ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter column --> ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = GetRandom2DArray(m,n);
PrintArray(firstArray);
int min = FindMin(firstArray);
System.Console.WriteLine($"Минимальное занчение {min}");

PrintArray(MinDelite(firstArray, min));


// Ниже то как решали на семинаре и не дорешали

// Console.Clear();

// int[,] Get2DArray(int row, int col, int min, int max)
// {
// int[,] array = new int[row, col];
// for (int i = 0; i < row; i++)
// {
// for (int j = 0; j < col; j++)
// {
// array[i, j] = new Random().Next(min, max);
// }
// }
// return array;
// }

// void Print2DArray(int[,] arrayToPrint)
// {
// System.Console.Write($"[ ]\t");
// for (int i = 0; i < arrayToPrint.GetLength(1); i++)
// {
// Console.Write($"[{i}]\t");
// }
// System.Console.WriteLine();
// for (int i = 0; i < arrayToPrint.GetLength(0); i++)
// {
// Console.Write($"[{i}]\t");
// for (int j = 0; j < arrayToPrint.GetLength(1); j++)
// {
// System.Console.Write(arrayToPrint[i, j] + "\t");
// }
// System.Console.WriteLine();
// }
// }

// int[] CoordMinValue(int[,] array)
// {
// int[] result = new int[2];
// int min = array[0, 0];
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// if (array[i, j] < min)
// {
// min = array[i, j];
// result[0] = i;
// result[1] = j;
// }
// }
// }
// return result;
// }

// int[,] FillZero(int[,] array)
// {
// int[] coords = CoordMinValue(array);
// for (int i = 0; i < array.GetLength(0); i++)
// {
// array[coords[0], i] = 0;
// }
// for (int i = 0; i < array.GetLength(1); i++)
// {
// array[i, coords[1]] = 0;
// }
// return array;
// }

// int[,] DeleteCross(int[,] array)
// {
// int rows = array.GetLength(0) - 1;
// int cols = array.GetLength(1) - 1;
// int[,] result = new int[rows, cols];
// for (int row = 0; row < rows + 1; row++)
// {
// for (int col = 0; col < cols + 1; col++)
// {
// if (array[row, col] != 0)
// {
// result[row, col] = array[row, col];
// }

// }
// }
// return result;
// }

// int[,] arr = Get2DArray(7, 7, 1, 10);
// Print2DArray(arr);

// System.Console.WriteLine();

// int[,] arr2 = FillZero(arr);
// Print2DArray(arr2);

// System.Console.WriteLine();

// int[,] arr3 = DeleteCross(arr2);
// Print2DArray(arr3);