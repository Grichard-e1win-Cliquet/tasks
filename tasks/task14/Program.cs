Console.Clear();

Console.WriteLine("Enter a number: ");

Console.Write("");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 7 == 0 && a % 23 == 0)
    {
        Console.Write($"The {a} is a multiple of 7 and 23.");
    }
else
    {
        Console.Write($"The {a} is not a multiple of 7 and 23.");
    }
Console.WriteLine();