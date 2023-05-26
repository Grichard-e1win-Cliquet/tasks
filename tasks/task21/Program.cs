Console.Clear();

Console.WriteLine("Enter coordinates XYZ for two points(A and B). ");

Console.Write("Enter Xa = ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Ya = ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Za = ");
int za = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Xb = ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Yb = ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Zb = ");
int zb = Convert.ToInt32(Console.ReadLine());

Console.Clear();

double d = Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2) + Math.Pow(zb - za, 2));

Console.WriteLine($"The distance from point A[{xa},{ya},{za}] to point B[{xb},{yb},{zb}] equals {Math.Round(d, 2)}");