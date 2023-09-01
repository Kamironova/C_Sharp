// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray(int userNumber, int min, int max)
{  
    System.Console.Write("[ ");
    int[] array = new int[userNumber];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
        System.Console.Write($"{array[i]} ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
    return array;
}

void ArrayToSum(int[] array1)
{
    int sumN = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (i % 2 != 0)
        {
            sumN = sumN + array1[i];
        }
    }
    System.Console.WriteLine(sumN);
}

Console.Clear();

System.Console.WriteLine("Кол-во элементов массива и его Min/Max --> ");
int userNum = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = GetRandomArray(userNum, min, max);
ArrayToSum(newArray);

