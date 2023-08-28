// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.

Console.Clear();

System.Console.WriteLine("--> ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int result = 0;

if (userNumber<0)
{
    userNumber = userNumber * (-1);
}

for (int i = 1; i <= userNumber; i++)
{
    result += i;
}

System.Console.WriteLine($"Сумма чисел {userNumber} равна {result}");