// Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int ProductOfNumber(int number)
{
    int product = 1;
    while (number != 0)
    {
        product = product * number; // или product *= number;
        number--;
    }

    return product;
}

Console.Clear();

System.Console.WriteLine("--> ");
int userNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(ProductOfNumber(userNumber));
