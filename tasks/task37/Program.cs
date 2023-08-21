Console.Clear();
Console.Write("Enter a length of massive: ");

int length = int.Parse(Console.ReadLine());
int [] array = RandomMassive(length);

int [] RandomMassive (int Length)
{
    int [] arr = new int [Length];
    
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return  arr;
}

Console.WriteLine("Massive is: " + '[' + string.Join (",", array)+ ']' + ".");

int[] Multiarr (int[] arr)
{
    // int newLength = arr.Length%2 + arr.Length/2;
    if(arr.Length%2==0 && arr.Length > 2)
    {
        int [] Multi = new int[arr.Length/2];
        int j = arr.Length-1;
        for(int i=0; i<(arr.Length/2);i++)
        {
            Multi[i] = arr[i]*arr[j-i];
        }
        return Multi;
    }
    else if(arr.Length == 2)
    {
        int [] Multi = new int[1];
        Multi[0] = arr[0]*arr[1];
        return Multi;
    }
    else
    {
        int [] Multi = new int[((arr.Length-1)/2)+1];
        int j = arr.Length-1;
        for(int i=0; i<(((arr.Length-1)/2));i++) 
        // можно просто arr.Length/2
        {
            Multi[i] = arr[i]*arr[j-i];
        }
        Multi[(arr.Length-1)/2] = arr[(arr.Length-1)/2];
        // можно просто arr.Length/2
        return Multi;
    }
}

int [] Multiplied = Multiarr(array);

Console.WriteLine("New massive with multiplied pairs is: " + '[' + string.Join (",", Multiplied)+ ']' + ".");

