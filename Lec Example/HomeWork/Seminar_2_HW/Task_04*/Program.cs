// ДОП ЗАДАНИЕ. На входе целое число любой разрядности
// надо удалить вторую цифру (слева на право) этого числа

Console.Clear();

System.Console.WriteLine("Введите число любой разрядности --> ");
int x = int.Parse(Console.ReadLine()!);
int count = 1;

while (x >= 10)
{
    x = x/10;
    count++;
}

System.Console.WriteLine(count);

// ДОДЕЛАТЬ!!