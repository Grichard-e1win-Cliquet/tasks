Console.Clear();

Console.WriteLine("Enter a number: ");
int num = int.Parse(Console.ReadLine());

d(num);

int d(int n)
{
    if(n % 2 == 0) return 0;
    else return 1;
}

for (int i = num; i > 0; i/=2)
{
    Console.WriteLine($"d({i}) = {d(i)}");
}