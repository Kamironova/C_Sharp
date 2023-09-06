// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] GetRandomArray()
{
    int[,] array = new int[4,4];
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

void FindArray(int[,] array, int r, int c)
{
    if (r <= array.GetLength(0) && c <= array.GetLength(1))
    {
        System.Console.WriteLine($"--> {array[r,c]}");
    }
    else
    {
        System.Console.WriteLine("Значение выходит за пределы массива");
    }
}



Console.Clear();

System.Console.Write("Enter row --> ");
int row = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter column --> ");
int column = Convert.ToInt32(Console.ReadLine());


FindArray(GetRandomArray(), row-1, column-1);

