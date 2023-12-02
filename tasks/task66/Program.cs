// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.WriteLine("Enter a diaposone. ");

Console.Write("Enter a M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Enter a N: ");
int N = int.Parse(Console.ReadLine());

int sum = 0;

naturals(M,N);

void naturals(int m, int n)
{
    if(m > n) 
    {
        Console.WriteLine($"The summary natural numbers from {M} to {N} equals {sum}. ");
        return;
    }    
    sum+=m;
    naturals(m+1,n);
}
Console.WriteLine();