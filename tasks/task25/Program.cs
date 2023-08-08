// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();

Console.WriteLine("Enter two numbers.");

Console.WriteLine("Enter A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter B:");
int B = Convert.ToInt32(Console.ReadLine());
double result = A;

if(B == 0)
{
    result = 1;
}
else
{
    if(B > 0)
    {
        for(int count = 1; count < B; count++)
        {
        result = result*A;
        }
    }
    else
    {
        for(int count = 1; count < Math.Abs(B); count++)
        {
        result = result*A;
        }
        result = 1/result;
    }
}
Console.Write($"{A} to degree {B} equals {result}.");
Console.WriteLine();