// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetRandomArray()
{
    int[] array = new int[123];
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        System.Console.Write($"{array[i]} ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
    return array;
}

int FindNumber(int[] prodArray)
{
    int result = 0;
    for (int i = 0; i < prodArray.Length; i++)
    {
        
        if (prodArray[i] >= 10 && prodArray[i] <= 99)
        {
            result += 1;
        }
    }
    return result; 
}


Console.Clear();

int[] array = GetRandomArray();
System.Console.WriteLine(FindNumber(array));

