Console.Clear();
Console.WriteLine("Enter two numbers. ");
Console.Write("Enter a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b = ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) Console.WriteLine($"max is {a}");
if (a == b) Console.WriteLine($"both numbers is max because it's equal {a}");
if (a < b) Console.WriteLine($"max is {b}");
