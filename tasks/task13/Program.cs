Console.Clear();
Console.WriteLine("Enter a number:");

int x = Convert.ToInt32(Console.ReadLine());
string y = Convert.ToString(x);
if (Math.Abs(x) > 99)
{
    Console.WriteLine($"The third digit from {x} is {y[2]}.");
}
else
{
    Console.WriteLine($"{x} has not a third digit.");
}