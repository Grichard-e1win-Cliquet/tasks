Console.Clear();

Console.Write("Enter quantity of lines: ");
int lines = int.Parse(Console.ReadLine());

Console.Write("Enter quantity of cons: ");
int cons = int.Parse(Console.ReadLine());

int [,] massive = new int [lines, cons];

void FillArray(int [,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j<arr.GetLength(1); j++)
        {
            Console.Write($"Enter arr[{i} , {j}]: ");
            arr [i, j] = int.Parse(Console.ReadLine());
        }
    }
}

void PrintArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("| ");
        for(int j = 0; j<array.GetLength(1); j++)
        {            
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine(" |");
    }
}

FillArray(massive);
PrintArray(massive);

int sumdiag(int [,] somemassive)
{
    int [,] newarray = somemassive;
    int sum = 0;
    for(int i = 0; i < newarray.GetLength(0); i++)
    {
        for(int j = 0; j<newarray.GetLength(1); j++)
        {
            if( i == j)
            {
                sum = newarray[i, j] + sum;
            }
        }
    }
return sum;
}

int sumdiagonal = sumdiag(massive);


Console.WriteLine($"The sum of numbers in main diagonal eqals {sumdiagonal}.");