Console.Clear();

Console.WriteLine("Enter two numbers. ");

Console.Write("Enter a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b = ");
int b = Convert.ToInt32(Console.ReadLine());

if (a%b == 0)
    {
        Console.Write($"The {a} is a multiple of {b}.");
    }
else
    {
        Console.Write($"The {a} is not a multiple of {b}. The remainder equals {a%b}.");
    }
Console.WriteLine();