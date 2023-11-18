// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int [,] massive = enterArr();

int [,] enterArr()
{
    int [,] array = new int [4, 4];
    int dig = 1;
    int i = 0;
    int j = 0;

    while(dig <= array.GetLength(0)*array.GetLength(1))
    {
        array[i,j] = dig;
        dig+=1;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)     j++;
    else if (i < j && i + j >= array.GetLength(0) - 1)    i++;
    else if (i >= j && i + j > array.GetLength(1) - 1)    j--;
    else                                                        i--;
    }
    return array;
}


void PrintArray(int [,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("|  ");

        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i,j]/10 == 0)
            {
                Console.Write($"({arr [i, j]})  ");
            }
            else Console.Write($"({arr [i, j]}) ");
        }
        Console.WriteLine("|");
    }
}

PrintArray(massive);
Console.WriteLine("____________________________________________");
Console.WriteLine();