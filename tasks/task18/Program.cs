Console.Clear();

Console.WriteLine("Enter number of quarter. ");

int quarter = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.WriteLine($"The number of quarter is {quarter}.");
if (5>quarter & quarter>0)
{
if (quarter==1) Console.WriteLine("The local diaposone of points XY is [x>0 & y>0]");
if (quarter==2) Console.WriteLine("The local diaposone of points XY is [x<0 & y>0]");
if (quarter==3) Console.WriteLine("The local diaposone of points XY is [x<0 & y<0]");
if (quarter==4) Console.WriteLine("The local diaposone of points XY is [x>0 & y<0]");
}
else Console.WriteLine("The quarter belongs from 1 to 4!");
