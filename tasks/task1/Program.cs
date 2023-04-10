Console.Clear();
Console.WriteLine("enter two numbers ");
Console.Write("enter the first: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("enter the second: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a == b*b)
{
    Console.WriteLine($"Yes! The {a} is a squre of {b}");
}
else
{
    Console.WriteLine($"No! The {a} is not a squre of {b}");
}
