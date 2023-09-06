// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


void GetArray(double[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rand.Next(-9, 10) + rand.NextDouble();
            System.Console.Write($"{Math.Round(array[i, j],1)}    ");
            
        }
        System.Console.WriteLine();
    }
}

Console.Clear();

System.Console.WriteLine("--> ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m,n];

GetArray(array);


