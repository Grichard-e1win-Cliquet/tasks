Console.Clear();

Console.WriteLine("Enter a two natural numbers: ");
Console.Write("Enter A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Enter B: ");
int B = int.Parse(Console.ReadLine());

int count = A;
numbers(A,B);

void numbers(int a, int b)
{
    if(b == 1) 
    {
        Console.WriteLine($"{A} in pow {B} equals {count}. ");
        return;
    }
    count = count*a;
    numbers(a, b -1);
}