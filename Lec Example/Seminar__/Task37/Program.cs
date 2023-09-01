// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetRandomArray(int userNum)
{
    
    int[] array = new int[userNum];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void PrintArray(int[] array)   
{  
    System.Console.Write("[ ");
    foreach (var item in array) 
    {
        System.Console.Write($"{item} ");

    }
    System.Console.WriteLine("]");
    System.Console.WriteLine();
}


int[] ProdArray(int[] array)
{
    int[] result = new int[array.Length /2 + array.Length % 2];

    for (int i = 0; i < array.Length/2; i++)
    {
        result[i] = array[i] * array[array.Length - 1-i]; 
    }
    if (array.Length % 2 != 0)
    {
        result[^1] = array[array.Length /2];  
        
    }
    return result;
}


Console.Clear();

System.Console.WriteLine("Введите количество элементов массива --> ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int[] array = GetRandomArray(userNumber);
PrintArray(array);
PrintArray(ProdArray(array));