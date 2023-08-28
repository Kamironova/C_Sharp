//ВИДЫ МЕТОДОВ

// Первый вид. 
// Метод, который не принимает данные и не возвращает

void Method1()
{
    System.Console.WriteLine("Author ...");
}
Method1();   // вызов метода


///////////


// Второй вид.
// Метод, который принимает данные, но не возвращает

void Method2(string msg) // вместо msg может быть другое
{
    System.Console.WriteLine(msg);
}
Method2("Текст сообщения");

// Или

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4);  
Method21(count: 4, msg: "Текст");  
// Можно явно указывать на аргумент, можно не указывать. 
// Но указывая можно писать в любом порядке


/////////////

// Третий вид.
// Метод, который не принимает, но  возвращает
// Если метод возвращает, то вместо void, нужно 
//указать какой типданных он возвращает

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
System.Console.WriteLine(year);


/////////////


// Четвертый вид.
// Принимает данные и возвращает данные

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;  // для начала нужно в переменной (string) указать пустую стороку
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
System.Console.WriteLine(res);
