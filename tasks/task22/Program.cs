Console.Clear();

Console.WriteLine("Enter a number. ");

int N = Convert.ToInt32(Console.ReadLine());
Console.Clear();

for (int i = 1; i <= N; i++)
{
        Console.Write($"{Math.Pow(i, 2)} ");
}
Console.WriteLine();