Console.Clear();

Console.WriteLine("Enter a size of double massive.");

Console.WriteLine("Enter a quantity of lines: ");
int lines = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a quantity of cons: ");
int cons = int.Parse(Console.ReadLine());

double [,] massive = new double [lines, cons];

void FillArray(double [,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i, j] = Math.Round(new Random().Next(-9, 10) + new Random().NextDouble(), 1);
        }
    }
}

void PrintArray(double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {   
        Console.Write("| ");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"({array[i, j]}) ");
        }
        Console.WriteLine(" |");
    }
}

FillArray(massive);
PrintArray(massive);

Console.WriteLine();

