// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
Console.WriteLine("____________________________________________");
Console.WriteLine();

int [,] sort(int [,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1);j++)
        {
            int maxPosition = j;
            for (int t = j + 1; t < arr.GetLength(1); t++)
            {
                if(arr[i,t] > arr[i, maxPosition]) maxPosition = t;
            }

        int temp = arr[i, j];
        arr[i, j] = arr[i, maxPosition];
        arr[i, maxPosition] = temp;
        }
    }
    return arr;
}

sort(massive);

Console.WriteLine();

PrintArray(massive);