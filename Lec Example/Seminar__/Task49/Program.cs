// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.


int[,] GetRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
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

int[,] ChangeArray(int[,] newArray)
{  

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                newArray[i,j] = newArray[i,j] * newArray[i,j];
            }
        }
    }
    return newArray;
}




Console.Clear();

System.Console.Write("Введиет количество строк --> ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите количество столбцов --> ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] firstArray = GetRandom2DArray(m, n);
Print2DArray(firstArray);
System.Console.WriteLine();
int[,] secondArray = ChangeArray(firstArray);
Print2DArray(secondArray);



// Print2DArray(GetRandom2DArray(m, n));
// System.Console.WriteLine();
// Print2DArray(ChangeArray(GetRandom2DArray(m,n)));