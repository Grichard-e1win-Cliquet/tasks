// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

int [,,] A = enterArr();

int [,,] enterArr()
{
    int line = new Random().Next(1, 5);
    int con = new Random().Next(1, 5);
    int list = new Random().Next(1,5);

    int [,,] array = new int [line, con, list];
    int[] check = new int[line*con*list];

    for(int t=0;t<check.Length;t++)
    {
        check[t] = new Random().Next(10, 100);
    }
    int temp = 0;
    for(int s=0;s<check.Length-1;s++)
    {
        temp = check[s];
        for(int b = s+1; b<check.Length;b++)
        {
            if(temp == check[b])
            {
                check[b] = new Random().Next(10, 100);
                b = 0;
                s = 0;
            }
        } 
    }
    PrintArr(check);

    int x = 0;
    for(int k = 0; k < array.GetLength(2); k++)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j,k] = check[x];
                x++;
            }
        }
    }
    return array;
}

void PrintArray(int [,,] arr)
{
    for(int k = 0; k < arr.GetLength(2); k++)
    {
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("| ");

        for(int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr [i, j,k]}({i},{j},{k}) ");
            }
            Console.WriteLine("|");
        }
    }
}

PrintArray(A);
Console.WriteLine("________________________________");
Console.WriteLine();

void PrintArr(int [] arr)
{
    Console.Write("[ ");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr [i]} ");
    }
    Console.WriteLine("]");
}