Console.Clear();
Console.WriteLine("Enter length: ");
int length = int.Parse(Console.ReadLine());

int [] arr = array(length);

int [] array (int size)
{
    int [] array = new int [size];

    for(int i=0; i<array.Length;i++)
    {
        array[i] = new Random().Next(10,1000);
    }
    return array;
}
Console.WriteLine();
Console.WriteLine("The random massive is: " + '[' + string.Join(", ", arr) + ']' + ".");

copy(arr);

void copy(int [] arr)
{
    int [] newarr = new int [arr.Length];

    for(int i = 0; i < arr.Length; i++)
    {
       newarr [i] = arr [i];
    }

    Console.WriteLine("The copied arr is: " + '[' + string.Join(", ", newarr) + ']' + ".");
}