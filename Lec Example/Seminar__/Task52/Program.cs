// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] GetRandomArray(int r, int c)
{
    int[,] array = new int[r,c];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
    return array;
}

void ArithmeticMean(int[,] array, int r, int c)
{  
    for (int j = 0; j < array.GetLength(1); j++)
    {  
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        System.Console.Write($"{Math.Round(sum / array.GetLength(0), 2)}; ");
    }
    System.Console.WriteLine();
}



Console.Clear();

System.Console.Write("Количество строк --> ");
int row = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Количество столбцов --> ");
int column = Convert.ToInt32(Console.ReadLine());



ArithmeticMean(GetRandomArray(row,column), row-1, column-1);
