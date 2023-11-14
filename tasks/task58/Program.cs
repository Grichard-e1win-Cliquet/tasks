// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int [,] A = enterArr();
int [,] B = enterArr();

while(A.GetLength(1) != B.GetLength(0))
{
    B = enterArr();
}

int [,] enterArr()
{
    int line = new Random().Next(1, 6);
    int con = new Random().Next(1, 6);

    int [,] array = new int [line, con];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-9, 10);
        }
    }
    return array;
}

void PrintArray(int [,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("| ");

        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"({arr [i, j]}) ");
        }
        Console.WriteLine(" |");
    }
}

PrintArray(A);
Console.WriteLine("________________________________");
Console.WriteLine();
PrintArray(B);
Console.WriteLine("________________________________");
Console.WriteLine();

int PROZ(int [,] A, int [,] B, int i, int j)
{
    int sum = 0;
    
    for(int k = i; k < i+1; k++)
    {
        for(int t = 0; t < A.GetLength(1); t++)
        {
            sum+= A[k,t]*B[t,j];
        }
    }
    return sum;
}

int [,] Multi(int [,] A, int [,] B)
{   
    int [,] C = new int [A.GetLength(0), B.GetLength(1)];
    
    for(int i = 0; i < C.GetLength(0); i++)
    {
        for(int j = 0; j < C.GetLength(1); j++)
        {
            C [i, j] = PROZ(A, B, i, j);
        }
    }
    return C;
}

int [,] C = Multi(A,B);
PrintArray(C);