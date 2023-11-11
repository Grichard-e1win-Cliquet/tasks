Console.Clear();

Console.WriteLine("Enter quantity of lines and cons.");

Console.Write("Quantity of lines: ");
int lines = int.Parse(Console.ReadLine());

Console.Write("Quantity of cons: ");
int cons = int.Parse(Console.ReadLine());

int [,] massive = enterArr(lines, cons);

int [,] enterArr(int line, int con)
{
    int [,] array = new int [line, con];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = new Random().Next(-9, 10);
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

PrintArray(massive);
Console.WriteLine();

void Swap(int [,] mass)
{   
    int i = 0;
    int temp = 0;
    
    for(int j = 0; j < mass.GetLength(1); j++)
    {
        temp = mass[i, j];
        mass [i, j] = mass [mass.GetLength(0)-1, j];
        mass [mass.GetLength(0)-1, j] = temp;
    }
    PrintArray(mass);
}

Swap(massive);