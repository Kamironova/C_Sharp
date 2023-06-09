// Выводим таблицу умножения на экран при помощи цикла в цикле

Console.Clear();

for (int i = 2; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        System.Console.WriteLine($"{i} x {j} = {i * j}");
    }
    System.Console.WriteLine();
}