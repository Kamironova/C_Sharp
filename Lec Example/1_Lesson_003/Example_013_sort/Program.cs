//Упорядочить массив

int[] arr = { 1, 5, 4, 3, 2, 7, 1, 1 };
void PrintArray(int[] array)   // метод выводящий массив на экран
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    System.Console.WriteLine();
}
void SelectionSort(int[] array)  // метод, которы будет упорядочевать
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i]= array[minPosition];
        array[minPosition]= temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
