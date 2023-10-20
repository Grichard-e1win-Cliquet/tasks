Console.Clear();

Console.Write("Enter a number: ");
int num = int.Parse(Console.ReadLine());

int d(int n)
{
    if(n % 2 == 0) return 0;
    else return 1;
}

for (int i = num; i > 0; i/=2)
{
    Console.WriteLine($"d({i}) = {d(i)}");
}

void BinaryView(int number)
{
    if(number == 0)
    {
        Console.Write($"Binary number from {num} equals ");
        return;
    }
    BinaryView(number/2);
    Console.Write(number%2);
}

BinaryView(num);
Console.WriteLine();