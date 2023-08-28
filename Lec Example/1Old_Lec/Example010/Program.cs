// Имеется одномернвый массив array из n  эллементов, требуется найти 
// эллемет массива равный find

System.Console.Clear();

int[] array = {11, 22, 33, 44, 55, 66, 77, 88, 99};

int n = array.Length;
int find = 99;

int index = 0;

while (index < n)
{
    if (array [index] == find)
    {
        System.Console.WriteLine(index);
        break; // этот оператор прерывает поиск в случае если найдет значение( иначе он может найти второе такое же)
    }
    index++;
}