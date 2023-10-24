Console.Clear();

Console.WriteLine("Enter how many digits you want: ");

int quantity = int.Parse(Console.ReadLine());

int [] arr (int length)
{
    int [] array = new int [length];

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Enter {i} element: ");
        array [i] = int.Parse(Console.ReadLine());
    }
    return array;
}

int [] array = arr(quantity);

Console.WriteLine();
Console.WriteLine("The massive is: " + '[' + string.Join(", ", array) + ']' + ".");
Console.WriteLine();

void CountPos(int [] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            count+=1;
        }
    }
    Console.WriteLine("The number of elements more than '0' in massive " + '[' + string.Join(", ", array) + ']' + $" equals {count}. ");
}

CountPos(array);