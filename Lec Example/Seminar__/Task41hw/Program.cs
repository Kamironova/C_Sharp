// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetRundom(int num)
{   
    System.Console.Write("[ ");
    int[] array = new int[num];
    for (int i = 0; i < array.Length; i++)
    {  
        array[i] = new Random().Next(-999, 1000);
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine("]");
    System.Console.WriteLine();
    return array;
}

int NumberPlus(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count ++;
        }
    }
    return count;
}


Console.Clear();

System.Console.WriteLine("--> ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int[] array = GetRundom(userNumber);
System.Console.WriteLine($"Колличество чисел больше 0 --> {NumberPlus(array)}");