Console.Clear();
Console.WriteLine("Enter a number: ");
int x = Convert.ToInt32(Console.ReadLine());
// int x = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (x > 0)
{
    for (int i=-x; i < x + 1; i++)
    {
    Console.Write($"{i},");
    }
Console.WriteLine();
}
else
{

    for (int i=x; i < -x + 1; i++)
    {
    Console.Write($"{i},");
    }
Console.WriteLine();
}
