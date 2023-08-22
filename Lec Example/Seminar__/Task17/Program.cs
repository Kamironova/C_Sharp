// Напишите программу, которая принимает на вход координаты точки (x,y),  
// причем х не равно 0 и y не равно 0 и выдает номер четверти плоскости 
// в которой находится эта точка

Console.Clear();

System.Console.WriteLine("Введите координаты X и Y -->");
int userX = Convert.ToInt32(Console.ReadLine());
int userY = Convert.ToInt32(Console.ReadLine());


if (userX > 0 && userY > 0)
{
    System.Console.WriteLine($"{userX} и {userY} находятся в 1 четверти");
}

else if (userX < 0 && userY > 0)
{
    System.Console.WriteLine($"{userX} и {userY} находятся в 2 четверти");
}

else if (userX < 0 && userY < 0)
{
    System.Console.WriteLine($"{userX} и {userY} находятся в 3 четверти");
}
else if (userX > 0 && userY < 0)
{
    System.Console.WriteLine($"{userX} и {userY} находятся в 4 четверти");
}