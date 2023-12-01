Console.Clear();

Console.WriteLine("Enter a number: ");

int num = int.Parse(Console.ReadLine());
// int count = 0;

// void numbers(int num)
// {
//     if(num ==0) return;
//     count+=1;
//     Console.Write($"{count} ");
//     numbers(num -1);
// }

numbers(num);
Console.WriteLine();

void numbers(int num)
{
    if(num ==0) return;
    numbers(num -1);
    Console.Write($"{num} ");
}
