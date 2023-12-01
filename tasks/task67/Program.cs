Console.Clear();

Console.WriteLine("Enter a number: ");

int num = int.Parse(Console.ReadLine());
int count = 0;

void numbers(int num)
{
    if(num ==0) 
    {
        Console.Write($"{count} ");
        return;
    }
    count = count + num%10;
    numbers(num/10);
}

numbers(num);
Console.WriteLine();
