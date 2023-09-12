// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

int[,] GetRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"[{i}]\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j]+"\t");
        }
        System.Console.WriteLine();
    }
}



Console.Clear();

System.Console.Write("Введиет количество строк --> ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов --> ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = GetRandomArray(m, n);
PrintArray(array);

