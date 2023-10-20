Console.Clear();
Console.WriteLine("Enter a three length of triangle. ");

Console.WriteLine("Enter A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Enter B: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine("Enter C: ");
int C = int.Parse(Console.ReadLine());

if(A + B > C && B + C > A && C + A > B) Console.WriteLine($"Triangle with sides {A}, {B} and {C} can exist.");
else 
{
    Console.WriteLine($"Triangle with sides {A}, {B} and {C} cannot exist.");
}
