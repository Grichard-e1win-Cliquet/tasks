Console.Clear();
Console.WriteLine("Enter a length of massive. ");

int length = Convert.ToInt32(Console.ReadLine());
Console.Clear();

int[] Massive = new int[length];

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0,2);
        index++;
    }
}

FillArray(Massive);
PrintArray(Massive);
Console.WriteLine();