// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// int TurnNumber(int num)     // эта функция верна кроме "2"
// {
//     int result = 0;
//     while (num > 0)
//     {
//         result = num % 2;
//         System.Console.Write(result);
//         num = num / 2;
//     }
//     System.Console.WriteLine();
//     return result;
// }


string Delenie(int a)
{
    string result = String.Empty;
    int temp = 0;
    for (int i = a; i > 0; i/=2)
    {
        temp = i%2;
        result = temp + result;
    }

    return result;
}


Console.Clear();

System.Console.WriteLine("--> ");
int number = Convert.ToInt32(Console.ReadLine());

// TurnNumber(number);

//System.Console.WriteLine(TurnNumber(number));



string b = Delenie(number);
Console.WriteLine(b);