// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится 
// по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.


int[,] GetRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j;
        }
    }
    return array;
}

void Print2DArray(int[,] arrayToPrint)
{
    System.Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    System.Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            System.Console.Write(arrayToPrint[i,j] +"\t");
        }
        System.Console.WriteLine();
    }
}


Console.Clear();

System.Console.Write("Введиет количество строк --> ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов --> ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array2D = GetRandom2DArray(m,n);
Print2DArray(array2D);