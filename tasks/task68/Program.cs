// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


Console.Clear();

Console.WriteLine("Enter a two positive numbers. ");

Console.Write("Enter a M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Enter a N: ");
int N = int.Parse(Console.ReadLine());

if (M >= 0 && N >=0) 
{
    int A = Akkermann(M,N);
    Console.WriteLine($"The Akkermann function from ({M},{N}) equals {A}. ");
}

int Akkermann(int m, int n)
{
    int AM = 0;
    if(m == 0)  
    {
        AM = n + 1;
    }
    else if(m>0 && n==0)
    {
        AM = Akkermann(m-1, 1);
    }
    else if(m>0 && n>0)
    {
        AM = Akkermann(m-1,Akkermann(m, n-1));
    }
    return AM;
}

Console.WriteLine();