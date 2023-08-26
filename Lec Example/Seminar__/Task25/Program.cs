// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Product(int numberA, int numberB)
{
    int result = 1;

    for (int count = 1; count <= numberB; count++)
    {
        result = result * numberA;
    }
    return result;
}


Console.Clear();

System.Console.WriteLine("Введите два числа --> ");
int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Product(numA, numB));
