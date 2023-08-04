Console.Clear();

Console.WriteLine("Enter a number. ");

int x = Convert.ToInt32(Console.ReadLine());
Console.Clear();


int Fuck(int num)
{   
    int Fuuu = 1;
    if (num > 0)
    {
        for (int i =1; i <= num; i++)
        {
            Fuuu = Fuuu * i;
        }
    }
    else
    {   
        Fuuu = 0;
    }
    return Fuuu;
}

int FUCK = Fuck(x);

Console.Write($"Fucktorial from 'x' equals {FUCK} ");
Console.WriteLine();