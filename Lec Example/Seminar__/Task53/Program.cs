// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

int[,] GetRandom2DArray(int row, int col)
{
    int[,] randArray = new int[row, col];
    for (int i = 0; i < randArray.GetLength(0); i++)
    {
        for (int j = 0; j < randArray.GetLength(1); j++)
        {
            randArray[i,j] = new Random().Next(1,10);
        }
    }
    return randArray;
}

void Print2DArray(int[,] array)
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
            System.Console.Write($"{array[i,j]}\t");
        }
        System.Console.WriteLine();
    }

}

int[,] StringArray(int[,] newArray)
{  
    int rows = newArray.GetLength(0);
    int cols = newArray.GetLength(1);
    int temp = 0;
    for (int i = 0; i < cols; i++)
    {
        temp = newArray[0,i];
        newArray[0,i] = newArray[rows-1,i];
        newArray[rows-1,i] = temp;
    }
    return newArray;
}


Console.Clear();

System.Console.Write("Enter row --> ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter column --> ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] userArray = GetRandom2DArray(m,n);
Print2DArray(userArray);
System.Console.WriteLine();
int[,] newArray = StringArray(userArray);
Print2DArray(newArray);

