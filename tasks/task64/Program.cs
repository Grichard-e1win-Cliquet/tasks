Console.Clear();

Console.Write("Enter a number: ");

int N = int.Parse(Console.ReadLine());
naturals(N);
void naturals(int n)
{
    if(n == 0) return;
    Console.Write($"{n} ");
    naturals(n-1);
}
Console.WriteLine();