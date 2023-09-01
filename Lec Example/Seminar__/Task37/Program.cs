// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetRandomArray(int userNum)
{
    System.Console.Write("[ ");
    int[] array = new int[userNum];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
        System.Console.Write($"{array[i]} ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
    return array;
}

void ProdactOfNumber(int[] prodArray) //int userNum)
{
    System.Console.Write("[ ");
    int[] newArray = new int[prodArray.Length/2 + prodArray.Length % 2];
    
    for (int i = 0; i < prodArray.Length / 2; i++)
    {
        newArray[i] = prodArray[i] * prodArray[prodArray.Length -1-i];
        System.Console.Write($"{newArray[i]} ");    
        if (prodArray.Length % 2 == 0)
        {
        newArray[^1] = prodArray[prodArray.Length / 2];
        System.Console.Write($"{newArray[^1]} ");
        }
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

// int[] ProdPar(int[] array)
// {
//     int [] array1 = new int 
// }


Console.Clear();

System.Console.WriteLine("Введите количество элементов массива --> ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int[] array = GetRandomArray(userNumber);
ProdactOfNumber(array); //userNumber);