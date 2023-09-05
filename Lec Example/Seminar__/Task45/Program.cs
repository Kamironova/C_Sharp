// Напишите программу, которая будет создавать копию 
// заданного одномерного массива с помощью поэлементного копирования.

int[] ArrayToCopy(int[] array)
{
    System.Console.Write("[ ");
    int[] copy = new int[array.Length];
    for (int i = 0; i < copy.Length; i++)
    {
        copy[i] = array[i];
        System.Console.Write($"{copy[i]} ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
    return copy;
}


Console.Clear();

int[] array = new int[10];

System.Console.Write("[ ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-99, 100);
    System.Console.Write($"{array[i]} ");
}
System.Console.WriteLine("]");

int[] copyArray = ArrayToCopy(array);