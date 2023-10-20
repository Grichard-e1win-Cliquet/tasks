Console.Clear();
Console.Write("Enter a length of massive: ");

int length = int.Parse(Console.ReadLine());
int [] array = RandomMassive(length);

int [] RandomMassive (int Length)
{
    int [] arr = new int [Length];
    
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
    return  arr;
}

Console.WriteLine("Massive is: " + '[' + string.Join (",", array)+ ']' + ".");

int [] reverse = ReverseMassive(array);

int [] ReverseMassive(int [] arr)
{
    int j = arr.Length - 1;

    for (int i = 0; i < arr.Length/2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
        j--;
    }
    return arr;
}

Console.WriteLine("The reversed massive is" + '[' + string.Join (",", reverse) + ']' + ".");