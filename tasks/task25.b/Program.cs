Console.Clear();

Console.WriteLine("Enter two numbers.");

Console.WriteLine("Enter A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter B:");
int B = Convert.ToInt32(Console.ReadLine());
Console.Clear();
double C = P(A, B);

double P(int x, int y)
{
    double P = x;
    if(y == 0)
{
    P = 1;
    return P;
}
else
{
    if(y > 0)
    {
        for(int count = 1; count < y; count++)
        {
        P = P*x;
        }
        return P;
    }
    else
    {
        for(int count = 1; count < Math.Abs(y); count++)
        {
        P = P*x;
        }
        P = 1/P;
        return P;
    }   
    return P;
}
return P;
}

Console.Write($"{A} to degree {B} equals {C}.");
Console.WriteLine();