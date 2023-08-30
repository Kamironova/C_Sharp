// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] GetRandomArray(int userArray)
{
    System.Console.Write("[ ");
    int[] array = new int[userArray];
    for (int i = 0; i < array.Length; i++)
    {
        
        array[i] = new Random().Next(-99, 100);
        System.Console.Write($"{array[i]} ");
        
    }
    System.Console.Write("]");
    System.Console.WriteLine();
    return array;
}

void ChangeArray(int[] arrayToChange)
{
    System.Console.Write("[ ");
    for (int i = 0; i < arrayToChange.Length; i++)
    {
        
        arrayToChange[i]*= -1;
        System.Console.Write($"{arrayToChange[i]} ");
        
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}


Console.Clear();

System.Console.WriteLine("Ведите количество элементов массива --> ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = GetRandomArray(number);
ChangeArray(array);
