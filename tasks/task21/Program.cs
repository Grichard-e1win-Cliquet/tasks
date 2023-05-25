Console.Clear();

Console.WriteLine("Enter coordinates XY for two points(A and B). ");

Console.Write("Enter Xa = ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Ya = ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Xb = ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Yb = ");
int yb = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt((Math.Pow((xa-xb), 2) + Math.Pow((ya-yb), 2)));

Console.WriteLine($"The distance from point A to point B is {Math.Round(d, 2)}");