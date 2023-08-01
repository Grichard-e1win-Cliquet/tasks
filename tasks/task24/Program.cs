Console.Clear();

Console.WriteLine("Enter a number. ");

int A = Convert.ToInt32(Console.ReadLine());
Console.Clear();

int Sum(int number)
{
    int SUM = 0;
    if (number>0)
{
    for (int i = 1; i <= number; i++)
    {
        SUM = SUM + i;
    }
    return SUM;
}
    else
{
    for (int i = 1; i >= number; i--)
    {
        SUM = SUM + i;
    }
    return SUM;
}
}

int SUM = Sum(A);

// if (A>0)
// {
//     for (int i = 1; i <= A; i++)
//     {
//         SUM = SUM + i;
//     }
//     Console.Write($"The sum of numbers from 1 to A is {SUM} ");
// }
// else
// {
//     for (int i = 1; i >= A; i--)
//     {
//         SUM = SUM + i;
//     }
//     Console.Write($"The sum of numbers from 1 to A is {SUM} ");
// }
Console.Write($"The sum of numbers from 1 to A is {SUM} ");
Console.WriteLine();