Console.Clear();
Console.Write("Enter a length of massive: ");

int length = Math.Abs(int.Parse(Console.ReadLine()));
int [] arr = new int [length];

void FillArr(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
}

FillArr(arr);

Console.WriteLine("Вывод массива: ");
Console.Write('[' + string.Join(", ", arr) + ']');
Console.WriteLine();
