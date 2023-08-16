// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void FillArray(int[] array) // функция генерирует массив
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10);
    }
}

void PrintArray(int[] array)   // Функция печатает сгенерированный массив
{
    foreach (var item in array) // item  переберает каждый элемент массива
    {
        System.Console.Write($"[{item}]");
    }
    System.Console.WriteLine();
}

int[] SumArray(int[] array)
{
    int[] result = new int[array.Length /2 + array.Length % 2];
    //int j = array.Length -1;
    
    for (int i = 0; i < array.Length/2; i++)
    {
        result[i] = array[i] * array[array.Length - 1-i]; // или array[j -1]
        
        //System.Console.Write($"[{result[i]}]");
    }
    if (array.Length % 2 != 0)
    {
        result[^1] = array[array.Length /2];  // [^1] -- обращение к последнему элементу нового массива
    }
    //System.Console.WriteLine();
    return result;
}



Console.Clear();

System.Console.WriteLine("Введите размер массива --> ");
int n = Convert.ToInt32(Console.ReadLine());
    
int[] array = new int[n];

FillArray(array);
PrintArray(array);
PrintArray(SumArray(array));


