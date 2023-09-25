// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int[,] FillSpirally2DArray()
{
    Console.Write("Введите кол-во столбцов: ");
    int cols = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, cols];
    int value = 1;
    // создадим границы, которые будем сужать
    int left = 0,
        right = cols - 1,
        top = 0,
        bottom = rows - 1;

    while (left <= right && top <= bottom)
    {
        // Заполнение верхней строки
        for (int i = left; i <= right; i++)
            array[top, i] = value++;
        // Заполнение правого столбца
        for (int j = top + 1; j <= bottom; j++)
            array[j, right] = value++;
        // Заполнение нижней строки
        if (top < bottom)
        {
            for (int i = right - 1; i >= left; i--)
                array[bottom, i] = value++;
        }
        // Заполнение левого столбца
        if (left < right)
        {
            for (int i = bottom - 1; i > top; i--)
                array[i, left] = value++;
        }

        left++;
        right--;
        top++;
        bottom--;
    }

    return array;
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

PrintArray(FillSpirally2DArray());