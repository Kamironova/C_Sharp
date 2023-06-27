// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да




void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write($"[{item}] ");
    }
    System.Console.WriteLine();
}


bool Find(int[] array, int n)
{
    bool nPresent = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == n)
        {
            nPresent = true;
        }

    }
    return nPresent;
}






Console.Clear();

System.Console.WriteLine("Введите число --> ");
int n = int.Parse(Console.ReadLine()!);


int[] array = new int[4];
FillArray(array);
PrintArray(array);
Find(array, n);
System.Console.WriteLine(Find(array, n));