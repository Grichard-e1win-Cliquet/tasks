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
Console.WriteLine("Massive is:        "+ '[' + string.Join(", ", array) + ']');

Changepolar(array);

void Changepolar (int [] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(array[i] != 0)
        {
            array[i]*= -1;
        }
    }
    Console.WriteLine("Revert massive is: "+ '[' + string.Join(", ", arr) + ']');
}