// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Не решено!!!!!!  Пока не знаю как напечатать сгенерированный массив



int ArrPrint(int[] array)
{
    int[] length = new int[8];
    //int i = 0;
    for (int i = 0; i <= 8; i++)
    {
        array[i] = new Random().Next(0, 100);
        System.Console.Write($"{array[i]} ");
    }
    return array[1];
}

void PrintArray(int[] col)    // метод для печати сгенерированных случайных чисел
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]},");
        position++;
    }
}


Console.Clear();

int[] array = new int[8];
ArrPrint(array);
PrintArray(array);








// Правильное решение! нужно адаптировать




void FillArray(int[] array) // функция генерирует массив
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
        System.Console.WriteLine(array[i]);
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



Console.Clear();

int[] array = new int[12];
FillArray(array);
PrintArray(array);


