Console.Clear();

Console.WriteLine("Enter X and Y. ");

Console.Write("Enter X = ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Y = ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0) Console.WriteLine("X and Y must not be equals 0.");
else
{
    Console.WriteLine($"The point coordinates XY is [{x} {y}].");
    if (x>0 & y>0) Console.WriteLine("The point XY belong to the first quarter.");
    if (x<0 & y>0) Console.WriteLine("The point XY belong to the second quarter.");
    if (x<0 & y<0) Console.WriteLine("The point XY belong to the third quarter.");
    if (x>0 & y<0) Console.WriteLine("The point XY belong to the fourth quarter.");
}
// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// if (e > max) max = e;


// switch (x.y)
// {
//     case (x>0 & y>0):
//         Console.WriteLine("The point XY belong to the first quarter.");
//         break;
//     case (x<0 & y>0):
//         Console.WriteLine("The point XY belong to the second quarter.");
//         break;
//     case (x<0 & y<0):
//         Console.WriteLine("The point XY belong to the third quarter.");
//         break;
//     case (x>0 & y<0):
//         Console.WriteLine("The point XY belong to the fourth quarter.");
//         break;
//     default:
//         Console.WriteLine("X and Y must be more than 0.");
//         break;
// }