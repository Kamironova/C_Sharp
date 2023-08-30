// Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] GetRandomArray(int userNumber, int min, int max)
{
    int[] array = new int[userNumber];
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
        System.Console.Write($"{array[i]} ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
    return array;
}

bool FindNumber(int[] arrayToFound, int userNumber)
{
    bool num = false;
    for (int i = 0; i < arrayToFound.Length; i++)
    {
        if (arrayToFound[i] == userNumber)
        {
            num = true;
            break;
        }
        
    }
    return num;
}



Console.Clear();

System.Console.WriteLine("Введите количество элементов массива --> ");
int arrayL = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите искомое число --> ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Задайте Min значение массива --> ");
int min = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Задайте Max значение массива --> ");
int max =  Convert.ToInt32(Console.ReadLine());

int[] array = GetRandomArray(arrayL, min, max);
System.Console.WriteLine(FindNumber(array, number));