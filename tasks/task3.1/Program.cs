Console.Clear();
Console.WriteLine("Enter a number from 1 to 7 to see Day of week: ");
int x = Convert.ToInt32(Console.ReadLine());

switch(x)
{
    case 1:
        Console.WriteLine("Today is Monday");
        break;
    case 2:
        Console.WriteLine("Today is Tuesday");
        break;
    case 3:
        Console.WriteLine("Today is Wednesday");
        break;
    case 4:
        Console.WriteLine("Today is Thursday");
        break;
    case 5:
        Console.WriteLine("Today is Friday");
        break;
    case 6:
        Console.WriteLine("Today is Saturday");
        break;
    case 7:
        Console.WriteLine("Today is Sunday");
        break;
    default:
        Console.WriteLine("Only seven days in the week, Idiot");
        break;
}
