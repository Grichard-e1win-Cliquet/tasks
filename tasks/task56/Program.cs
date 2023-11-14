// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int [,] massive = enterArr();

int [,] enterArr()
{
    int line = new Random().Next(2, 5);
    int S = new Random().Next(1, 5);
    if(S == line)
    {
        while(S == line)
        {
            S = new Random().Next(1, 5);
        }
    }
    int con = S;
    Console.WriteLine($"line = {line} con = {con} s={S}");

    int [,] array = new int [line, con];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"Enter the element [{i},{j}] of massive: ");
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
Console.WriteLine("____________________________________________");
Console.WriteLine();

int sum(int [,] arr)
{
    int max = 0;
    int sum = 0;
    int maxline = 0;

    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1);j++)
        {
            sum+= arr[i,j];
        }
        if(sum > max)
        {
            max = sum;
            maxline = i;
        }
    }
    return maxline;
}

Console.WriteLine($"The biggest sum in {sum(massive)} line.");