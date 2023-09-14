// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] SortArray(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {  
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int x = 0; x < array.GetLength(0)-1; x++)
            {
                if (array[i,x] < array[i,x+1])
                {
                    temp = array[i,x+1];
                    array[i,x+1] = array[i,x];
                    array[i,x] = temp;    
                }
            }
        }   
    }
    return array;
}

Console.Clear();

System.Console.Write("Enter row --> ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter column --> ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = GetRandom2DArray(m,n);
PrintArray(array);
int[,] newArray = SortArray(array);
PrintArray(newArray);