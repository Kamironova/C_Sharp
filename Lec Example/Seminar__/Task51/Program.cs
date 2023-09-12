// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной 
// диагонали (с индексами (0,0); (1;1) и т.д.


int[,] GetRandom2DArray(int row, int col)
{
    int[,] randArray = new int[row, col];
    for (int i = 0; i < randArray.GetLength(0); i++)
    {
        for (int j = 0; j < randArray.GetLength(1); j++)
        {
            randArray[i,j] = new Random().Next(1, 10);
        }
    }
    return randArray;
}

void Print2DArray(int[,] randArray)
{
    System.Console.Write($"[  ]\t");
    for (int i = 0; i < randArray.GetLength(1); i++)
    {
        System.Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < randArray.GetLength(0) ; i++)
    {
        System.Console.Write($"[{i}]\t");
        for (int j = 0; j < randArray.GetLength(1); j++)
        {
            System.Console.Write($"{randArray[i,j]}\t");
        }
        System.Console.WriteLine();
    }
}

void DiaSum(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                result += array[i,j];
            }
        }
    }
    System.Console.WriteLine(result);
}


Console.Clear();

System.Console.Write("Enter row --> ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter column --> ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] array = GetRandom2DArray(m, n);
Print2DArray(array);
DiaSum(array);

