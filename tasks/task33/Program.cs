Console.Clear();
Console.Write("Enter a length of massive: ");

int length = int.Parse(Console.ReadLine());

int [] FillArr(int size)
{
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9,10);
    }
    return arr;
}

int[] array = FillArr(length);
Console.WriteLine("Massive is: "+ '[' + string.Join(", ", array) + ']');

void Find (int[] arr, int finder)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if (array[i] == finder)
        {
            Console.WriteLine($"The massive has {finder}.");
            i = arr.Length;
        }
        else if(i == arr.Length - 1 && array[i] != finder )
        {
            Console.WriteLine($"The massive has not {finder}.");
        }
    }
}

Find(array, 4);