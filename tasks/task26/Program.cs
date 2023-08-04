Console.Clear();

Console.WriteLine("Enter a number. ");

int x = Math.Abs(Convert.ToInt32(Console.ReadLine()));
Console.Clear();


int Dig(int number)
{
    int i = 0;
    
    if (number == 0)
    {
        i=1;
    }
    else
    {
        while (number > 0)
    {   number = number/10;
        i++;
    }
    }
    return i;
}

int DIG = Dig(x);
// for (int count = 0; x > 0; count++)
// {
//     x = x/10;
// }

Console.Write($"The number of digits in x equals {DIG} ");
Console.WriteLine();