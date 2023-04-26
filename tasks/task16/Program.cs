Console.Clear();

Console.WriteLine("Enter two numbers. ");

Console.Write("Enter a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b = ");
int b = Convert.ToInt32(Console.ReadLine());

if (a*a == b || b*b == a)
    {
        Console.Write($"The one of the numbers is a square root of the other.");
    }
else
    {
        Console.Write($"No! Neither number is the square root of the other.");
    }

// if (a*a == b)
//     {
//         Console.Write($"The {b} is a square root of {a}.");
//     }
// else if (b*b == a)
//     {
//         Console.Write($"The {a} is a square root of {b}.");
//     }
// else
//     {
//         Console.Write($"No! Neither number is the square root of the other.");
//     }
Console.WriteLine();