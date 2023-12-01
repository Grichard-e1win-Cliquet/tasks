Console.Clear();

Console.WriteLine("Enter a diaposone of natural numbers: ");
Console.Write("Enter \"from\": ");
int M = int.Parse(Console.ReadLine());
Console.Write("Enter \"to\": ");
int N = int.Parse(Console.ReadLine());

if(M<N) numbers(M,N);
else numbers(N,M);
Console.WriteLine();

void numbers(int a, int b)
{
    if(b < a) return;
    numbers(a, b -1);
    Console.Write($"{b} ");
}