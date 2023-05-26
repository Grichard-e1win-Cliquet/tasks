Console.Clear();

Console.WriteLine("Enter five digits number: ");

int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
string x = Convert.ToString(a);
if (Math.Abs(a)>9999 & Math.Abs(a)<99999)
{
    if (x[0]==x[4] & x[1]==x[3]) Console.WriteLine($"Number {x} is a polyndrom.");
    else Console.WriteLine($"Number {x} is not a polyndrom.");
}
else Console.WriteLine($"Number {x} isn't five digits number.");