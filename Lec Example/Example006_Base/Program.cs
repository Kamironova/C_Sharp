int a = 2;
int b = 7;
int c = 5;
int d = 1;
int e = 3;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

System.Console.Write("Max = ");
System.Console.WriteLine(max);