// Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна -20.


int[] GetRandomArray()
{
    int[] array = new int[12];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
    return array;
}

void SumArray(int[] arrayToSum)
{
    int sumA = 0;
    int sumB = 0;
    for (int i = 0; i < arrayToSum.Length; i++)
    {
        if (arrayToSum[i] > 0)
        {
            sumA += arrayToSum[i];
        }
        else 
        {
            sumB += arrayToSum[i];
        }
    }
    System.Console.WriteLine($" {sumA}, {sumB}");
    

}

Console.Clear();

int[] prodact = GetRandomArray();
SumArray(prodact);
