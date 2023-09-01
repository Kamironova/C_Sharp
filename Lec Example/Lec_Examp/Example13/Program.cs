// Создаем двумерные массивы строк и чисел

Console.Clear();

// Текст

string[,] table = new string[2,5];

//String.Empty -- инициализация пустой Строки

// table[1,2] = "A";

// for (int rows = 0; rows < 2; rows++) // перебирает строки
// {
//     for (int columns = 0; columns < 5; columns++) // перебирает столбцы
//     {
//         System.Console.Write($" -{table[rows, columns]}- ");
//     }
//  System.Console.WriteLine();

// }

// Числа



void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // 0 - это строка
    {
        for (int j = 0; j < matr.GetLength(1); j++) // 1 - это столбец
        {
            System.Console.Write($"{matr[i, j]} ");
        }
    System.Console.WriteLine();
}
}

void FillArray(int[,] matr)
{for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(1,10);
    }
}

}



int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
System.Console.WriteLine();
PrintArray(matrix);