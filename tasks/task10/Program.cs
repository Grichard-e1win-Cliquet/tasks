Console.Clear();
Console.WriteLine("Enter a three digits number:");

// int x = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(x) > 99 & Math.Abs(x) < 1000 )
// {
//     Console.WriteLine($"The second digit from {x} is {Math.Abs(x%100/10)}.");
// }
// else
// {
//     Console.WriteLine("I SAID THREE DIGITS NUMBER, PUNK!");
// }

// int x = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int x = Convert.ToInt32(Console.ReadLine());
string y = Convert.ToString(x);
if (Math.Abs(x) > 99 & Math.Abs(x) < 1000 )
{
    Console.WriteLine($"The second digit from {x} is {y[1]}.");
}
else
{
    Console.WriteLine("I SAID THREE DIGITS NUMBER, PUNK!");
}