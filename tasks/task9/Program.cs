Console.Clear();
int x = new Random().Next(10, 100);

Console.WriteLine($"Random number is {x}");

void FillArray(int[] number)
{
    int length = number.Length;
    int index = 0;
    while (index < length)
    {
        if (index == 0)
        {
            number[index] = x/10;
            index++;
        }
        else
        {
            number[index] = x%10;
            index++;
        }
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}");
        position++;
    }
}

int[] number = new int[2];
FillArray(number);
Console.Write("We have two digits in ");
PrintArray(number);

int max = number[0];
if (max > number[1])
{
    Console.Write($". Max of these digits is {max}.");
}
else if (max < number[1]) 
{
    max = number[1]; Console.Write($". Max of these digits is {max}.");
}
else
{
    Console.Write(". These are both max.");
}
Console.WriteLine();

// можно просто ввести две переменные а и б, где мы будем первое делить на 10, а второе %10