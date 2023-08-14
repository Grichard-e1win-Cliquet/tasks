Console.Clear();
Console.Write("Enter a length of massive: ");

int length = int.Parse(Console.ReadLine());
int [] array = RandomMassive(length);

int [] RandomMassive (int Length)
{
    int [] arr = new int [Length];
    
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-999, 1000);
    }
    return  arr;
}

Console.WriteLine("Massive is: " + '[' + string.Join (",", array)+ ']' + ".");

Console.WriteLine("Enter diaposone where will we find quantity of elements.");

int [] diaposon = new int [2];

Console.Write("Enter from: ");
diaposon[0] = int.Parse(Console.ReadLine());
Console.Write("Enter to: ");
diaposon[1] = int.Parse(Console.ReadLine());

int count = Count(diaposon, array);

int Count(int[] diapos, int [] arr)
{
    int howmuch = 0;

    for(int i=0; i<arr.Length;i++)
    {
        if(arr[i] >= diapos[0] && arr[i] <= diapos[1])
        {
            howmuch+=1;
        }
    }
    return howmuch;
}

Console.WriteLine("The qunatity of elements in diaposone" + '[' + string.Join (",", diaposon) + ']' + $" in our massive equals {count}.");