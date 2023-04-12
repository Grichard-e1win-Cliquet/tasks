Console.Clear();

Console.WriteLine("Enter three numbers. ");

Console.Write("Enter a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter c = ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine($"max equals {max}");