Console.Clear();

Console.Write("Enter a number: ");

int a = Convert.ToInt32(Console.ReadLine());

if (a%2==0)
{
    Console.WriteLine($"Yes! {a} is an even number.");
}
else
{
    Console.WriteLine($"No! {a} is not an even number.");
}
