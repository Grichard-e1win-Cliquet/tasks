Console.Clear();

Console.WriteLine("Enter a number. ");

int N = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (N>0)
{
    for (int i = 1; i <= N; i++)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
    }
}
else
{
    for (int i = 1; i >= N; i--)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
    }
}

Console.WriteLine();