// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// Комментарий: эту задачу можно решить 2 способами:
// 1) менять числа местами в исходном массиве;
// 2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.

int[] GetRandomArray(int number, int min, int max)
{
    int[] array1 = new int[number];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(min, max);
    }
    return array1;
}

void PrintArray(int[] arrayPrint)
{  
    System.Console.Write("[ ");
    for (int i = 0; i < arrayPrint.Length; i++)
    {
        System.Console.Write($"{arrayPrint[i]} ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

int[] ArrayToChange(int[] changeArray, int number)
{
    int[] newArray = new int[number];
    for (int i = 0; i < changeArray.Length; i++)
    {
        newArray[i] = changeArray[changeArray.Length - 1-i];
    }
    return newArray;
}




Console.Clear();

System.Console.WriteLine("Количество элементов и Min/Max массива --> ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] array = GetRandomArray(userNumber, min, max);
PrintArray(array);
PrintArray(ArrayToChange(array, userNumber));
