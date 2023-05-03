Console.Clear();
Console.WriteLine("Enter a count (from 1 to 7) of day of the week:");

int x = Math.Abs(Convert.ToInt32(Console.ReadLine()));

switch(x)
{
    case 1:
        Console.WriteLine("Monday isn't a holiday");
        break;
    case 2:
        Console.WriteLine("Tuesday isn't a holiday");
        break;
    case 3:
        Console.WriteLine("Wednesday isn't a holiday");
        break;
    case 4:
        Console.WriteLine("Thursday isn't a holiday");
        break;
    case 5:
        Console.WriteLine("Friday isn't a holiday");
        break;
    case >7:
        Console.WriteLine("7 days in a week , punk!");
        break;
    default:
        Console.WriteLine("it's a holiday, baby!");
        break;
}
