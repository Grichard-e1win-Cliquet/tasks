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

int Min(int [,] arr)
{
    int min = 0;
    for(int t = 0; t < 10; t++)
    {
    min = t;

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(t == arr[i,j])
            {   
                return min;
                break;
            }
        }
    }
    }
    return min;
}

int [] koord(int [,] mass, int dig)
{   
    int [] koord = new int [2];

    for(int i = 0; i < mass.GetLength(0); i++)
    {
        for(int j = 0; j < mass.GetLength(1); j++)
        {
            if(dig == mass[i,j])
            {
                koord[0] = i;
                koord[1] = j;
                return koord;
                break;
            }
        }
    }
    return koord;
}

int [,] del(int [,] mass, int [] k, int dig)
{   
    int [,] del = new int [mass.GetLength(0)-1, mass.GetLength(1)-1];
    int d = 0; 
    int p = 0;

        for(int i = 0; i < mass.GetLength(0); i++)
        {
            if(i != k[0])
            {
                for(int j = 0; j < mass.GetLength(1); j++)
                {
                    if(j != k[1])
                    {
                        del[d, p] = mass[i, j];
                        p++;
                    }
                }
            d++;
            p = 0;
            }
        }
    return del;
}

int minimum = Min(massive);
Console.WriteLine($"Minimum number in massive is: {minimum}.");
Console.WriteLine();

int [] koordinate = koord(massive, minimum);

Console.WriteLine("Koordinate of min number in massive is " + '[' + string.Join(", ", koordinate) + ']' + ".");
Console.WriteLine();

int [,] Deleted = del(massive, koordinate, minimum);

PrintArray(Deleted);