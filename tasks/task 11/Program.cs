Console.Clear();
int x = new Random().Next(100, 1000);

Console.WriteLine($"Random number is {x}");

void FillArray(int[] number)
{
    int length = number.Length;
    int index = 0;
    while (index < length)
    {
        if (index == 0)
        {
            number[index] = x/100;
            index++;
        }
        else if (index == 1)
        {
            number[index] = x%100/10;
            index++;
        }
        else
        {
            number[index] = x%100%10;
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

int[] number = new int[3];
FillArray(number);
Console.Write("We have three digits in ");
PrintArray(number);

Console.Write($". The first and the second digits are {number[0]} and {number[2]}.");
Console.WriteLine($" So new number is {number[0]}{number[2]}.");
Console.WriteLine();