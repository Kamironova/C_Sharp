// Напишите программу, которая принимает на вход три числа 
// и проверяет, может ли существовать треугольник с сторонами такой длины.



//a+b>C и b+c>a и a+c>b.

int[] FillArray(int a, int b, int c)
{
    int[] array = new int[3];
    array[0] = a;
    array[1] = b;
    array[2] = c;
    return array;
}
void Triangle(int[] array)
{
    if (array[0] + array[1] > array[2] 
    && array[1] + array[2] > array[0] 
    && array[0] + array[2] > array[1])
    {
        System.Console.WriteLine($"Могут быть сторонами треугольника");
    }
    else
    {
        System.Console.WriteLine($"Не могут быть сторонами треугольника");
    }
    
}



Console.Clear();

System.Console.WriteLine("Введите три числа --> ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 + num2 > num3 
// && num2 + num3 > num1 
// && num1 + num3 > num2)
// {
//     System.Console.WriteLine($"{num1}, {num2} и {num3} могут быть сторонами треугольника");
// }
// else
// {
//     System.Console.WriteLine($"{num1}, {num2} и {num3} не могут быть сторонами треугольника");
// }
int[] triArray = FillArray(num1, num2, num3);
Triangle(triArray);