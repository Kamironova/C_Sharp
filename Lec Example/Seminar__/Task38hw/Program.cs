// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] GetRandomArray(int userNumber, int min, int max)
{  
    System.Console.Write("[ ");
    double[] array1 = new double[userNumber];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(min, max);
        System.Console.Write($"{array1[i]} ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
    return array1;
}

void ArrayDiff(double[] arrayD)
{
    double min = arrayD[0];
    double max = arrayD[0];
    for (int i = 0; i < arrayD.Length; i++)
    {
        if (arrayD[i] < min)
        {
            min = arrayD[i];
        }
        if (arrayD[i] > max)
        {
            max = arrayD[i];
        }
    }
    System.Console.WriteLine($"{max} - {min} = {max - min}");
}



Console.Clear();
System.Console.WriteLine("Кол-во элементов массива и его Min/Max -->");
int userNum = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

double[] array = GetRandomArray(userNum, min, max);
ArrayDiff(array);

