// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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
            Console.Write($"Enter [{i}, {j}]: ");
            array [i, j] = int.Parse(Console.ReadLine());
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

void mediumAr(int [,] mass)
{
    Console.Write("| ");
    
    for(int j = 0; j < mass.GetLength(1); j++)
    {
        double temp = 0;
        for(int i = 0; i < mass.GetLength(0); i++)
        {
            temp += mass[i, j];
        }
        Console.Write($"({temp/mass.GetLength(0):f2}) ");
    }
    Console.WriteLine(" |");
}

mediumAr(massive);