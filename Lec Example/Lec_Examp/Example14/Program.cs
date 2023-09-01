// Закрашивание массива

Console.Clear();

int[,] pic = new int[,]  
{
    // Тут должен быть масств с картинкой из 0 и 1
}

void PrintImage(int[,] image)   // Массив который меняет 0 на пробелы и 1 на +
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i,j] == 0) System.Console.Write(" ");
            else System.Console.Write("+");
        }
        System.Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if (pic[row, col] == 0 )
    {
        pic[row, col] = 1;
        FillImage(row-1,col);
        FillImage(row,col-1);
        FillImage(row+1,col);
        FillImage(row-1,col+1);
    }
}

PrintImage(pic);