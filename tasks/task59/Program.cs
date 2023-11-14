// Pascal's triangle

Console.Clear();

Console.WriteLine("Enter quantity of lines in Pascal's trianle.");

Console.Write("Quantity of lines: ");
int lines = int.Parse(Console.ReadLine());

int [,] massive = enterArr(lines, lines*2-1);

int [,] enterArr(int line, int con)
{
    int [,] array = new int [line, con];
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = 0;
        }
    }

    for(int n = 0; n < array.GetLength(0);n++)
    {
    array[n, array.GetLength(0)-1-n] = 1;
    array[n, array.GetLength(0)-1+n] = 1;
    }

    for(int i = 2; i < array.GetLength(0); i++)
    {
        for(int j = 2; j < array.GetLength(1)-2; j++)
        {
        array [i, j] = array[i-1, j-1] + array[i-1, j+1];
        }
    }
    return array;
}

void PrintArray(int [,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine();
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i,j] != 0)
            {
            Console.Write($"{arr [i, j]} ");
            }
            else Console.Write($"  ");
        }
        Console.WriteLine();
    }
}

PrintArray(massive);
Console.WriteLine();