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
            array [i, j] = new Random().Next(0, 10);
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
Console.WriteLine("____________________________________________");
Console.WriteLine();
int [] count(int [,] mass)
{   
    int [] counted = new int [10];

    for(int t = 0; t < 10; t++)
    {
    int count = 0;
    for(int i = 0; i < mass.GetLength(0); i++)
    {
        for(int j = 0; j < mass.GetLength(1); j++)
        {
            if(t == mass[i,j])
            {
                count+=1;
            }
        }
    }
    if(count > 0)
    {
    counted[t] = count;
    }
    }
    return counted;
}

int [] Counts = count(massive);
Print(Counts);

void Print(int [] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
            if(arr[i] > 0)
            {
                Console.WriteLine("| The " + $"\"{i}\" " + "meetings " + $"{arr [i]} times. |");
            }
    }
}