int a = 7;
int b = 9;
int c = 13;
int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;

Console.WriteLine("max = ");
Console.WriteLine(max);