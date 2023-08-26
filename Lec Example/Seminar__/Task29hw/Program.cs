// Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int[] FillArray(int collection)
{
    int[] array = new int[collection];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}



void PrintArray(int[] arrayToPrint)
{
    System.Console.Write("[ ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        System.Console.Write($"{arrayToPrint[i]} ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

Console.Clear();

System.Console.Write("Введите количество элементов массива -->");
int userNumber = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(userNumber);
PrintArray(array);