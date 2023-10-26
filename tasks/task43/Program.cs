Console.Clear();

Console.WriteLine("Lets check a point of crossed lines, when first line is 'y = k1 * x + b1', second is 'y = k2 * x + b2'!");

Console.Write("Enter b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Enter k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Enter b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.Write("Enter k2: ");
double k2 = double.Parse(Console.ReadLine());

void crossed(double i1, double j1, double i2, double j2)
{
    if (j1 == j2)
    {
        Console.WriteLine($"The lines lay over.");
    }
    else
    {
        if (j1 *(-1) - j2* (-1) > 0 || j1 *(-1) - j2 * (-1) < 0)
        {    
            double y = ((j1*i2)-(j2*i1))/(j1-j2);
            double x = (y - i1)/j1;
            
            Console.WriteLine($"The point of cross is ({x:f2}, {y:f2}). ");
        }
    }
}
crossed(b1, k1, b2, k2);