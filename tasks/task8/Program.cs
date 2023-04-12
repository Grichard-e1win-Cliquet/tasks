Console.Clear();

Console.Write("Enter a number: ");

int x = Convert.ToInt32(Console.ReadLine());

if (x > 1)
{
    for (int i=2; i < x + 1; i+=2)
    {
    // Console.Write($"{i},");
    Console.Write(i+" ");
    }
Console.WriteLine();
}
else if (x < -1)
{
    for (int i=-2; i > x -1; i+=-2)
    {
    // Console.Write($"{i},");
    Console.Write(i+" ");
    }
}
else
{
    Console.Write($"There is no even numbers from 1 to {x}");
}
Console.WriteLine();