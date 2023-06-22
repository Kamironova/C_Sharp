//Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна -20.

void FillArray(int[] array) // функция генерирует массив
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }   
}

void PrintArray(int[] array)   // Функция печатает сгенерированный массив
{
    foreach (var item in array) // item  переберает каждый элемент массива
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

void FindSum (int[] array)
{
    int sumP = 0;
    int sumN = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]> 0)
        {
            sumP+=array[i];
        }
        else
        {
            sumN+=array[i];
        }
       
    }
    System.Console.WriteLine($"Сумма положительных чисел массива: {sumP}");
    System.Console.WriteLine($"Сумма положительных чисел массива; {sumN}");
}

int[] FindSum2(int[] array) // функция возвращающая массив
{
    int sumP = 0;
    int sumN = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]> 0)
        {
            sumP+=array[i];
        }
        else
        {
            sumN+=array[i];
        }
    }
    int[] result = {sumN, sumP}; // тут создали массив с результатом
    return result;
}

 
   
Console.Clear();

int[] array = new int[12];
FillArray(array);
PrintArray(array);
FindSum(array);
int[] result = FindSum2(array);
System.Console.WriteLine($"Сумма положительных чисел массива: {result[1]}");
System.Console.WriteLine($"Сумма положительных чисел массива; {result[0]}");