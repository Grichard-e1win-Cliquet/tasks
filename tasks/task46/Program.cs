Console.Clear();

Console.Write("Enter the quantity of lines: ");
int lines = int.Parse(Console.ReadLine());

Console.Write("Enter the quantity of cons: ");
int cons = int.Parse(Console.ReadLine());

int [,] massive = new int [lines, cons];

void FillArray(int [,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr [i, j] = new Random().Next(-10, 11);
        }
    }
}

void PrintArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
    Console.Write("|");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine("|");
    }   
}

FillArray(massive);
PrintArray(massive);