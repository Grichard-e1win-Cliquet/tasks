Console.Clear();
Console.WriteLine("Enter a three-digits number: ");
int x = Convert.ToInt32(Console.ReadLine());
if(-99 > x || x > 99)
{
    Console.WriteLine($"Last digit is {x%10}");
}
else
{
    Console.WriteLine("Three-digits number, punk");
}