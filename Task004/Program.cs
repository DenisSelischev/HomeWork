int a = 1;
Console.Write("Number: ");
int b = Convert.ToInt32(Console.ReadLine());

for (int c = a; c <= b; c++)
{
    if (c % 2 == 0)
    {
        Console.Write(c + " ");
    }
}
Console.ReadLine();