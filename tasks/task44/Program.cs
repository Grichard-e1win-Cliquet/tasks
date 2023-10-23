Console.Clear();

Console.Write("Enter a quantity of numbers Fibonacci: ");
int quantity = int.Parse(Console.ReadLine());

void FillArray(int length)
{
    int [] arr = new int [length];

    if(length >= 2)
    {
            arr [0] = 0;
            arr [1] = 1;
        Console.Write($"{arr[0]}, {arr[1]}, ");

    for(int i = 2; i < arr.Length; i++)
    {
        arr [i] = arr[i-1] + arr[i-2];
        Console.Write($"{arr[i]}, ");

    }
    }
    else 
    {
        arr [0] = 0;
        Console.Write($"{arr[0]} ");
    }
}

FillArray(quantity);
Console.WriteLine();

// for(i=0; i<quantity;i++)
// {
//     int j = i +
//     Console.Write($"")
// }